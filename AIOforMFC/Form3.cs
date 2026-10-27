using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AIOforMFC
{
    public partial class FormHWsetting : Form
    {
        Chwparams hwparams = new Chwparams();
        string dev_name, q_max_str;
        float q_max;

        bool isHWparamsModified = false;

        public FormHWsetting()
        {
            InitializeComponent();
            dev_name = "AIO000";
            q_max_str = "5.00";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bool ret = hwparams.read_registry();
            if (ret)
            {
                (dev_name, q_max_str) = hwparams.get_value();
            }
            textBoxDevName.Text = dev_name;
            textBoxQmax.Text = q_max_str;
            q_max = Convert.ToSingle(textBoxQmax.Text);
        }

        private void TextBoxDevName_TextChanged(object sender, EventArgs e)
        {
            isHWparamsModified = true;
            dev_name = textBoxDevName.Text;
        }

        private bool isTextBoxQmaxChanged = false;
        private void ChangeQmax()
        {
            float q_mod;

            isHWparamsModified = true;
            try
            {
                q_mod = Convert.ToSingle(textBoxQmax.Text);
            }
            catch(FormatException ex)
            {
                q_mod = q_max;
                isHWparamsModified = false;
            }
            textBoxQmax.Text = q_mod.ToString("F2");
            q_max_str = textBoxQmax.Text;
            isTextBoxQmaxChanged = false;
        }
        private void TextBoxQmax_TextChanged(object sender, EventArgs e)
        {
            isTextBoxQmaxChanged = true;
        }
        private void TextBoxQmax_Leave(object sender, EventArgs e)
        {
            if (isTextBoxQmaxChanged)
            {
                ChangeQmax();
            }
        }
        private void TextBoxQmax_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && isTextBoxQmaxChanged)
            {
                ChangeQmax();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isHWparamsModified)
            {
                DialogResult rep = MessageBox.Show("変更を保存しますか", "変更確認", MessageBoxButtons.OKCancel);
                if (rep == DialogResult.OK) {
                    hwparams.set_value(dev_name, q_max_str);
                    hwparams.write_registry();
                    MessageBox.Show("いちどプログラムを再起動してください");
                }
            }
            this.Close();
        }
    }
}
