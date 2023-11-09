namespace Household_account
{
    partial class FOut
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
            this.Tb_memo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_out_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_memo
            // 
            this.Tb_memo.Location = new System.Drawing.Point(118, 244);
            this.Tb_memo.Name = "Tb_memo";
            this.Tb_memo.Size = new System.Drawing.Size(176, 21);
            this.Tb_memo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "비고";
            // 
            // Tb_amount
            // 
            this.Tb_amount.Location = new System.Drawing.Point(118, 164);
            this.Tb_amount.Name = "Tb_amount";
            this.Tb_amount.Size = new System.Drawing.Size(176, 21);
            this.Tb_amount.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "금액";
            // 
            // Tb_type
            // 
            this.Tb_type.Location = new System.Drawing.Point(118, 92);
            this.Tb_type.Name = "Tb_type";
            this.Tb_type.Size = new System.Drawing.Size(176, 21);
            this.Tb_type.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "분류";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(118, 26);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(176, 21);
            this.dtDate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "출금날짜";
            // 
            // bt_out_OK
            // 
            this.bt_out_OK.Location = new System.Drawing.Point(118, 294);
            this.bt_out_OK.Name = "bt_out_OK";
            this.bt_out_OK.Size = new System.Drawing.Size(123, 44);
            this.bt_out_OK.TabIndex = 16;
            this.bt_out_OK.Text = "추가하기";
            this.bt_out_OK.UseVisualStyleBackColor = true;
            this.bt_out_OK.Click += new System.EventHandler(this.bt_out_OK_Click);
            // 
            // FOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 362);
            this.Controls.Add(this.bt_out_OK);
            this.Controls.Add(this.Tb_memo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Tb_memo;
        public System.Windows.Forms.TextBox Tb_amount;
        public System.Windows.Forms.TextBox Tb_type;
        public System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button bt_out_OK;
    }
}