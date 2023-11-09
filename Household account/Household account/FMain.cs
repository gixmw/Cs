using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Household_account
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void Bt_login_Click_1(object sender, EventArgs e)
        {
            FLogin form = new FLogin();//인스턴스화
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)//로그인 성공
            {
                //자료를 불러와서 표시
                //입,출금등록 활성화
                Bt_in.Enabled = true;
                Bt_out.Enabled = true;
            }
            else//로그인 실패
            {
                //표시목록 제거
                //입,출금등록 비활성화
                Bt_in.Enabled = false;
                Bt_out.Enabled = false;
            }
        }

        private void Bt_in_Click_1(object sender, EventArgs e)
        {
            FIn f = new FIn();
            DialogResult result = f.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //데이터 읽기
                DateTime 입력일 = f.dtDate.Value;
                string 분류 = f.Tb_type.Text;
                string 금액 = f.Tb_amount.Text;
                string 비고 = f.Tb_memo.Text;
                //데이터 추가하기

                //목록에 추가된 데이처를 표시한다. => 목록 새로고침
                ListViewItem lv = listView1.Items.Add(입력일.ToString());
                lv.SubItems.Add(분류);
                lv.SubItems.Add(금액);
                lv.SubItems.Add("");
                lv.SubItems.Add(비고);
            }
        }

        private void Bt_out_Click_1(object sender, EventArgs e)
        {
            FOut f = new FOut();
            DialogResult result = f.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //데이터 읽기
                DateTime 출금일 = f.dtDate.Value;
                string 분류 = f.Tb_type.Text;
                string 금액 = f.Tb_amount.Text;
                string 비고 = f.Tb_memo.Text;
                //데이터 추가하기

                //목록에 추가된 데이처를 표시한다. => 목록 새로고침
                ListViewItem lv = listView1.Items.Add(출금일.ToString());
                lv.SubItems.Add(분류);
                lv.SubItems.Add("");
                lv.SubItems.Add(금액);
                lv.SubItems.Add(비고);
            }
        }

        
    }
}
