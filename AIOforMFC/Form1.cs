using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIOforMFC
{
    public partial class Form1 : Form
    {

        public Cmfc mfc;
        public Cregbounds regbounds = new Cregbounds();
        public Cregsettings regsettings = new Cregsettings();
        public Chwparams hwparams = new Chwparams();

        float q_out, q_max;
        float q_high, q_low;
        float q_rate, q_step;
        int t_high, t_low, t_count;
        string loop_status;

        public Form1()
        {
            InitializeComponent();
            q_low = 3.0F;
            q_high = 4.5F;
            q_rate = 0.10F;
            q_max = 5.0F; // MFC の最大値
            q_step = q_rate / 10;
            t_high = 20;
            t_low = 20;

            loop_status = "shut";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool ret;
            string dn, q_max_str;

            q_high = Convert.ToSingle(textBoxQH.Text);
            q_low = Convert.ToSingle(textBoxQL.Text);
            q_rate = Convert.ToSingle(textBoxQR.Text);

            t_high = Convert.ToInt16(textBoxTH.Text);
            t_low = Convert.ToInt16(textBoxTL.Text);

            hwparams.read_registry();
            (dn, q_max_str) = hwparams.get_value();

            mfc = new Cmfc(dn);
            q_max = Convert.ToSingle(q_max_str);

            ret = regbounds.read_registry();
            if (ret == false)
            {
                var form = new FormCalib(mfc, regbounds);
                form.Show();
            }
            (float ab1, float ab2, int db1, int db2) = regbounds.get_value();
            mfc.set_bounds(ab1, ab2, db1, db2);

            ret = regsettings.read_registry();
            if (ret)
            {
                (q_high, q_low, q_rate, t_high, t_low) = regsettings.get_value();

                textBoxQH.Text = q_high.ToString("F2");
                textBoxQL.Text = q_low.ToString("F2");
                textBoxQR.Text = q_rate.ToString("F2");

                textBoxTH.Text = t_high.ToString();
                textBoxTL.Text = t_low.ToString();
            }
            comboBoxSF.SelectedItem = "Q.high";
        }

        private void MFCcalibToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCalib(mfc, regbounds);
            form.Show();
        }

        private void HWconfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormHWsetting();
            form.Show();
        }

        private void SaveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rep = MessageBox.Show("現在の設定を保存しますか？", "設定の保存", MessageBoxButtons.OKCancel);
            if(rep == DialogResult.OK)
            {
                regsettings.set_value(q_high, q_low, q_rate, t_high, t_low);
                regsettings.write_registry();
            }
        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_FormClosing(object sender, EventArgs e)
        {
            mfc.flowset(0.0F);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            labelFlow.ForeColor = Color.Red;
            if (comboBoxSF.SelectedIndex == 0)
            {
                q_out = q_high;
                labelHigh.ForeColor = Color.Pink;
            }
            else
            {
                q_out = q_low;
                labelLow.ForeColor = Color.Pink;
            }
            mfc.flowset(q_out);
            comboBoxSF.Enabled = false;

            buttonStart.Enabled = false;
            buttonUpDown.Enabled = true;
            buttonShut.Enabled = true;

            loop_status = "stop";
        }

        private void ButtonUpDown_Click(object sender, EventArgs e)
        {
            buttonUpDown.Enabled = false;
            buttonPause.Enabled = true;
            buttonPause.Text = "Pause";
            textBoxQR.ReadOnly = true;

            if (comboBoxSF.SelectedIndex == 0)
            {
                loop_status = "high";
                labelHigh.ForeColor = Color.Red;
                highTimer.Enabled = true;
            }
            else
            {
                loop_status = "low";
                labelLow.ForeColor = Color.Red;
                lowTimer.Enabled = true;
            }
            t_count = 0;
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            if(buttonPause.Text == "Pause")
            {
                buttonPause.Text = "Resume";
                textBoxQR.ReadOnly = false;

                switch (loop_status)
                {
                    case "low":
                        lowTimer.Enabled = false;
                        labelLow.ForeColor = Color.Pink;
                        break;
                    case "inc":
                        incTimer.Enabled = false;
                        labelInc.ForeColor = Color.Pink;
                        break;
                    case "high":
                        highTimer.Enabled = false;
                        labelHigh.ForeColor = Color.Pink;
                        break;
                    case "dec":
                        decTimer.Enabled = false;
                        labelDec.ForeColor = Color.Pink;
                        break;
                }
            }
            else
            {
                buttonPause.Text = "Pause";
                textBoxQR.ReadOnly = true;

                switch (loop_status)
                {
                    case "low":
                        lowTimer.Enabled = true;
                        labelLow.ForeColor = Color.Red;
                        break;
                    case "inc":
                        incTimer.Enabled = true;
                        labelInc.ForeColor = Color.Red;
                        break;
                    case "high":
                        highTimer.Enabled = true;
                        labelHigh.ForeColor = Color.Red;
                        break;
                    case "dec":
                        decTimer.Enabled = true;
                        labelDec.ForeColor = Color.Red;
                        break;
                }
            }
        }

        private void ButtonShut_Click(object sender, EventArgs e)
        {
            mfc.flowset(0.0F);
            loop_status = "stop";

            incTimer.Enabled = false;
            highTimer.Enabled = false;
            decTimer.Enabled = false;
            lowTimer.Enabled = false;

            labelFlow.ForeColor = Color.Blue;
            labelInc.ForeColor = Color.Blue;
            labelHigh.ForeColor = Color.Blue;
            labelDec.ForeColor = Color.Blue;
            labelLow.ForeColor = Color.Blue;

            buttonShut.Enabled = false;

            buttonStart.Enabled = true;
            buttonUpDown.Enabled = false;
            buttonPause.Enabled = false;

            buttonPause.Text = "Pause";
            textBoxQR.ReadOnly = false;
            comboBoxSF.Enabled = true;
            t_count = 0;
        }

        private bool isTextBoxQHChanged = false;
        private void ChangeQH()
        {
            float q_mod;
            try
            {
                q_mod = Convert.ToSingle(textBoxQH.Text);
            }
            catch (FormatException ex)
            {
                q_mod = q_high;
            }
            if (q_mod > q_low && q_mod <= q_max)
            {
                q_high = q_mod;
            }
            textBoxQH.Text = q_high.ToString("F2");

            if (loop_status == "high")
            {
                q_out = q_high;
                mfc.flowset(q_out);
            }
            isTextBoxQHChanged = false;
        }
        private void TextBoxQH_TextChanged(object sender, EventArgs e)
        {
            isTextBoxQHChanged = true;
        }
        private void TextBoxQH_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && isTextBoxQHChanged)
            {
                ChangeQH();
            }
        }
        private void TextBoxQH_Leave(object sender, EventArgs e)
        {
            if (isTextBoxQHChanged)
            {
                ChangeQH();
            }
        }
   
        private bool isTextBoxQLChanged = false;
        private void ChangeQL()
        {
            float q_mod;
            try
            {
                q_mod = Convert.ToSingle(textBoxQL.Text);
            }
            catch (FormatException ex)
            {
                q_mod = q_low;
            }
            if (q_mod < q_high && q_mod >= 0.0F)
            {
                q_low = q_mod;
            }
            textBoxQL.Text = q_low.ToString("F2");

            if(loop_status == "low" || loop_status == "stop")
            {
                q_out = q_low;
                mfc.flowset(q_out);
            }
            isTextBoxQLChanged = false;
        }
        private void TextBoxQL_TextChanged(object sender, EventArgs e)
        {
            isTextBoxQLChanged = true;
        }
        private void TextBoxQL_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && isTextBoxQLChanged)
            {
                ChangeQL();
            }
        }
        private void TextBoxQL_Leave(object sender, EventArgs e)
        {
            if (isTextBoxQLChanged)
            {
                ChangeQL();
            }
        }

        private bool isTextBoxQRChanged = false;
        private void ChangeQR()
        {
            float qr_mod;
            try
            {
                qr_mod = Convert.ToSingle(textBoxQR.Text);
            }
            catch (FormatException ex)
            {
                qr_mod = q_rate;
            }
            if(qr_mod >= 0.01F && qr_mod <= 1.00F)
            {
                q_rate = qr_mod;
                q_step = q_rate / 10;
            }
            textBoxQR.Text = q_rate.ToString("F2");
            isTextBoxQRChanged = false;
        }
        private void TextBoxQR_TextChanged(object sender, EventArgs e)
        {
            isTextBoxQRChanged = true;
        }
        private void TextBoxQR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isTextBoxQRChanged)
            {
                ChangeQR();
            }
        }
        private void TextBoxQR_Leave(object sender, EventArgs e)
        {
            if (isTextBoxQRChanged)
            {
                ChangeQR();
            }
        }

        private bool isTextBoxTHChanged = false;
        private void ChangeTH() {
            int t_mod;
            try
            {
                t_mod = Convert.ToInt16(textBoxTH.Text);
            }
            catch(FormatException ex)
            {
                t_mod = t_high;
            }
            t_high = t_mod;
            textBoxTH.Text = t_high.ToString();
            isTextBoxTHChanged = false;
        }
        private void TextBoxTH_TextChanged(object sender, EventArgs e)
        {
            isTextBoxTHChanged = true;
        }
        private void TextBoxTH_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && !isTextBoxTHChanged)
            {
                ChangeTH();
            }
        }
        private void TextBoxTH_Leave(object sender, EventArgs e)
        {
            if (isTextBoxTHChanged)
            {
                ChangeTH();
            }
        }

        private bool isTextBoxTLChanged = false;
        private void ChangeTL()
        {
            int t_mod;
            try
            {
                t_mod = Convert.ToInt16(textBoxTL.Text);
            }
            catch (FormatException ex)
            {
                t_mod = t_low;
            }
            t_low = t_mod;
            textBoxTL.Text = t_low.ToString();
            isTextBoxTLChanged = false;
        }
        private void TextBoxTL_TextChanged(object sender, EventArgs e)
        {
            isTextBoxTLChanged = true;
        }
        private void TextBoxTL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !isTextBoxTLChanged)
            {
                ChangeTL();
            }
        }
        private void TextBoxTL_Leave(object sender, EventArgs e)
        {
            if (isTextBoxTLChanged)
            {
                ChangeTL();
            }
        }

        private void ButtonQHinc_Click(object sender, EventArgs e)
        {
            float q_mod = q_high;
            q_mod += 0.01F;
            if(q_mod <= q_max)
            {
                q_high = q_mod;
            }
            textBoxQH.Text = q_high.ToString("F2");

            if (loop_status != "high") { return; }
            
            q_out = q_high;
            mfc.flowset(q_out);
        }

        private void ButtonQHdec_Click(object sender, EventArgs e)
        {
            float q_mod = q_high;
            q_mod -= 0.01F;
            if (q_mod > q_low)
            {
                q_high = q_mod;
            }
            textBoxQH.Text = q_high.ToString("F2");

            if (loop_status != "high") { return; }
 
            q_out = q_high;
            mfc.flowset(q_out);            
        }

        private void ButtonQLinc_Click(object sender, EventArgs e)
        {
            float q_mod = q_low;
            q_mod += 0.01F;
            if(q_mod < q_high)
            {
                q_low = q_mod;
            }
            textBoxQL.Text = q_low.ToString("F2");

            if (loop_status != "low" && loop_status != "stop") { return; }
            
            q_out = q_low;
            mfc.flowset(q_out);
        }

        private void ButtonQLdec_Click(object sender, EventArgs e)
        {
            float q_mod = q_low;
            q_mod -= 0.01F;
            if(q_mod >= 0.00F)
            {
                q_low = q_mod;
            }
            textBoxQL.Text = q_low.ToString("F2");
            
            if (loop_status != "low" && loop_status != "stop") { return; }
             
            q_out = q_low;
            mfc.flowset(q_out);
        }

        private void IncTimer_Tick(object sender, EventArgs e)
        {
            q_out += q_step;
            if (q_out < q_high)
            {
                mfc.flowset(q_out);
            }
            else
            {
                q_out = q_high;
                mfc.flowset(q_out);
                incTimer.Enabled = false;
                t_count = 0;
                highTimer.Enabled = true;

                labelInc.ForeColor = Color.Blue;
                labelHigh.ForeColor = Color.Red;
                loop_status = "high";
            }
        }

        private void HighTimer_Tick(object sender, EventArgs e)
        {
            t_count += 1;
            if (t_count > t_high)
            {
                highTimer.Enabled = false;
                decTimer.Enabled = true;

                labelHigh.ForeColor = Color.Blue;
                labelDec.ForeColor = Color.Red;
                loop_status = "dec";                
            }
        }

        private void DecTimer_Tick(object sender, EventArgs e)
        {
            q_out -= q_step;
            if (q_out > q_low)
            {
                mfc.flowset(q_out);
            }
            else
            {
                q_out = q_low;
                mfc.flowset(q_out);
                decTimer.Enabled = false;
                t_count = 0;
                lowTimer.Enabled = true;

                labelDec.ForeColor = Color.Blue;
                labelLow.ForeColor = Color.Red;
                loop_status = "low";
            }
        }

        private void LowTimer_Tick(object sender, EventArgs e)
        {
            t_count += 1;
            if (t_count > t_low)
            {
                lowTimer.Enabled = false;
                incTimer.Enabled = true;

                labelLow.ForeColor= Color.Blue;
                labelInc.ForeColor = Color.Red;
                loop_status = "inc";
            }
        }
    }
}
