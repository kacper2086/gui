namespace gui
{
    partial class DealerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.part = new System.Windows.Forms.ComboBox();
            this.client = new System.Windows.Forms.ComboBox();
            this.ilosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.czescprzyjm = new System.Windows.Forms.ComboBox();
            this.iloscprzyjm = new System.Windows.Forms.TextBox();
            this.przyjmij = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.zamow = new System.Windows.Forms.Label();
            this.ordername = new System.Windows.Forms.ComboBox();
            this.orderq = new System.Windows.Forms.TextBox();
            this.orderb = new System.Windows.Forms.Button();
            this.catalogprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(241, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel handlowca";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wydaj część";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // part
            // 
            this.part.FormattingEnabled = true;
            this.part.Location = new System.Drawing.Point(98, 135);
            this.part.Margin = new System.Windows.Forms.Padding(2);
            this.part.Name = "part";
            this.part.Size = new System.Drawing.Size(92, 21);
            this.part.TabIndex = 4;
            this.part.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // client
            // 
            this.client.FormattingEnabled = true;
            this.client.Location = new System.Drawing.Point(98, 175);
            this.client.Margin = new System.Windows.Forms.Padding(2);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(92, 21);
            this.client.TabIndex = 5;
            // 
            // ilosc
            // 
            this.ilosc.Location = new System.Drawing.Point(98, 218);
            this.ilosc.Name = "ilosc";
            this.ilosc.Size = new System.Drawing.Size(100, 20);
            this.ilosc.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nazwa części";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nazwa Klienta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ilość";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Przyjmij część";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // czescprzyjm
            // 
            this.czescprzyjm.FormattingEnabled = true;
            this.czescprzyjm.Location = new System.Drawing.Point(266, 141);
            this.czescprzyjm.Margin = new System.Windows.Forms.Padding(2);
            this.czescprzyjm.MaximumSize = new System.Drawing.Size(150, 0);
            this.czescprzyjm.MinimumSize = new System.Drawing.Size(150, 0);
            this.czescprzyjm.Name = "czescprzyjm";
            this.czescprzyjm.Size = new System.Drawing.Size(150, 21);
            this.czescprzyjm.TabIndex = 13;
            this.czescprzyjm.SelectedIndexChanged += new System.EventHandler(this.czescprzyjm_SelectedIndexChanged);
            // 
            // iloscprzyjm
            // 
            this.iloscprzyjm.Location = new System.Drawing.Point(277, 218);
            this.iloscprzyjm.Name = "iloscprzyjm";
            this.iloscprzyjm.Size = new System.Drawing.Size(100, 20);
            this.iloscprzyjm.TabIndex = 14;
            // 
            // przyjmij
            // 
            this.przyjmij.Location = new System.Drawing.Point(321, 292);
            this.przyjmij.Margin = new System.Windows.Forms.Padding(2);
            this.przyjmij.Name = "przyjmij";
            this.przyjmij.Size = new System.Drawing.Size(56, 19);
            this.przyjmij.TabIndex = 15;
            this.przyjmij.Text = "button2";
            this.przyjmij.UseVisualStyleBackColor = true;
            this.przyjmij.Click += new System.EventHandler(this.przyjmij_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(321, 415);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(159, 23);
            this.refresh.TabIndex = 16;
            this.refresh.Text = "Odśwież dane";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // zamow
            // 
            this.zamow.AutoSize = true;
            this.zamow.Location = new System.Drawing.Point(653, 97);
            this.zamow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zamow.Name = "zamow";
            this.zamow.Size = new System.Drawing.Size(73, 13);
            this.zamow.TabIndex = 17;
            this.zamow.Text = "Zamów część";
            // 
            // ordername
            // 
            this.ordername.FormattingEnabled = true;
            this.ordername.Location = new System.Drawing.Point(629, 138);
            this.ordername.Margin = new System.Windows.Forms.Padding(2);
            this.ordername.MaximumSize = new System.Drawing.Size(150, 0);
            this.ordername.MinimumSize = new System.Drawing.Size(150, 0);
            this.ordername.Name = "ordername";
            this.ordername.Size = new System.Drawing.Size(150, 21);
            this.ordername.TabIndex = 18;
            this.ordername.SelectedIndexChanged += new System.EventHandler(this.ordername_SelectedIndexChanged);
            // 
            // orderq
            // 
            this.orderq.Location = new System.Drawing.Point(629, 184);
            this.orderq.Name = "orderq";
            this.orderq.Size = new System.Drawing.Size(100, 20);
            this.orderq.TabIndex = 19;
            // 
            // orderb
            // 
            this.orderb.Location = new System.Drawing.Point(642, 292);
            this.orderb.Margin = new System.Windows.Forms.Padding(2);
            this.orderb.Name = "orderb";
            this.orderb.Size = new System.Drawing.Size(56, 19);
            this.orderb.TabIndex = 20;
            this.orderb.Text = "Zamów";
            this.orderb.UseVisualStyleBackColor = true;
            this.orderb.Click += new System.EventHandler(this.orderb_Click);
            // 
            // catalogprice
            // 
            this.catalogprice.Location = new System.Drawing.Point(629, 232);
            this.catalogprice.Name = "catalogprice";
            this.catalogprice.Size = new System.Drawing.Size(100, 20);
            this.catalogprice.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ilość";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nazwa części";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(522, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cena katalogowa";
            // 
            // DealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.catalogprice);
            this.Controls.Add(this.orderb);
            this.Controls.Add(this.orderq);
            this.Controls.Add(this.ordername);
            this.Controls.Add(this.zamow);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.przyjmij);
            this.Controls.Add(this.iloscprzyjm);
            this.Controls.Add(this.czescprzyjm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ilosc);
            this.Controls.Add(this.client);
            this.Controls.Add(this.part);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "DealerForm";
            this.Text = "dealerform";
            this.Load += new System.EventHandler(this.DealerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox part;
        private System.Windows.Forms.ComboBox client;
        private System.Windows.Forms.TextBox ilosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox czescprzyjm;
        private System.Windows.Forms.TextBox iloscprzyjm;
        private System.Windows.Forms.Button przyjmij;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label zamow;
        private System.Windows.Forms.ComboBox ordername;
        private System.Windows.Forms.TextBox orderq;
        private System.Windows.Forms.Button orderb;
        private System.Windows.Forms.TextBox catalogprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}