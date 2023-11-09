namespace Household_account
{
    partial class FMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.분류 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.입금 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.출금 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.비고 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bt_in = new System.Windows.Forms.ToolStripButton();
            this.Bt_out = new System.Windows.Forms.ToolStripButton();
            this.Bt_login = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bt_in,
            this.Bt_out,
            this.Bt_login});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(879, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "사용자";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel2.Text = "...";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.날짜,
            this.분류,
            this.입금,
            this.출금,
            this.비고});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(879, 467);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 날짜
            // 
            this.날짜.Text = "날짜";
            this.날짜.Width = 191;
            // 
            // 분류
            // 
            this.분류.Text = "분류";
            this.분류.Width = 126;
            // 
            // 입금
            // 
            this.입금.Text = "입금";
            this.입금.Width = 125;
            // 
            // 출금
            // 
            this.출금.Text = "출금";
            this.출금.Width = 128;
            // 
            // 비고
            // 
            this.비고.Text = "비고";
            this.비고.Width = 303;
            // 
            // Bt_in
            // 
            this.Bt_in.Image = ((System.Drawing.Image)(resources.GetObject("Bt_in.Image")));
            this.Bt_in.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_in.Name = "Bt_in";
            this.Bt_in.Size = new System.Drawing.Size(51, 22);
            this.Bt_in.Text = "입금";
            this.Bt_in.Click += new System.EventHandler(this.Bt_in_Click_1);
            // 
            // Bt_out
            // 
            this.Bt_out.Image = ((System.Drawing.Image)(resources.GetObject("Bt_out.Image")));
            this.Bt_out.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_out.Name = "Bt_out";
            this.Bt_out.Size = new System.Drawing.Size(51, 22);
            this.Bt_out.Text = "출금";
            this.Bt_out.Click += new System.EventHandler(this.Bt_out_Click_1);
            // 
            // Bt_login
            // 
            this.Bt_login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Bt_login.Image = ((System.Drawing.Image)(resources.GetObject("Bt_login.Image")));
            this.Bt_login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bt_login.Name = "Bt_login";
            this.Bt_login.Size = new System.Drawing.Size(63, 22);
            this.Bt_login.Text = "로그인";
            this.Bt_login.Click += new System.EventHandler(this.Bt_login_Click_1);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 514);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "가계부";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 날짜;
        private System.Windows.Forms.ColumnHeader 분류;
        private System.Windows.Forms.ColumnHeader 입금;
        private System.Windows.Forms.ColumnHeader 출금;
        private System.Windows.Forms.ColumnHeader 비고;
        private System.Windows.Forms.ToolStripButton Bt_in;
        private System.Windows.Forms.ToolStripButton Bt_out;
        private System.Windows.Forms.ToolStripButton Bt_login;
    }
}

