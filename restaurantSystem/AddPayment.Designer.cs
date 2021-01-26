namespace restaurantSystem
{
    partial class AddPayment
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
            this.back_btn = new System.Windows.Forms.Button();
            this.addpayment_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ap_timestamp = new System.Windows.Forms.TextBox();
            this.ap_total = new System.Windows.Forms.TextBox();
            this.ap_balance = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ap_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(111, 430);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 38);
            this.back_btn.TabIndex = 21;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // addpayment_btn
            // 
            this.addpayment_btn.Location = new System.Drawing.Point(598, 430);
            this.addpayment_btn.Name = "addpayment_btn";
            this.addpayment_btn.Size = new System.Drawing.Size(101, 38);
            this.addpayment_btn.TabIndex = 20;
            this.addpayment_btn.Text = "Add Payment";
            this.addpayment_btn.UseVisualStyleBackColor = true;
            this.addpayment_btn.Click += new System.EventHandler(this.addpayment_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(151, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Timestamp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(151, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Method:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Amount:";
            // 
            // ap_timestamp
            // 
            this.ap_timestamp.ForeColor = System.Drawing.Color.Gray;
            this.ap_timestamp.Location = new System.Drawing.Point(290, 238);
            this.ap_timestamp.Name = "ap_timestamp";
            this.ap_timestamp.Size = new System.Drawing.Size(409, 20);
            this.ap_timestamp.TabIndex = 14;
            this.ap_timestamp.Text = "e.g. 2020-10-10 18:29:13";
            this.ap_timestamp.Enter += new System.EventHandler(this.ap_timestamp_Enter);
            this.ap_timestamp.Leave += new System.EventHandler(this.ap_timestamp_Leave);
            // 
            // ap_total
            // 
            this.ap_total.Location = new System.Drawing.Point(290, 146);
            this.ap_total.Name = "ap_total";
            this.ap_total.Size = new System.Drawing.Size(409, 20);
            this.ap_total.TabIndex = 12;
            // 
            // ap_balance
            // 
            this.ap_balance.Location = new System.Drawing.Point(290, 190);
            this.ap_balance.Name = "ap_balance";
            this.ap_balance.Size = new System.Drawing.Size(409, 20);
            this.ap_balance.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(36, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 268);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ap_comboBox
            // 
            this.ap_comboBox.FormattingEnabled = true;
            this.ap_comboBox.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.ap_comboBox.Location = new System.Drawing.Point(290, 98);
            this.ap_comboBox.Name = "ap_comboBox";
            this.ap_comboBox.Size = new System.Drawing.Size(409, 21);
            this.ap_comboBox.TabIndex = 22;
            this.ap_comboBox.Text = "Choose a method";
            this.ap_comboBox.SelectedIndexChanged += new System.EventHandler(this.ap_comboBox_SelectedIndexChanged);
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(814, 556);
            this.Controls.Add(this.ap_comboBox);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.addpayment_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ap_timestamp);
            this.Controls.Add(this.ap_total);
            this.Controls.Add(this.ap_balance);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPayment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button addpayment_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ap_timestamp;
        private System.Windows.Forms.TextBox ap_total;
        private System.Windows.Forms.TextBox ap_balance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ap_comboBox;
    }
}