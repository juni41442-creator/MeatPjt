using System;
using System.Windows.Forms;

namespace MeatOrder
{
    public partial class MeatOrderMain : Form
    {
        public MeatOrderMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 발주 버튼: OrderForm 표시
            using (var frm = new OrderForm())
            {
                frm.ShowDialog(this);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 수치분석 버튼 클릭 처리 (임시)
            MessageBox.Show("수치분석 기능을 실행합니다.");
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            // 라벨 클릭 이벤트 (필요 시 구현)
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            // 양념육 계산기 버튼 클릭 처리 (임시)
            MessageBox.Show("양념육 계산기 열기");
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            // 원매가계산기 버튼: ScalForm 표시
            using (var scalf = new ScalForm())
            {
                scalf.ShowDialog(this);
            }

        }

    }
}
