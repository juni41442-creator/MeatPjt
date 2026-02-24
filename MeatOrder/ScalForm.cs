using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatOrder
{
    public partial class ScalForm : Form
    {
        private float SourceResult = 0;     //원가 기본값
        private float SalesResult = 0;      //매가 기본값
        private float MarginResult = 0;     //마진 기본값

      
        public ScalForm()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

       

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)  //원가 반영 버튼
        {
            SourceRst();
        }

        private void Button2_Click(object sender, EventArgs e)  //매가 반영 버튼
        {
            SalesRst();
        }

        private void Button3_Click(object sender, EventArgs e)  //마진 반영 버튼            
        {
            MarginRst();
        }

        //한군데 입력중일때 다른 부분 회색으로 처리하고 나머지 둘중 한군데
        //수정했을때 전체적으로 회색이 풀리면서 세군데 최종 결과값이 나타나게 해야 함.


        private void TextBox1_KeyDown(object sender, KeyEventArgs e)    //원가 텍스트 박스에서 엔터 입력시 처리
        {            
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;               
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)    //원가 텍스트 박스에서 엔터 입력시 처리
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;              
            }
        }
        private void TextBox3_KeyDown(object sender, KeyEventArgs e)    //원가 텍스트 박스에서 엔터 입력시 처리
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;               
            }
        }

        void SourceRst()    //원가계산함수
        {
            SalesResult = float.Parse(SalesPrice.Text);
            MarginResult = float.Parse(MarginPercent.Text) / 100;
            SourceResult = SalesResult * (1 - MarginResult);
            SourcePrice.Text = SourceResult.ToString();
        }

        void SalesRst()     //매가 계산 함수
        {
            SourceResult = float.Parse(SourcePrice.Text);
            MarginResult = float.Parse(MarginPercent.Text) / 100;
            SalesResult = SourceResult / (1 - MarginResult);
            SalesPrice.Text = SalesResult.ToString();
        }

        void MarginRst()    //마진 계산 함수
        {
            SourceResult = float.Parse(SourcePrice.Text);
            SalesResult = float.Parse(SalesPrice.Text);
            MarginResult = (1 - (SourceResult / SalesResult)) * 100;
            MarginPercent.Text = MarginResult.ToString();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
