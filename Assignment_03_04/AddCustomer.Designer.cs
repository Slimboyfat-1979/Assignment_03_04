namespace Assignment_03_04
{
    partial class AddCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEBal = new System.Windows.Forms.TextBox();
            this.txtIBal = new System.Windows.Forms.TextBox();
            this.txtOBal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Everyday Balance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Investment Balance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(101, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Omni Balance :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(298, 209);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 23);
            this.txtName.TabIndex = 10;
            // 
            // txtEBal
            // 
            this.txtEBal.Location = new System.Drawing.Point(298, 258);
            this.txtEBal.Name = "txtEBal";
            this.txtEBal.Size = new System.Drawing.Size(94, 23);
            this.txtEBal.TabIndex = 11;
            // 
            // txtIBal
            // 
            this.txtIBal.Location = new System.Drawing.Point(298, 310);
            this.txtIBal.Name = "txtIBal";
            this.txtIBal.Size = new System.Drawing.Size(94, 23);
            this.txtIBal.TabIndex = 12;
            // 
            // txtOBal
            // 
            this.txtOBal.Location = new System.Drawing.Point(298, 364);
            this.txtOBal.Name = "txtOBal";
            this.txtOBal.Size = new System.Drawing.Size(94, 23);
            this.txtOBal.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOBal);
            this.Controls.Add(this.txtIBal);
            this.Controls.Add(this.txtEBal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtEBal, 0);
            this.Controls.SetChildIndex(this.txtIBal, 0);
            this.Controls.SetChildIndex(this.txtOBal, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEBal;
        private System.Windows.Forms.TextBox txtIBal;
        private System.Windows.Forms.TextBox txtOBal;
        private System.Windows.Forms.Button button1;
    }
}