namespace AIOforMFC
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.incTimer = new System.Windows.Forms.Timer(this.components);
            this.highTimer = new System.Windows.Forms.Timer(this.components);
            this.decTimer = new System.Windows.Forms.Timer(this.components);
            this.lowTimer = new System.Windows.Forms.Timer(this.components);
            this.labelQH = new System.Windows.Forms.Label();
            this.labelQL = new System.Windows.Forms.Label();
            this.textBoxQH = new System.Windows.Forms.TextBox();
            this.textBoxQL = new System.Windows.Forms.TextBox();
            this.labelTH = new System.Windows.Forms.Label();
            this.labelTL = new System.Windows.Forms.Label();
            this.textBoxTH = new System.Windows.Forms.TextBox();
            this.textBoxTL = new System.Windows.Forms.TextBox();
            this.buttonQHinc = new System.Windows.Forms.Button();
            this.buttonQHdec = new System.Windows.Forms.Button();
            this.buttonQLinc = new System.Windows.Forms.Button();
            this.buttonQLdec = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MFCcalibToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonUpDown = new System.Windows.Forms.Button();
            this.buttonShut = new System.Windows.Forms.Button();
            this.labelRate = new System.Windows.Forms.Label();
            this.textBoxQR = new System.Windows.Forms.TextBox();
            this.labelFlow = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.labelInc = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelDec = new System.Windows.Forms.Label();
            this.comboBoxSF = new System.Windows.Forms.ComboBox();
            this.labelSF = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // incTimer
            // 
            this.incTimer.Tick += new System.EventHandler(this.IncTimer_Tick);
            // 
            // highTimer
            // 
            this.highTimer.Interval = 1000;
            this.highTimer.Tick += new System.EventHandler(this.HighTimer_Tick);
            // 
            // decTimer
            // 
            this.decTimer.Tick += new System.EventHandler(this.DecTimer_Tick);
            // 
            // lowTimer
            // 
            this.lowTimer.Interval = 1000;
            this.lowTimer.Tick += new System.EventHandler(this.LowTimer_Tick);
            // 
            // labelQH
            // 
            this.labelQH.AutoSize = true;
            this.labelQH.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelQH.Location = new System.Drawing.Point(15, 43);
            this.labelQH.Name = "labelQH";
            this.labelQH.Size = new System.Drawing.Size(200, 33);
            this.labelQH.TabIndex = 1;
            this.labelQH.Text = "Q.high (sccm)";
            // 
            // labelQL
            // 
            this.labelQL.AutoSize = true;
            this.labelQL.Font = new System.Drawing.Font("MS UI Gothic", 24.25F);
            this.labelQL.Location = new System.Drawing.Point(15, 103);
            this.labelQL.Name = "labelQL";
            this.labelQL.Size = new System.Drawing.Size(193, 33);
            this.labelQL.TabIndex = 2;
            this.labelQL.Text = "Q.low (sccm)";
            // 
            // textBoxQH
            // 
            this.textBoxQH.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxQH.Location = new System.Drawing.Point(210, 40);
            this.textBoxQH.Name = "textBoxQH";
            this.textBoxQH.Size = new System.Drawing.Size(80, 39);
            this.textBoxQH.TabIndex = 3;
            this.textBoxQH.Text = "4.50";
            this.textBoxQH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxQH.TextChanged += new System.EventHandler(this.TextBoxQH_TextChanged);
            this.textBoxQH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxQH_KeyDown);
            this.textBoxQH.Leave += new System.EventHandler(this.TextBoxQH_Leave);
            // 
            // textBoxQL
            // 
            this.textBoxQL.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxQL.Location = new System.Drawing.Point(210, 100);
            this.textBoxQL.Name = "textBoxQL";
            this.textBoxQL.Size = new System.Drawing.Size(80, 39);
            this.textBoxQL.TabIndex = 4;
            this.textBoxQL.Text = "3.50";
            this.textBoxQL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxQL.TextChanged += new System.EventHandler(this.TextBoxQL_TextChanged);
            this.textBoxQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxQL_KeyDown);
            this.textBoxQL.Leave += new System.EventHandler(this.TextBoxQL_Leave);
            // 
            // labelTH
            // 
            this.labelTH.AutoSize = true;
            this.labelTH.Font = new System.Drawing.Font("MS UI Gothic", 24.25F);
            this.labelTH.Location = new System.Drawing.Point(348, 43);
            this.labelTH.Name = "labelTH";
            this.labelTH.Size = new System.Drawing.Size(142, 33);
            this.labelTH.TabIndex = 5;
            this.labelTH.Text = "T.high (s)";
            // 
            // labelTL
            // 
            this.labelTL.AutoSize = true;
            this.labelTL.Font = new System.Drawing.Font("MS UI Gothic", 24.25F);
            this.labelTL.Location = new System.Drawing.Point(348, 103);
            this.labelTL.Name = "labelTL";
            this.labelTL.Size = new System.Drawing.Size(131, 33);
            this.labelTL.TabIndex = 6;
            this.labelTL.Text = "T.low (s)";
            // 
            // textBoxTH
            // 
            this.textBoxTH.Font = new System.Drawing.Font("MS UI Gothic", 24.25F);
            this.textBoxTH.Location = new System.Drawing.Point(498, 40);
            this.textBoxTH.Name = "textBoxTH";
            this.textBoxTH.Size = new System.Drawing.Size(60, 40);
            this.textBoxTH.TabIndex = 7;
            this.textBoxTH.Text = "20";
            this.textBoxTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTH.TextChanged += new System.EventHandler(this.TextBoxTH_TextChanged);
            this.textBoxTH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxTH_KeyDown);
            this.textBoxTH.Leave += new System.EventHandler(this.TextBoxTH_Leave);
            // 
            // textBoxTL
            // 
            this.textBoxTL.Font = new System.Drawing.Font("MS UI Gothic", 24.25F);
            this.textBoxTL.Location = new System.Drawing.Point(498, 96);
            this.textBoxTL.Name = "textBoxTL";
            this.textBoxTL.Size = new System.Drawing.Size(60, 40);
            this.textBoxTL.TabIndex = 8;
            this.textBoxTL.Text = "20";
            this.textBoxTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTL.TextChanged += new System.EventHandler(this.TextBoxTL_TextChanged);
            this.textBoxTL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxTL_KeyDown);
            this.textBoxTL.Leave += new System.EventHandler(this.TextBoxTL_Leave);
            // 
            // buttonQHinc
            // 
            this.buttonQHinc.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonQHinc.Location = new System.Drawing.Point(293, 36);
            this.buttonQHinc.Name = "buttonQHinc";
            this.buttonQHinc.Size = new System.Drawing.Size(30, 23);
            this.buttonQHinc.TabIndex = 9;
            this.buttonQHinc.Text = "△";
            this.buttonQHinc.UseVisualStyleBackColor = false;
            this.buttonQHinc.Click += new System.EventHandler(this.ButtonQHinc_Click);
            // 
            // buttonQHdec
            // 
            this.buttonQHdec.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonQHdec.Location = new System.Drawing.Point(293, 60);
            this.buttonQHdec.Name = "buttonQHdec";
            this.buttonQHdec.Size = new System.Drawing.Size(31, 23);
            this.buttonQHdec.TabIndex = 10;
            this.buttonQHdec.Text = "▽";
            this.buttonQHdec.UseVisualStyleBackColor = false;
            this.buttonQHdec.Click += new System.EventHandler(this.ButtonQHdec_Click);
            // 
            // buttonQLinc
            // 
            this.buttonQLinc.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonQLinc.Location = new System.Drawing.Point(293, 96);
            this.buttonQLinc.Name = "buttonQLinc";
            this.buttonQLinc.Size = new System.Drawing.Size(31, 23);
            this.buttonQLinc.TabIndex = 11;
            this.buttonQLinc.Text = "▲";
            this.buttonQLinc.UseVisualStyleBackColor = false;
            this.buttonQLinc.Click += new System.EventHandler(this.ButtonQLinc_Click);
            // 
            // buttonQLdec
            // 
            this.buttonQLdec.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonQLdec.Location = new System.Drawing.Point(293, 120);
            this.buttonQLdec.Name = "buttonQLdec";
            this.buttonQLdec.Size = new System.Drawing.Size(31, 23);
            this.buttonQLdec.TabIndex = 12;
            this.buttonQLdec.Text = "▼";
            this.buttonQLdec.UseVisualStyleBackColor = false;
            this.buttonQLdec.Click += new System.EventHandler(this.ButtonQLdec_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(602, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.MFCcalibToolStripMenuItem,
            this.saveSettingsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.configToolStripMenuItem.Text = "HW Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.HWconfigToolStripMenuItem_Click);
            // 
            // MFCcalibToolStripMenuItem
            // 
            this.MFCcalibToolStripMenuItem.Name = "MFCcalibToolStripMenuItem";
            this.MFCcalibToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.MFCcalibToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.MFCcalibToolStripMenuItem.Text = "MFC Calib.";
            this.MFCcalibToolStripMenuItem.Click += new System.EventHandler(this.MFCcalibToolStripMenuItem_Click);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.SaveSettingsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.buttonStart.Location = new System.Drawing.Point(15, 271);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(125, 46);
            this.buttonStart.TabIndex = 15;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Enabled = false;
            this.buttonPause.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.buttonPause.Location = new System.Drawing.Point(306, 271);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(125, 46);
            this.buttonPause.TabIndex = 16;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // buttonUpDown
            // 
            this.buttonUpDown.Enabled = false;
            this.buttonUpDown.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.buttonUpDown.Location = new System.Drawing.Point(159, 271);
            this.buttonUpDown.Name = "buttonUpDown";
            this.buttonUpDown.Size = new System.Drawing.Size(125, 46);
            this.buttonUpDown.TabIndex = 17;
            this.buttonUpDown.Text = "UpDown";
            this.buttonUpDown.UseVisualStyleBackColor = true;
            this.buttonUpDown.Click += new System.EventHandler(this.ButtonUpDown_Click);
            // 
            // buttonShut
            // 
            this.buttonShut.Enabled = false;
            this.buttonShut.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.buttonShut.Location = new System.Drawing.Point(447, 271);
            this.buttonShut.Name = "buttonShut";
            this.buttonShut.Size = new System.Drawing.Size(125, 46);
            this.buttonShut.TabIndex = 18;
            this.buttonShut.Text = "Shut";
            this.buttonShut.UseVisualStyleBackColor = true;
            this.buttonShut.Click += new System.EventHandler(this.ButtonShut_Click);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("MS UI Gothic", 24.25F);
            this.labelRate.Location = new System.Drawing.Point(251, 165);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(236, 33);
            this.labelRate.TabIndex = 19;
            this.labelRate.Text = "Q.rate (sccm/s)";
            // 
            // textBoxQR
            // 
            this.textBoxQR.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxQR.Location = new System.Drawing.Point(478, 165);
            this.textBoxQR.Name = "textBoxQR";
            this.textBoxQR.Size = new System.Drawing.Size(80, 39);
            this.textBoxQR.TabIndex = 20;
            this.textBoxQR.Text = "0.10";
            this.textBoxQR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxQR.TextChanged += new System.EventHandler(this.TextBoxQR_TextChanged);
            this.textBoxQR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxQR_KeyDown);
            this.textBoxQR.Leave += new System.EventHandler(this.TextBoxQR_Leave);
            // 
            // labelFlow
            // 
            this.labelFlow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFlow.AutoSize = true;
            this.labelFlow.Font = new System.Drawing.Font("MS UI Gothic", 24.25F);
            this.labelFlow.ForeColor = System.Drawing.Color.Blue;
            this.labelFlow.Location = new System.Drawing.Point(43, 224);
            this.labelFlow.Name = "labelFlow";
            this.labelFlow.Size = new System.Drawing.Size(78, 33);
            this.labelFlow.TabIndex = 21;
            this.labelFlow.Text = "Flow";
            this.labelFlow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLow
            // 
            this.labelLow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLow.AutoSize = true;
            this.labelLow.Font = new System.Drawing.Font("MS UI Gothic", 24.25F);
            this.labelLow.ForeColor = System.Drawing.Color.Blue;
            this.labelLow.Location = new System.Drawing.Point(176, 224);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(71, 33);
            this.labelLow.TabIndex = 22;
            this.labelLow.Text = "Low";
            this.labelLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInc
            // 
            this.labelInc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInc.AutoSize = true;
            this.labelInc.Font = new System.Drawing.Font("MS UI Gothic", 24.25F);
            this.labelInc.ForeColor = System.Drawing.Color.Blue;
            this.labelInc.Location = new System.Drawing.Point(271, 224);
            this.labelInc.Name = "labelInc";
            this.labelInc.Size = new System.Drawing.Size(57, 33);
            this.labelInc.TabIndex = 23;
            this.labelInc.Text = "Inc";
            this.labelInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHigh
            // 
            this.labelHigh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHigh.AutoSize = true;
            this.labelHigh.Font = new System.Drawing.Font("MS UI Gothic", 24.25F);
            this.labelHigh.ForeColor = System.Drawing.Color.Blue;
            this.labelHigh.Location = new System.Drawing.Point(348, 224);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(75, 33);
            this.labelHigh.TabIndex = 24;
            this.labelHigh.Text = "High";
            this.labelHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDec
            // 
            this.labelDec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDec.AutoSize = true;
            this.labelDec.Font = new System.Drawing.Font("MS UI Gothic", 24.25F);
            this.labelDec.ForeColor = System.Drawing.Color.Blue;
            this.labelDec.Location = new System.Drawing.Point(449, 224);
            this.labelDec.Name = "labelDec";
            this.labelDec.Size = new System.Drawing.Size(70, 33);
            this.labelDec.TabIndex = 25;
            this.labelDec.Text = "Dec";
            this.labelDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSF
            // 
            this.comboBoxSF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSF.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.comboBoxSF.FormattingEnabled = true;
            this.comboBoxSF.Items.AddRange(new object[] {
            "Q.high",
            "Q.low"});
            this.comboBoxSF.Location = new System.Drawing.Point(145, 177);
            this.comboBoxSF.Name = "comboBoxSF";
            this.comboBoxSF.Size = new System.Drawing.Size(84, 32);
            this.comboBoxSF.TabIndex = 26;
            // 
            // labelSF
            // 
            this.labelSF.AutoSize = true;
            this.labelSF.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.labelSF.Location = new System.Drawing.Point(17, 180);
            this.labelSF.Name = "labelSF";
            this.labelSF.Size = new System.Drawing.Size(122, 24);
            this.labelSF.TabIndex = 27;
            this.labelSF.Text = "Start From:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 350);
            this.Controls.Add(this.labelSF);
            this.Controls.Add(this.comboBoxSF);
            this.Controls.Add(this.labelDec);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.labelInc);
            this.Controls.Add(this.labelLow);
            this.Controls.Add(this.labelFlow);
            this.Controls.Add(this.textBoxQR);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.buttonShut);
            this.Controls.Add(this.buttonUpDown);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonQLdec);
            this.Controls.Add(this.buttonQLinc);
            this.Controls.Add(this.buttonQHdec);
            this.Controls.Add(this.buttonQHinc);
            this.Controls.Add(this.textBoxTL);
            this.Controls.Add(this.textBoxTH);
            this.Controls.Add(this.labelTL);
            this.Controls.Add(this.labelTH);
            this.Controls.Add(this.textBoxQL);
            this.Controls.Add(this.textBoxQH);
            this.Controls.Add(this.labelQL);
            this.Controls.Add(this.labelQH);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AIO for MFC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer incTimer;
        private System.Windows.Forms.Timer highTimer;
        private System.Windows.Forms.Timer decTimer;
        private System.Windows.Forms.Timer lowTimer;
        private System.Windows.Forms.Label labelQH;
        private System.Windows.Forms.Label labelQL;
        private System.Windows.Forms.TextBox textBoxQH;
        private System.Windows.Forms.TextBox textBoxQL;
        private System.Windows.Forms.Label labelTH;
        private System.Windows.Forms.Label labelTL;
        private System.Windows.Forms.TextBox textBoxTH;
        private System.Windows.Forms.TextBox textBoxTL;
        private System.Windows.Forms.Button buttonQHinc;
        private System.Windows.Forms.Button buttonQHdec;
        private System.Windows.Forms.Button buttonQLinc;
        private System.Windows.Forms.Button buttonQLdec;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MFCcalibToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonUpDown;
        private System.Windows.Forms.Button buttonShut;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.TextBox textBoxQR;
        private System.Windows.Forms.Label labelFlow;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label labelInc;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelDec;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxSF;
        private System.Windows.Forms.Label labelSF;
    }
}

