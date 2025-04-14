namespace CSharp
{
    partial class Form2
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
            this.checkBox1 = new ReaLTaiizor.Controls.CheckBox();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.textBoxEdit2 = new ReaLTaiizor.Controls.TextBoxEdit();
            this.textBoxEdit1 = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.Register = new ReaLTaiizor.Controls.Button();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.Login = new ReaLTaiizor.Controls.Button();
            this.foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            this.foreverMinimize1 = new ReaLTaiizor.Controls.ForeverMinimize();
            this.textBoxEdit3 = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit5 = new ReaLTaiizor.Controls.LabelEdit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = false;
            this.checkBox1.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.checkBox1.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.checkBox1.CheckedDisabledColor = System.Drawing.Color.Gray;
            this.checkBox1.CheckedEnabledColor = System.Drawing.Color.White;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Enable = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(755, 479);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 16);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.CheckedChanged += new ReaLTaiizor.Controls.CheckBox.CheckedChangedEventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelEdit3.ForeColor = System.Drawing.Color.Black;
            this.labelEdit3.Location = new System.Drawing.Point(419, -77);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(289, 36);
            this.labelEdit3.TabIndex = 21;
            this.labelEdit3.Text = "Gestion Achat Vente";
            // 
            // textBoxEdit2
            // 
            this.textBoxEdit2.BackColor = System.Drawing.Color.Transparent;
            this.textBoxEdit2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBoxEdit2.ForeColor = System.Drawing.Color.White;
            this.textBoxEdit2.Image = null;
            this.textBoxEdit2.Location = new System.Drawing.Point(755, 244);
            this.textBoxEdit2.MaxLength = 32767;
            this.textBoxEdit2.Multiline = false;
            this.textBoxEdit2.Name = "textBoxEdit2";
            this.textBoxEdit2.ReadOnly = false;
            this.textBoxEdit2.Size = new System.Drawing.Size(236, 46);
            this.textBoxEdit2.TabIndex = 20;
            this.textBoxEdit2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxEdit2.UseSystemPasswordChar = false;
            // 
            // textBoxEdit1
            // 
            this.textBoxEdit1.BackColor = System.Drawing.Color.Transparent;
            this.textBoxEdit1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBoxEdit1.ForeColor = System.Drawing.Color.White;
            this.textBoxEdit1.Image = null;
            this.textBoxEdit1.Location = new System.Drawing.Point(755, 130);
            this.textBoxEdit1.MaxLength = 32767;
            this.textBoxEdit1.Multiline = false;
            this.textBoxEdit1.Name = "textBoxEdit1";
            this.textBoxEdit1.ReadOnly = false;
            this.textBoxEdit1.Size = new System.Drawing.Size(236, 46);
            this.textBoxEdit1.TabIndex = 19;
            this.textBoxEdit1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxEdit1.UseSystemPasswordChar = false;
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelEdit2.ForeColor = System.Drawing.Color.Black;
            this.labelEdit2.Location = new System.Drawing.Point(333, 376);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(108, 26);
            this.labelEdit2.TabIndex = 18;
            this.labelEdit2.Text = "Password";
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelEdit1.ForeColor = System.Drawing.Color.Black;
            this.labelEdit1.Location = new System.Drawing.Point(333, 150);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(113, 26);
            this.labelEdit1.TabIndex = 17;
            this.labelEdit1.Text = "Username";
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.EnteredBorderColor = System.Drawing.Color.White;
            this.Register.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Register.Image = null;
            this.Register.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Register.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Register.Location = new System.Drawing.Point(314, 577);
            this.Register.Name = "Register";
            this.Register.PressedBorderColor = System.Drawing.Color.Black;
            this.Register.PressedColor = System.Drawing.Color.Black;
            this.Register.Size = new System.Drawing.Size(132, 50);
            this.Register.TabIndex = 16;
            this.Register.Text = "Register";
            this.Register.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(-33, -99);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(243, 780);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 15;
            this.panel1.Text = "panel1";
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.EnteredBorderColor = System.Drawing.Color.White;
            this.Login.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Login.Image = null;
            this.Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Login.Location = new System.Drawing.Point(755, 577);
            this.Login.Name = "Login";
            this.Login.PressedBorderColor = System.Drawing.Color.Black;
            this.Login.PressedColor = System.Drawing.Color.Black;
            this.Login.Size = new System.Drawing.Size(132, 50);
            this.Login.TabIndex = 14;
            this.Login.Text = "Login";
            this.Login.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // foreverClose1
            // 
            this.foreverClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foreverClose1.BackColor = System.Drawing.Color.White;
            this.foreverClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverClose1.DefaultLocation = true;
            this.foreverClose1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foreverClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.foreverClose1.Location = new System.Drawing.Point(1048, 16);
            this.foreverClose1.Name = "foreverClose1";
            this.foreverClose1.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foreverClose1.Size = new System.Drawing.Size(18, 18);
            this.foreverClose1.TabIndex = 13;
            this.foreverClose1.Text = "foreverClose1";
            this.foreverClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverClose1.Click += new System.EventHandler(this.foreverClose1_Click);
            // 
            // foreverMinimize1
            // 
            this.foreverMinimize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foreverMinimize1.BackColor = System.Drawing.Color.White;
            this.foreverMinimize1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverMinimize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverMinimize1.DefaultLocation = true;
            this.foreverMinimize1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foreverMinimize1.Font = new System.Drawing.Font("Marlett", 12F);
            this.foreverMinimize1.Location = new System.Drawing.Point(1000, 16);
            this.foreverMinimize1.Name = "foreverMinimize1";
            this.foreverMinimize1.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foreverMinimize1.Size = new System.Drawing.Size(18, 18);
            this.foreverMinimize1.TabIndex = 12;
            this.foreverMinimize1.Text = "foreverMinimize1";
            this.foreverMinimize1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // textBoxEdit3
            // 
            this.textBoxEdit3.BackColor = System.Drawing.Color.Transparent;
            this.textBoxEdit3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBoxEdit3.ForeColor = System.Drawing.Color.White;
            this.textBoxEdit3.Image = null;
            this.textBoxEdit3.Location = new System.Drawing.Point(755, 356);
            this.textBoxEdit3.MaxLength = 32767;
            this.textBoxEdit3.Multiline = false;
            this.textBoxEdit3.Name = "textBoxEdit3";
            this.textBoxEdit3.ReadOnly = false;
            this.textBoxEdit3.Size = new System.Drawing.Size(236, 46);
            this.textBoxEdit3.TabIndex = 24;
            this.textBoxEdit3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxEdit3.UseSystemPasswordChar = false;
            // 
            // labelEdit4
            // 
            this.labelEdit4.AutoSize = true;
            this.labelEdit4.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelEdit4.ForeColor = System.Drawing.Color.Black;
            this.labelEdit4.Location = new System.Drawing.Point(333, 264);
            this.labelEdit4.Name = "labelEdit4";
            this.labelEdit4.Size = new System.Drawing.Size(68, 26);
            this.labelEdit4.TabIndex = 23;
            this.labelEdit4.Text = "Email";
            // 
            // labelEdit5
            // 
            this.labelEdit5.AutoSize = true;
            this.labelEdit5.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelEdit5.ForeColor = System.Drawing.Color.Black;
            this.labelEdit5.Location = new System.Drawing.Point(470, 37);
            this.labelEdit5.Name = "labelEdit5";
            this.labelEdit5.Size = new System.Drawing.Size(289, 36);
            this.labelEdit5.TabIndex = 25;
            this.labelEdit5.Text = "Gestion Achat Vente";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 679);
            this.Controls.Add(this.labelEdit5);
            this.Controls.Add(this.textBoxEdit3);
            this.Controls.Add(this.labelEdit4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelEdit3);
            this.Controls.Add(this.textBoxEdit2);
            this.Controls.Add(this.textBoxEdit1);
            this.Controls.Add(this.labelEdit2);
            this.Controls.Add(this.labelEdit1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.foreverClose1);
            this.Controls.Add(this.foreverMinimize1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CheckBox checkBox1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.TextBoxEdit textBoxEdit2;
        private ReaLTaiizor.Controls.TextBoxEdit textBoxEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.Button Register;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.Button Login;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.ForeverMinimize foreverMinimize1;
        private ReaLTaiizor.Controls.TextBoxEdit textBoxEdit3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private ReaLTaiizor.Controls.LabelEdit labelEdit5;
    }
}