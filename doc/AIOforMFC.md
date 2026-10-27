# AIOforMFC — ソースコード解説

## 1. 概要

AIOforMFC は、Windows Forms で作成されたマスフローコントローラ（MFC）の流量制御アプリケーションである。CONTEC のアナログ出力デバイスを介して MFC に設定信号を送り、低流量・高流量の保持と、その間の増減を繰り返す。ハードウェア設定、D/A 出力の2点校正、運転条件の保存にも対応する。

本書は GitHub の `main` ブランチの C# ソースを静的に調査した結果であり、実機動作やビルドの検証結果ではない。

## 2. 開発環境・依存関係

- ソリューション: `AIOforMFC.sln`
- プロジェクト: `AIOforMFC/AIOforMFC.csproj`
- 言語・UI: C#、Windows Forms（従来形式の .csproj）
- ターゲット: **.NET Framework 4.7.2**（プロジェクトファイルに明記）
- 出力形式: Windows GUI アプリケーション（`WinExe`）
- Debug/Release: `AnyCPU`、`AllowUnsafeBlocks=true`
- 外部依存: `CaioCs.cs` に収録された CONTEC AIO API の P/Invoke ラッパー、および対応するデバイスドライバー・実機
- 設定保存: Windows レジストリ `HKEY_CURRENT_USER\SOFTWARE\seikeifslab\AIOforMFC`

Visual Studio 2022 で開く場合は .NET Framework 4.7.2 の targeting pack が必要。実機へのアクセスには CONTEC の対応ドライバー、デバイス名の設定が必要である。実行環境のビット数とネイティブ DLL の整合も確認すること。

## 3. ファイルとクラス

| ファイル | 主な役割 |
| --- | --- |
| `Program.cs` | エントリーポイント、設定保存クラス `Chwparams`、`Cregsettings`、`Cregbounds`、ハードウェア制御クラス `Cmfc` |
| `Form1.cs` | メイン画面、流量・時間の設定、運転状態の遷移、タイマー制御 |
| `Form2.cs` | `FormCalib`: 流量と D/A デジタル値の2点校正 |
| `Form3.cs` | `FormHWsetting`: AIO デバイス名と MFC 最大流量の設定 |
| `Form*.Designer.cs` | Windows Forms のコントロール、イベント、タイマー設定 |
| `CaioCs.cs` | CONTEC AIO API の定数・関数宣言を含む相互運用ラッパー |
| `App.config`, `Properties/` | .NET アプリケーション構成、アセンブリ情報・リソース等 |

`Program.Main()` は `Application.Run(new Form1())` を実行する。

## 4. ハードウェア出力と校正

`Cmfc` は `Caio` インスタンスを保持し、コンストラクタで `aio.Init(dev_name, out Id)` を呼ぶ。使用するアナログ出力チャネルは `aoch = 0` 固定である。`flowset(flow)` は指定流量をデジタル出力値に変換し、`aio.SingleAo(Id, aoch, d_out)` に渡す。`doutset(d_out)` は校正用にデジタル値を直接出力する。

2点校正の変換式は次のとおり。

```text
daratio = (dbound2 - dbound1) / (abound2 - abound1)
d_out   = Round(daratio * (flow - abound1)) + dbound1
```

`abound1`, `abound2` は流量 [sccm]、`dbound1`, `dbound2` は D/A に渡すデジタル値である。初期値はそれぞれ (0.00, 5.00) sccm と (32767, 49152)。`set_bounds()` は値を更新して変換係数を再計算する。値の丸めには `Math.Round` を用いる。

校正画面 `FormCalib` は Bound1/Bound2 のデジタル値を個別に試験出力でき、Save でレジストリに保存して `Cmfc` に反映する。画面の入力制限は流量 0–21 sccm、デジタル値 32000–50000 で、2点の大小関係も確認する。これらは UI の制限であり、実際のデバイスの許容範囲を保証するものではない。

## 5. 運転シーケンス

メイン画面 `Form1` は、次の状態文字列を使う。

| 状態 | 意味 | 主な動作 |
| --- | --- | --- |
| `shut` | 起動時の初期状態 | コンストラクタで設定 |
| `stop` | Start 後、循環動作前／Shut 後 | 設定流量を保持、または出力ゼロ |
| `high` | 高流量保持 | `highTimer` により保持時間を計数 |
| `dec` | 流量減少 | `decTimer` で `q_step` ずつ減少 |
| `low` | 低流量保持 | `lowTimer` により保持時間を計数 |
| `inc` | 流量増加 | `incTimer` で `q_step` ずつ増加 |

Start は選択した `Q.high` または `Q.low` を出力し、Up/Down で循環を開始する。循環順は **high → dec → low → inc → high → …**（低流量から開始した場合は low → inc → high …）。Pause は現在のタイマーを停止し、Resume で再開する。Shut は流量 0 を指示してすべてのタイマーを停止する。フォーム終了時も `flowset(0.0F)` を呼ぶ。

`highTimer` と `lowTimer` は Designer 上で `Interval = 1000` ms。`incTimer` と `decTimer` には Interval の明示指定がなく、Windows Forms Timer の既定値（100 ms）に依存する。

`q_step = q_rate / 10` なので、100 ms ごとに1ステップ進める設計であり、通常は `q_rate` [sccm/s] に相当する増減速度を意図していると解釈できる。ただし Windows Forms Timer は UI スレッドのメッセージ処理に依存するため、厳密な時間制御ではない。

保持時間は `t_count` を毎秒増やし、`t_count > t_high` または `t_count > t_low` で次状態に移る。したがって指定値 N に対し N+1 回目の Tick で遷移する点に注意。

## 6. 操作パラメータ

| パラメータ | 意味 | 入力上の制約 |
| --- | --- | --- |
| `q_high` | 高流量 [sccm] | `q_low < q_high <= q_max` |
| `q_low` | 低流量 [sccm] | `0 <= q_low < q_high` |
| `q_rate` | 流量変化速度（設計上 sccm/s） | 0.01–1.00 |
| `t_high` | 高流量保持のタイマーカウント | `Int16` への変換のみ |
| `t_low` | 低流量保持のタイマーカウント | `Int16` への変換のみ |
| `q_max` | MFC 最大流量 [sccm] | ハードウェア設定画面から設定 |

Designer の初期表示は `Q.high=4.50`, `Q.low=3.50`, `Q.rate=0.10`, `T.high=20`, `T.low=20`。一方、`Form1` コンストラクタの `q_low` は 3.0、保存設定クラスの初期値は `q_high=4.0`, `q_low=2.0` である。実際の起動時には画面の値の読み込みとレジストリ値の適用が行われるので、初期値を一元化するのが望ましい。

## 7. レジストリ設定

すべて `HKEY_CURRENT_USER\SOFTWARE\seikeifslab\AIOforMFC` 配下で管理する。

| サブキー | 値 |
| --- | --- |
| `hwparams` | `dev_name`, `q_max` |
| `settings` | `q_high`, `q_low`, `q_rate`, `t_high`, `t_low` |
| `bounds` | `abound1`, `abound2`, `dbound1`, `dbound2` |

各値はレジストリの文字列（`RegistryValueKind.String`）として保存する。`hwparams` の既定値はデバイス名 `AIO000`、最大流量 `5.00`。ハードウェア設定の変更後は再起動を促すが、プログラム自身による自動再接続はない。

## 8. 注意点・改善候補（静的解析）

1. **AIO 初期化失敗後も処理が継続する。** `Cmfc` コンストラクタは `aio.Init` の非ゼロ戻り値で設定画面を開くが、その後も `flowset(0)` を実行する。出力 API の戻り値も確認していない。失敗時には制御を開始しない設計が望ましい。
2. **デバイス解放処理が見当たらない。** `Caio` の終了処理（該当 API がある場合）を確認し、終了時に実行する必要がある。
3. **校正画面と運転画面が同時操作できる。** `FormCalib.Show()` は非モーダルであり、校正出力と運転タイマーの出力が競合し得る。校正中は運転を禁止するなどの排他制御が必要。
4. **校正データが未登録の場合の反映順序。** `Form1_Load` は校正画面を `Show()` した直後、保存前の `regbounds` の既定値を `mfc.set_bounds()` に適用する。校正を完了するまでは運転できないようにする方が安全。
5. **出力値の範囲検査が不足。** `flowset()` は要求流量・計算結果を明示的に制限しない。D/A の実際の有効範囲を確認してクランプまたはエラーにすべき。
6. **保持時間の off-by-one。** `t_count > t_high/t_low` により指定秒数より1 Tick 長くなる可能性がある。`>=` とカウント開始時刻の整理が必要。
7. **時間入力の検証不足。** `t_high` / `t_low` は負値も受け付け、`Convert.ToInt16` の `OverflowException` は捕捉していない。また Enter 判定が `!isTextBoxTHChanged` / `!isTextBoxTLChanged` となっており、他の入力欄と逆である。
8. **レジストリ読み込みの堅牢性。** キーが存在しても値が欠ける場合や数値文字列が不正な場合の例外処理がない。文化依存の小数点解釈にも注意。
9. **Pause/Resume と設定変更の整合。** 停止中の設定変更は可能だが、`q_out` や現在状態との整合を検証していない。特に保持・増減中の目標値変更は動作確認が必要。
10. **終了時のゼロ出力はソフトウェア依存。** 正常終了時にはゼロを指示するが、異常終了・通信断・電源断を含めた安全停止は保証できない。実機側のフェイルセーフが必要。
11. **ネイティブ API とビット数。** `AnyCPU` のままではドライバーとのアーキテクチャ不一致が起こり得る。実機環境で x86/x64 を確認すること。
12. **Release 構成でも最適化が無効。** `.csproj` では Release の `Optimize=false`。動作上必須の問題ではないが意図を確認するとよい。

これらはソースから推定できる潜在的な問題点であり、実機で再現を確認した不具合一覧ではない。

## 9. 推奨する確認手順

1. 対応する CONTEC AIO デバイス、ドライバー、デバイス名、D/A 出力レンジ、MFC の入力仕様を照合する。
2. 出力を安全に測定できる状態で、校正点と中間点のデジタル値・出力電圧を確認する。
3. Start、Up/Down、Pause/Resume、Shut の各状態遷移と保持時間を記録する。
4. 校正画面を開いたままの操作、デバイス未接続、異常終了時の安全動作を検証する。
5. 実測結果に基づいて例外処理、状態管理、フェイルセーフを改善する。

## 10. ソースへの参照

- [Program.cs](../AIOforMFC/Program.cs)
- [Form1.cs](../AIOforMFC/Form1.cs)
- [Form2.cs](../AIOforMFC/Form2.cs)
- [Form3.cs](../AIOforMFC/Form3.cs)
- [CaioCs.cs](../AIOforMFC/CaioCs.cs)
- [AIOforMFC.csproj](../AIOforMFC/AIOforMFC.csproj)
