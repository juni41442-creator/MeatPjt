namespace MeatOrder
{
    partial class MeatOrderMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button OMeat;

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
            this.OMeat = new System.Windows.Forms.Button();
            this.NumAnalysis = new System.Windows.Forms.Button();
            this.MeatOrder = new System.Windows.Forms.Label();
            this.Util = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OMeat
            // 
            this.OMeat.Location = new System.Drawing.Point(850, 30);
            this.OMeat.Name = "OMeat";
            this.OMeat.Size = new System.Drawing.Size(120, 30);
            this.OMeat.TabIndex = 0;
            this.OMeat.Text = "발주";
            this.OMeat.UseVisualStyleBackColor = true;
            this.OMeat.Click += new System.EventHandler(this.Button1_Click);
            // 
            // NumAnalysis
            // 
            this.NumAnalysis.Location = new System.Drawing.Point(850, 70);
            this.NumAnalysis.Name = "NumAnalysis";
            this.NumAnalysis.Size = new System.Drawing.Size(120, 30);
            this.NumAnalysis.TabIndex = 1;
            this.NumAnalysis.Text = "수치분석";
            this.NumAnalysis.UseVisualStyleBackColor = true;
            this.NumAnalysis.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MeatOrder
            // 
            this.MeatOrder.AutoSize = true;
            this.MeatOrder.Location = new System.Drawing.Point(350, 180);
            this.MeatOrder.Name = "MeatOrder";
            this.MeatOrder.Size = new System.Drawing.Size(64, 12);
            this.MeatOrder.TabIndex = 3;
            this.MeatOrder.Text = "MeatOrder";
            this.MeatOrder.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Util
            // 
            this.Util.Location = new System.Drawing.Point(850, 110);
            this.Util.Name = "Util";
            this.Util.Size = new System.Drawing.Size(120, 30);
            this.Util.TabIndex = 4;
            this.Util.Text = "유틸리티";
            this.Util.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "원매가 계산기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(850, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "양념육 계산기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(850, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "세트 계산기";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "각종 계산기는 언제든지 열리게 할 것.원매가 1,양념육 2, 세트 3";
            // 
            // MeatOrderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Util);
            this.Controls.Add(this.MeatOrder);
            this.Controls.Add(this.NumAnalysis);
            this.Controls.Add(this.OMeat);
            this.Name = "MeatOrderMain";
            this.Text = "MeatOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NumAnalysis;
        private System.Windows.Forms.Label MeatOrder;
        private System.Windows.Forms.Button Util;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

