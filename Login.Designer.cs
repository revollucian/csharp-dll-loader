namespace Zer0
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.flowTheme1 = new CS_ClassLibraryTester.FlowTheme();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordtext = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.usernametext = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.process1 = new System.Diagnostics.Process();
            this.flowTheme1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowTheme1
            // 
            this.flowTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flowTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.flowTheme1.Controls.Add(this.label3);
            this.flowTheme1.Controls.Add(this.label2);
            this.flowTheme1.Controls.Add(this.button2);
            this.flowTheme1.Controls.Add(this.checkBox1);
            this.flowTheme1.Controls.Add(this.label1);
            this.flowTheme1.Controls.Add(this.pictureBox2);
            this.flowTheme1.Controls.Add(this.pictureBox1);
            this.flowTheme1.Controls.Add(this.button1);
            this.flowTheme1.Controls.Add(this.passwordtext);
            this.flowTheme1.Controls.Add(this.usernametext);
            this.flowTheme1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.flowTheme1.Customization = "KCgo/xISEv//hAD/KCgo/xYWFv9BQUH/AAAA/ycnJ/8jIyP/HR0d/xoaGv8HBwcy////AA==";
            this.flowTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.flowTheme1.Image = null;
            this.flowTheme1.Location = new System.Drawing.Point(0, 0);
            this.flowTheme1.Movable = true;
            this.flowTheme1.Name = "flowTheme1";
            this.flowTheme1.NoRounding = false;
            this.flowTheme1.Sizable = false;
            this.flowTheme1.Size = new System.Drawing.Size(433, 225);
            this.flowTheme1.SmartBounds = true;
            this.flowTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.flowTheme1.TabIndex = 0;
            this.flowTheme1.Text = "Zer0";
            this.flowTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.flowTheme1.Transparent = false;
            this.flowTheme1.Click += new System.EventHandler(this.flowTheme1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(303, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 10);
            this.label1.TabIndex = 7;
            this.label1.Text = "Having trouble logging in?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(303, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordtext
            // 
            this.passwordtext.BorderColorFocused = System.Drawing.Color.Lavender;
            this.passwordtext.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordtext.BorderColorMouseHover = System.Drawing.Color.Lavender;
            this.passwordtext.BorderThickness = 3;
            this.passwordtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.passwordtext.ForeColor = System.Drawing.Color.White;
            this.passwordtext.isPassword = false;
            this.passwordtext.Location = new System.Drawing.Point(13, 133);
            this.passwordtext.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(282, 34);
            this.passwordtext.TabIndex = 1;
            this.passwordtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernametext
            // 
            this.usernametext.BorderColorFocused = System.Drawing.Color.Blue;
            this.usernametext.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernametext.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.usernametext.BorderThickness = 3;
            this.usernametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.usernametext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernametext.isPassword = false;
            this.usernametext.Location = new System.Drawing.Point(13, 91);
            this.usernametext.Margin = new System.Windows.Forms.Padding(4);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(282, 34);
            this.usernametext.TabIndex = 0;
            this.usernametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 225);
            this.Controls.Add(this.flowTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zer0";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.flowTheme1.ResumeLayout(false);
            this.flowTheme1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.FlowTheme flowTheme1;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwordtext;
        private Bunifu.Framework.UI.BunifuMetroTextbox usernametext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Diagnostics.Process process1;
    }
}