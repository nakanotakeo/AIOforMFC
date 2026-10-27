namespace AIOforMFC
{
    partial class FormCalib
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBound1 = new System.Windows.Forms.Label();
            this.textBoxAbound1 = new System.Windows.Forms.TextBox();
            this.labelBound2 = new System.Windows.Forms.Label();
            this.textBoxAbound2 = new System.Windows.Forms.TextBox();
            this.labelSCCM1 = new System.Windows.Forms.Label();
            this.labelSCCM2 = new System.Windows.Forms.Label();
            this.textBoxDbound1 = new System.Windows.Forms.TextBox();
            this.labelDval1 = new System.Windows.Forms.Label();
            this.labelDval2 = new System.Windows.Forms.Label();
            this.textBoxDbound2 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxBound1stat = new System.Windows.Forms.CheckBox();
            this.checkBoxBound2stat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelBound1
            // 
            this.labelBound1.AutoSize = true;
            this.labelBound1.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.labelBound1.Location = new System.Drawing.Point(20, 20);
            this.labelBound1.Name = "labelBound1";
            this.labelBound1.Size = new System.Drawing.Size(115, 33);
            this.labelBound1.TabIndex = 0;
            this.labelBound1.Text = "Bound1";
            // 
            // textBoxAbound1
            // 
            this.textBoxAbound1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxAbound1.Location = new System.Drawing.Point(26, 70);
            this.textBoxAbound1.Name = "textBoxAbound1";
            this.textBoxAbound1.Size = new System.Drawing.Size(80, 39);
            this.textBoxAbound1.TabIndex = 4;
            this.textBoxAbound1.Text = "0.00";
            this.textBoxAbound1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAbound1.TextChanged += new System.EventHandler(this.TextBoxAbound1_TextChanged);
            this.textBoxAbound1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAbound1_KeyDown);
            this.textBoxAbound1.Leave += new System.EventHandler(this.TextBoxAbound1_Leave);
            // 
            // labelBound2
            // 
            this.labelBound2.AutoSize = true;
            this.labelBound2.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.labelBound2.Location = new System.Drawing.Point(20, 150);
            this.labelBound2.Name = "labelBound2";
            this.labelBound2.Size = new System.Drawing.Size(115, 33);
            this.labelBound2.TabIndex = 5;
            this.labelBound2.Text = "Bound2";
            // 
            // textBoxAbound2
            // 
            this.textBoxAbound2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxAbound2.Location = new System.Drawing.Point(26, 200);
            this.textBoxAbound2.Name = "textBoxAbound2";
            this.textBoxAbound2.Size = new System.Drawing.Size(80, 39);
            this.textBoxAbound2.TabIndex = 6;
            this.textBoxAbound2.Text = "5.00";
            this.textBoxAbound2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAbound2.TextChanged += new System.EventHandler(this.TextBoxAbound2_TextChanged);
            this.textBoxAbound2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAbound2_KeyDown);
            this.textBoxAbound2.Leave += new System.EventHandler(this.TextBoxAbound2_Leave);
            // 
            // labelSCCM1
            // 
            this.labelSCCM1.AutoSize = true;
            this.labelSCCM1.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.labelSCCM1.Location = new System.Drawing.Point(110, 73);
            this.labelSCCM1.Name = "labelSCCM1";
            this.labelSCCM1.Size = new System.Drawing.Size(86, 33);
            this.labelSCCM1.TabIndex = 7;
            this.labelSCCM1.Text = "sccm";
            // 
            // labelSCCM2
            // 
            this.labelSCCM2.AutoSize = true;
            this.labelSCCM2.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.labelSCCM2.Location = new System.Drawing.Point(110, 203);
            this.labelSCCM2.Name = "labelSCCM2";
            this.labelSCCM2.Size = new System.Drawing.Size(86, 33);
            this.labelSCCM2.TabIndex = 8;
            this.labelSCCM2.Text = "sccm";
            // 
            // textBoxDbound1
            // 
            this.textBoxDbound1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDbound1.Location = new System.Drawing.Point(300, 70);
            this.textBoxDbound1.Name = "textBoxDbound1";
            this.textBoxDbound1.Size = new System.Drawing.Size(152, 39);
            this.textBoxDbound1.TabIndex = 9;
            this.textBoxDbound1.Text = "32767";
            this.textBoxDbound1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDbound1.TextChanged += new System.EventHandler(this.TextBoxDBound1_TextChanged);
            this.textBoxDbound1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxDBound1_KeyDown);
            this.textBoxDbound1.Leave += new System.EventHandler(this.TextBoxDbound1_Leave);
            // 
            // labelDval1
            // 
            this.labelDval1.AutoSize = true;
            this.labelDval1.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.labelDval1.Location = new System.Drawing.Point(220, 73);
            this.labelDval1.Name = "labelDval1";
            this.labelDval1.Size = new System.Drawing.Size(68, 33);
            this.labelDval1.TabIndex = 10;
            this.labelDval1.Text = "dval";
            // 
            // labelDval2
            // 
            this.labelDval2.AutoSize = true;
            this.labelDval2.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.labelDval2.Location = new System.Drawing.Point(220, 203);
            this.labelDval2.Name = "labelDval2";
            this.labelDval2.Size = new System.Drawing.Size(68, 33);
            this.labelDval2.TabIndex = 11;
            this.labelDval2.Text = "dval";
            // 
            // textBoxDbound2
            // 
            this.textBoxDbound2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDbound2.Location = new System.Drawing.Point(300, 200);
            this.textBoxDbound2.Name = "textBoxDbound2";
            this.textBoxDbound2.Size = new System.Drawing.Size(152, 39);
            this.textBoxDbound2.TabIndex = 12;
            this.textBoxDbound2.Text = "49152";
            this.textBoxDbound2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDbound2.TextChanged += new System.EventHandler(this.TextBoxDBound2_TextChanged);
            this.textBoxDbound2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxDBound2_KeyDown);
            this.textBoxDbound2.Leave += new System.EventHandler(this.TextBoxDbound2_Leave);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.buttonSave.Location = new System.Drawing.Point(96, 301);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 39);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.buttonCancel.Location = new System.Drawing.Point(276, 301);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 39);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxBound1stat
            // 
            this.checkBoxBound1stat.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxBound1stat.AutoSize = true;
            this.checkBoxBound1stat.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.checkBoxBound1stat.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxBound1stat.Location = new System.Drawing.Point(132, 22);
            this.checkBoxBound1stat.Name = "checkBoxBound1stat";
            this.checkBoxBound1stat.Size = new System.Drawing.Size(51, 34);
            this.checkBoxBound1stat.TabIndex = 15;
            this.checkBoxBound1stat.Text = "Off";
            this.checkBoxBound1stat.UseVisualStyleBackColor = true;
            this.checkBoxBound1stat.CheckedChanged += new System.EventHandler(this.checkBoxBound1stat_CheckedChanged);
            // 
            // checkBoxBound2stat
            // 
            this.checkBoxBound2stat.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxBound2stat.AutoSize = true;
            this.checkBoxBound2stat.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.checkBoxBound2stat.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxBound2stat.Location = new System.Drawing.Point(132, 152);
            this.checkBoxBound2stat.Name = "checkBoxBound2stat";
            this.checkBoxBound2stat.Size = new System.Drawing.Size(51, 34);
            this.checkBoxBound2stat.TabIndex = 16;
            this.checkBoxBound2stat.Text = "Off";
            this.checkBoxBound2stat.UseVisualStyleBackColor = true;
            this.checkBoxBound2stat.CheckedChanged += new System.EventHandler(this.checkBoxBound2stat_CheckedChanged);
            // 
            // FormCalib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 389);
            this.Controls.Add(this.checkBoxBound2stat);
            this.Controls.Add(this.checkBoxBound1stat);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDbound2);
            this.Controls.Add(this.labelDval2);
            this.Controls.Add(this.labelDval1);
            this.Controls.Add(this.textBoxDbound1);
            this.Controls.Add(this.labelSCCM2);
            this.Controls.Add(this.labelSCCM1);
            this.Controls.Add(this.textBoxAbound2);
            this.Controls.Add(this.labelBound2);
            this.Controls.Add(this.textBoxAbound1);
            this.Controls.Add(this.labelBound1);
            this.Name = "FormCalib";
            this.Text = "AIO Calibration";
            this.Load += new System.EventHandler(this.FormCalib_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBound1;
        private System.Windows.Forms.TextBox textBoxAbound1;
        private System.Windows.Forms.Label labelBound2;
        private System.Windows.Forms.TextBox textBoxAbound2;
        private System.Windows.Forms.Label labelSCCM1;
        private System.Windows.Forms.Label labelSCCM2;
        private System.Windows.Forms.TextBox textBoxDbound1;
        private System.Windows.Forms.Label labelDval1;
        private System.Windows.Forms.Label labelDval2;
        private System.Windows.Forms.TextBox textBoxDbound2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxBound1stat;
        private System.Windows.Forms.CheckBox checkBoxBound2stat;
    }
}