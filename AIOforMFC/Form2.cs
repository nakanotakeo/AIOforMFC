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
    public partial class FormCalib : Form
    {
        private Cmfc mfc;
        private Cregbounds regbounds;

        public FormCalib(Cmfc mfcref, Cregbounds regboundsref)
        {
            InitializeComponent();
            this.mfc = mfcref;
            this.regbounds = regboundsref;
        }
        float abound1, abound2;
        readonly float alimitLow = 0.0F;
        readonly float alimitHigh = 21.0F;
        int dbound1, dbound2;
        readonly int dlimitLow = 32000;
        readonly int dlimitHigh = 50000;

        private void FormCalib_Load(object sender, EventArgs e)
        {
            (abound1, abound2, dbound1, dbound2) = regbounds.get_value();

            textBoxAbound1.Text = abound1.ToString("F2");
            textBoxAbound2.Text = abound2.ToString("F2");
            textBoxDbound1.Text = dbound1.ToString();
            textBoxDbound2.Text = dbound2.ToString();
        }

        private void checkBoxBound1stat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBound1stat.Checked == true)
            {
                checkBoxBound1stat.Text = "On";
                checkBoxBound1stat.ForeColor = Color.Red;
                checkBoxBound2stat.Checked = false;
                mfc.doutset(dbound1);
            }
            else
            {
                checkBoxBound1stat.Text = "Off";
                checkBoxBound1stat.ForeColor = Color.Blue;
                mfc.flowset(0.0F);
            }
        }

        private void checkBoxBound2stat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBound2stat.Checked == true)
            {
                checkBoxBound2stat.Text = "On";
                checkBoxBound2stat.ForeColor = Color.Red;
                checkBoxBound1stat.Checked = false;
                mfc.doutset(dbound2);
            }
            else
            {
                checkBoxBound2stat.Text = "Off";
                checkBoxBound2stat.ForeColor = Color.Blue;
                mfc.flowset(0.0F);
            }
        }

        bool isTextBoxAbound1Changed = false;
        private void ChangeAbound1()
        {
            float amod;
            try
            {
                amod = Convert.ToSingle(textBoxAbound1.Text);
            }
            catch (FormatException ex)
            {
                amod = abound1;
            }
            if (amod < abound2 && amod >= alimitLow)
            {
                abound1 = amod;
            }
            textBoxAbound1.Text = abound1.ToString("F2");
            isTextBoxAbound1Changed = false;
        }
        private void TextBoxAbound1_TextChanged(object sender, EventArgs e)
        {
            isTextBoxAbound1Changed = true;
        }
        private void TextBoxAbound1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && isTextBoxAbound1Changed)
            {
                ChangeAbound1();
            }
        }
        private void TextBoxAbound1_Leave(object sender, EventArgs e)
        {
            if (isTextBoxAbound1Changed)
            {
                ChangeAbound1();
            }
        }

        bool isTextBoxAbound2Changed = false;
        private void ChangeAbound2()
        {
            float amod;
            try
            {
                amod = Convert.ToSingle(textBoxAbound2.Text);
            }
            catch (FormatException ex)
            {
                amod = abound2;
            }
            if (amod > abound1 && amod <= alimitHigh)
            {
                abound2 = amod;
            }
            textBoxAbound2.Text = abound2.ToString("F2");
            isTextBoxAbound2Changed = false;
        }
        private void TextBoxAbound2_TextChanged(object sender, EventArgs e)
        {
            isTextBoxAbound2Changed = true;
        }
        private void TextBoxAbound2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isTextBoxAbound2Changed)
            {
                ChangeAbound2();
            }
        }
        private void TextBoxAbound2_Leave(object sender, EventArgs e)
        {
            if (isTextBoxAbound2Changed)
            {
                ChangeAbound2();
            }
        }

        bool isTextBoxDbound1Changed = false;
        private void ChangeDbound1()
        {
            int dmod;
            try
            {
                dmod = Convert.ToInt32(textBoxDbound1.Text);
            }
            catch (FormatException ex)
            {
                dmod = dbound1;
            }
            if (dmod < dbound2 && dmod >= dlimitLow)
            {
                dbound1 = dmod;
            }
            textBoxDbound1.Text = dbound1.ToString();

            if (checkBoxBound1stat.Checked == true) {
                mfc.doutset(dbound1); 
            }
            isTextBoxDbound1Changed = false;
        }
        private void TextBoxDBound1_TextChanged(object sender, EventArgs e)
        {
            isTextBoxDbound1Changed = true;
        }
        private void TextBoxDBound1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isTextBoxDbound1Changed)
            {
                ChangeDbound1();
            }
        }
        private void TextBoxDbound1_Leave(object sender, EventArgs e)
        {
            if (isTextBoxDbound1Changed)
            {
                ChangeDbound1();
            }
        }

        bool isTextBoxDbound2Changed = false;
        private void ChangeDbound2()
        {
            int dmod;
            try
            {
                dmod = Convert.ToInt32(textBoxDbound2.Text);
            }
            catch (FormatException ex)
            {
                dmod = dbound2;
            }
            if (dmod > dbound1 && dmod <= dlimitHigh)
            {
                dbound2 = dmod;
            }
            textBoxDbound2.Text = dbound2.ToString();

            if (checkBoxBound2stat.Checked == true)
            {
                mfc.doutset(dbound2);
            }
            isTextBoxDbound2Changed = false;
        }
        private void TextBoxDBound2_TextChanged(object sender, EventArgs e)
        {
            isTextBoxDbound2Changed = true;
        }
        private void TextBoxDBound2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && isTextBoxDbound2Changed)
            {
                ChangeDbound2();
            }
        }
        private void TextBoxDbound2_Leave(object sender, EventArgs e)
        {
            if (isTextBoxDbound2Changed)
            {
                ChangeDbound2();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            regbounds.set_value(abound1, abound2, dbound1, dbound2);
            regbounds.write_registry();
            mfc.set_bounds(abound1, abound2, dbound1, dbound2);

            mfc.flowset(0.0F);

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult rep = MessageBox.Show("値を変更せずに戻りますか？", "校正中止", MessageBoxButtons.YesNo);
            if (rep == DialogResult.Yes) {
                this.Close();
                mfc.flowset(0.0F);
            }
        }

    }
}
