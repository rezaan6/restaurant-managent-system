namespace restaurantSystem
{
    partial class Payment
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
            this.payment_table = new System.Windows.Forms.DataGridView();
            this.p_remove = new System.Windows.Forms.Button();
            this.p_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.payment_table)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(53, 463);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // payment_table
            // 
            this.payment_table.AllowUserToAddRows = false;
            this.payment_table.AllowUserToDeleteRows = false;
            this.payment_table.AllowUserToResizeColumns = false;
            this.payment_table.AllowUserToResizeRows = false;
            this.payment_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payment_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.payment_table.BackgroundColor = System.Drawing.Color.White;
            this.payment_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment_table.GridColor = System.Drawing.Color.Black;
            this.payment_table.Location = new System.Drawing.Point(32, 42);
            this.payment_table.Name = "payment_table";
            this.payment_table.Size = new System.Drawing.Size(707, 363);
            this.payment_table.TabIndex = 2;
            // 
            // p_remove
            // 
            this.p_remove.Location = new System.Drawing.Point(664, 472);
            this.p_remove.Name = "p_remove";
            this.p_remove.Size = new System.Drawing.Size(75, 23);
            this.p_remove.TabIndex = 4;
            this.p_remove.Text = "Remove";
            this.p_remove.UseVisualStyleBackColor = true;
            this.p_remove.Click += new System.EventHandler(this.p_remove_Click);
            // 
            // p_add
            // 
            this.p_add.Location = new System.Drawing.Point(528, 472);
            this.p_add.Name = "p_add";
            this.p_add.Size = new System.Drawing.Size(75, 23);
            this.p_add.TabIndex = 5;
            this.p_add.Text = "Add";
            this.p_add.UseVisualStyleBackColor = true;
            this.p_add.Click += new System.EventHandler(this.p_add_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(814, 556);
            this.Controls.Add(this.p_add);
            this.Controls.Add(this.p_remove);
            this.Controls.Add(this.payment_table);
            this.Controls.Add(this.back_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payment_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView payment_table;
        private System.Windows.Forms.Button p_remove;
        private System.Windows.Forms.Button p_add;
    }
}