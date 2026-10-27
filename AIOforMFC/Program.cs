using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaioCs;
using Microsoft.Win32;

namespace AIOforMFC
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Chwparams
    {
        string dev_name = "AIO000";
        string q_max_str = "5.00";

        RegistryKey regkey;
        string regpath = @"SOFTWARE\seikeifslab\AIOforMFC\hwparams";

        public Chwparams()
        {
            dev_name = "AIO000";
            q_max_str = "5.00";
        }

        public bool read_registry()
        {
            regkey = Registry.CurrentUser.OpenSubKey(regpath, false);

            if(regkey == null)
            {
                return false;
            }
            dev_name = (string)regkey.GetValue("dev_name");
            q_max_str = (string)regkey.GetValue("q_max");

            regkey.Close();
            return true;
        }

        public void write_registry()
        {
            regkey = Registry.CurrentUser.CreateSubKey(regpath, true);
            regkey.SetValue("dev_name", dev_name, RegistryValueKind.String);
            regkey.SetValue("q_max", q_max_str, RegistryValueKind.String);

            regkey.Close();
        }

        public(string dn, string qm) get_value()
        {
            return (dev_name, q_max_str);
        }

        public void set_value(string dn, string qm)
        {
            dev_name = dn;
            q_max_str = qm;
        }
    }

    public class Cregsettings
    {
        float q_high, q_low, q_rate;
        int t_high, t_low;

        RegistryKey regkey;
        string regpath = @"SOFTWARE\seikeifslab\AIOforMFC\settings";

        public Cregsettings()
        {
            q_high = 4.0F;
            q_low = 2.0F;
            q_rate = 0.1F;
            t_high = 20;
            t_low = 20;
        }

        public bool read_registry()
        {
            string readout;
            regkey = Registry.CurrentUser.OpenSubKey(regpath, false);
            if (regkey == null) {
                return false;
            }
            readout = (string)regkey.GetValue("q_high");
            q_high = Convert.ToSingle(readout);
            readout = (string)regkey.GetValue("q_low");
            q_low = Convert.ToSingle(readout);
            readout = (string)regkey.GetValue("q_rate");
            q_rate = Convert.ToSingle(readout);

            readout = (string)regkey.GetValue("t_high");
            t_high = Convert.ToInt16(readout);
            readout = (string)regkey.GetValue("t_low");
            t_low = Convert.ToInt16(readout);

            regkey.Close();
            return true;
        }

        public void write_registry()
        {
            regkey = Registry.CurrentUser.CreateSubKey(regpath, true);

            regkey.SetValue("q_high", q_high.ToString("F2"), RegistryValueKind.String);
            regkey.SetValue("q_low",  q_low.ToString("F2"),  RegistryValueKind.String);
            regkey.SetValue("q_rate", q_rate.ToString("F2"), RegistryValueKind.String);
            regkey.SetValue("t_high", t_high.ToString(), RegistryValueKind.String);
            regkey.SetValue("t_low",  t_low.ToString(),  RegistryValueKind.String);

            regkey.Close();
        }

        public (float qh, float ql, float qr, int th, int tl) get_value()
        {
            return (q_high, q_low, q_rate, t_high, t_low);
        }

        public void set_value(float qh, float ql, float qr, int th, int tl)
        {
            q_high = qh;
            q_low = ql;
            q_rate = qr;
            t_high = th;
            t_low = tl;
        }
    }

    public class Cregbounds
    {
        float abound1, abound2;
        int dbound1, dbound2;

        RegistryKey regkey;
        string regpath = @"SOFTWARE\seikeifslab\AIOforMFC\bounds"; 

        public Cregbounds()
        {
            abound1 = 0.0F;
            abound2 = 5.0F;
            dbound1 = 32767;
            dbound2 = 49152;
        }

        public bool read_registry()
        {
            regkey = Registry.CurrentUser.OpenSubKey(regpath, false);

            if (regkey == null) {
                MessageBox.Show("校正データがありません", "読み込み失敗", MessageBoxButtons.OK);
                return false;
            }

            string abound1str = (string)regkey.GetValue("abound1");
            abound1 = Convert.ToSingle(abound1str);
            string abound2str = (string)regkey.GetValue("abound2");
            abound2 = Convert.ToSingle(abound2str);

            string dbound1str = (string)regkey.GetValue("dbound1");
            dbound1 = Convert.ToInt32(dbound1str);
            string dbound2str = (string)regkey.GetValue("dbound2");
            dbound2 = Convert.ToInt32(dbound2str);

            regkey.Close();
            return true;
        }

        public void write_registry()
        {
            regkey = Registry.CurrentUser.CreateSubKey(regpath, true);

            regkey.SetValue("abound1", abound1.ToString("F2"), RegistryValueKind.String);
            regkey.SetValue("abound2", abound2.ToString("F2"), RegistryValueKind.String);
            regkey.SetValue("dbound1", dbound1.ToString(), RegistryValueKind.String);
            regkey.SetValue("dbound2", dbound2.ToString(), RegistryValueKind.String);

            regkey.Close();
        }

        public (float ab1, float ab2, int db1, int db2) get_value()
        {
            return (abound1, abound2, dbound1, dbound2);
        }

        public void set_value(float ab1, float ab2, int db1, int db2)
        {
            abound1 = ab1;
            abound2 = ab2;
            dbound1 = db1;
            dbound2 = db2;
        }
    }

    public class Cmfc
    {
        Caio aio = new Caio();
        int Ref;
        short Id;
        readonly short aoch = 0;

        int dbound1 = 32767;
        int dbound2 = 49152;

        float abound1 = 0.0F;
        float abound2 = 5.0F;
        float daratio;

        public Cmfc(string dev_name)
        {
            Ref = aio.Init(dev_name, out Id);
            if(Ref != 0)
            {
                var form = new FormHWsetting();
                form.Show();
            }
            reset_daratio();
            this.flowset(0.0F);
        }

        public void flowset(float flow)
        {
            int d_out;
            d_out = (int)Math.Round(daratio * (flow - abound1)) + dbound1;
            aio.SingleAo(Id, aoch, d_out);
        }

        public void doutset(int d_out)
        {
            aio.SingleAo(Id, aoch, d_out);
        }

        private void reset_daratio()
        {
            daratio = (float)(dbound2 - dbound1) / (abound2 - abound1);
        }

        public (float ab1, float ab2, int db1, int db2) get_bounds()
        {
            return (abound1, abound2, dbound1, dbound2);
        }

        public void set_bounds(float ab1, float ab2, int db1, int db2) {
            abound1 = ab1;
            abound2 = ab2;
            dbound1 = db1;
            dbound2 = db2;

            reset_daratio();
        }
    }
}
