namespace Household_account
{
    partial class FIn
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
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_type = new System.Windows.Forms.TextBox();
            this.Tb_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_memo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_in_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "입금날짜";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(120, 28);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(176, 21);
            this.dtDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "분류";
            // 
            // Tb_type
            // 
            this.Tb_type.Location = new System.Drawing.Point(120, 94);
            this.Tb_type.Name = "Tb_type";
            this.Tb_type.Size = new System.Drawing.Size(176, 21);
            this.Tb_type.TabIndex = 3;
            // 
            // Tb_amount
            // 
            this.Tb_amount.Location = new System.Drawing.Point(120, 166);
            this.Tb_amount.Name = "Tb_amount";
            this.Tb_amount.Size = new System.Drawing.Size(176, 21);
            this.Tb_amount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "금액";
            // 
            // Tb_memo
            // 
            this.Tb_memo.Location = new System.Drawing.Point(120, 246);
            this.Tb_memo.Name = "Tb_memo";
            this.Tb_memo.Size = new System.Drawing.Size(176, 21);
            this.Tb_memo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "비고";
            // 
            // bt_in_OK
            // 
            this.bt_in_OK.Location = new System.Drawing.Point(131, 295);
            this.bt_in_OK.Name = "bt_in_OK";
            this.bt_in_OK.Size = new System.Drawing.Size(123, 44);
            this.bt_in_OK.TabIndex = 8;
            this.bt_in_OK.Text = "추가하기";
            this.bt_in_OK.UseVisualStyleBackColor = true;
            this.bt_in_OK.Click += new System.EventHandler(this.bt_in_OK_Click);
            // 
            // FIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 364);
            this.Controls.Add(this.bt_in_OK);
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
            this.Name = "FIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Tb_type;
        public System.Windows.Forms.TextBox Tb_amount;
        public System.Windows.Forms.TextBox Tb_memo;
        public System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button bt_in_OK;
    }
}