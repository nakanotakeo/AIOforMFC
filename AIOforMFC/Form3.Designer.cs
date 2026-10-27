namespace AIOforMFC
{
    partial class FormHWsetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDevName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQmax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "AIO-160802AY-USB Device Name";
            // 
            // textBoxDevName
            // 
            this.textBoxDevName.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.textBoxDevName.Location = new System.Drawing.Point(25, 59);
            this.textBoxDevName.Name = "textBoxDevName";
            this.textBoxDevName.Size = new System.Drawing.Size(138, 39);
            this.textBoxDevName.TabIndex = 1;
            this.textBoxDevName.Text = "AIO000";
            this.textBoxDevName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDevName.TextChanged += new System.EventHandler(this.TextBoxDevName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum flow rate of MFC";
            // 
            // textBoxQmax
            // 
            this.textBoxQmax.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.textBoxQmax.Location = new System.Drawing.Point(25, 183);
            this.textBoxQmax.Name = "textBoxQmax";
            this.textBoxQmax.Size = new System.Drawing.Size(138, 39);
            this.textBoxQmax.TabIndex = 3;
            this.textBoxQmax.Text = "5.00";
            this.textBoxQmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxQmax.TextChanged += new System.EventHandler(this.TextBoxQmax_TextChanged);
            this.textBoxQmax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxQmax_KeyDown);
            this.textBoxQmax.Leave += new System.EventHandler(this.TextBoxQmax_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(179, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "sccm";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.button1.Location = new System.Drawing.Point(175, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHWsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQmax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDevName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHWsetting";
            this.Text = "Hardware Configuration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDevName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQmax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}