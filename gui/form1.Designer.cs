namespace gui
{
    partial class Form1
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
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.typ = new System.Windows.Forms.ComboBox();
            this.but = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login.Location = new System.Drawing.Point(398, 68);
            this.login.MaximumSize = new System.Drawing.Size(300, 54);
            this.login.MinimumSize = new System.Drawing.Size(300, 54);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(300, 54);
            this.login.TabIndex = 0;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pass.Location = new System.Drawing.Point(398, 197);
            this.pass.MaximumSize = new System.Drawing.Size(300, 54);
            this.pass.MinimumSize = new System.Drawing.Size(300, 54);
            this.pass.Name = "pass";
            this.pass.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.pass.Size = new System.Drawing.Size(300, 54);
            this.pass.TabIndex = 1;
            // 
            // typ
            // 
            this.typ.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typ.FormattingEnabled = true;
            this.typ.Items.AddRange(new object[] {
            "dealer",
            "client",
            "mechanic"});
            this.typ.Location = new System.Drawing.Point(398, 320);
            this.typ.MaximumSize = new System.Drawing.Size(300, 0);
            this.typ.MinimumSize = new System.Drawing.Size(300, 0);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(300, 54);
            this.typ.TabIndex = 2;
            this.typ.SelectedIndexChanged += new System.EventHandler(this.typ_SelectedIndexChanged);
            // 
            // but
            // 
            this.but.Location = new System.Drawing.Point(452, 437);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(75, 23);
            this.but.TabIndex = 3;
            this.but.Text = "button1";
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.but_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(64, 57);
            this.label4.MaximumSize = new System.Drawing.Size(300, 75);
            this.label4.MinimumSize = new System.Drawing.Size(300, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 75);
            this.label4.TabIndex = 4;
            this.label4.Text = "Login";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(64, 186);
            this.label5.MaximumSize = new System.Drawing.Size(300, 75);
            this.label5.MinimumSize = new System.Drawing.Size(300, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 75);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hasło";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(64, 309);
            this.label6.MaximumSize = new System.Drawing.Size(300, 75);
            this.label6.MinimumSize = new System.Drawing.Size(300, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 75);
            this.label6.TabIndex = 6;
            this.label6.Text = "Typ użytkownika";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(751, 499);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but);
            this.Controls.Add(this.typ);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.ComboBox typ;
        private System.Windows.Forms.Button but;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

