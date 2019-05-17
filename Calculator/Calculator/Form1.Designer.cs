namespace Calculator
{
    partial class Form
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
            this.btn_1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_9 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_0 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_add = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_sub = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_mul = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_div = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_res = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_bck = new MaterialSkin.Controls.MaterialRaisedButton();
            this.historyField = new MaterialSkin.Controls.MaterialLabel();
            this.resultField = new MaterialSkin.Controls.MaterialLabel();
            this.btn_cln = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Depth = 0;
            this.btn_1.Location = new System.Drawing.Point(12, 101);
            this.btn_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_1.Name = "btn_1";
            this.btn_1.Primary = true;
            this.btn_1.Size = new System.Drawing.Size(75, 75);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Depth = 0;
            this.btn_2.Location = new System.Drawing.Point(93, 101);
            this.btn_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_2.Name = "btn_2";
            this.btn_2.Primary = true;
            this.btn_2.Size = new System.Drawing.Size(75, 75);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Depth = 0;
            this.btn_3.Location = new System.Drawing.Point(174, 101);
            this.btn_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_3.Name = "btn_3";
            this.btn_3.Primary = true;
            this.btn_3.Size = new System.Drawing.Size(75, 75);
            this.btn_3.TabIndex = 4;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Depth = 0;
            this.btn_4.Location = new System.Drawing.Point(12, 182);
            this.btn_4.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_4.Name = "btn_4";
            this.btn_4.Primary = true;
            this.btn_4.Size = new System.Drawing.Size(75, 75);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Depth = 0;
            this.btn_5.Location = new System.Drawing.Point(93, 182);
            this.btn_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_5.Name = "btn_5";
            this.btn_5.Primary = true;
            this.btn_5.Size = new System.Drawing.Size(75, 75);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Depth = 0;
            this.btn_6.Location = new System.Drawing.Point(174, 182);
            this.btn_6.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_6.Name = "btn_6";
            this.btn_6.Primary = true;
            this.btn_6.Size = new System.Drawing.Size(75, 75);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.Depth = 0;
            this.btn_7.Location = new System.Drawing.Point(12, 263);
            this.btn_7.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_7.Name = "btn_7";
            this.btn_7.Primary = true;
            this.btn_7.Size = new System.Drawing.Size(75, 75);
            this.btn_7.TabIndex = 8;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Depth = 0;
            this.btn_8.Location = new System.Drawing.Point(93, 263);
            this.btn_8.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_8.Name = "btn_8";
            this.btn_8.Primary = true;
            this.btn_8.Size = new System.Drawing.Size(75, 75);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Depth = 0;
            this.btn_9.Location = new System.Drawing.Point(174, 263);
            this.btn_9.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_9.Name = "btn_9";
            this.btn_9.Primary = true;
            this.btn_9.Size = new System.Drawing.Size(75, 75);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_0
            // 
            this.btn_0.Depth = 0;
            this.btn_0.Location = new System.Drawing.Point(93, 344);
            this.btn_0.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_0.Name = "btn_0";
            this.btn_0.Primary = true;
            this.btn_0.Size = new System.Drawing.Size(75, 75);
            this.btn_0.TabIndex = 11;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_add
            // 
            this.btn_add.Depth = 0;
            this.btn_add.Location = new System.Drawing.Point(255, 101);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.Primary = true;
            this.btn_add.Size = new System.Drawing.Size(75, 75);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Depth = 0;
            this.btn_sub.Location = new System.Drawing.Point(255, 182);
            this.btn_sub.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Primary = true;
            this.btn_sub.Size = new System.Drawing.Size(75, 75);
            this.btn_sub.TabIndex = 13;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Depth = 0;
            this.btn_mul.Location = new System.Drawing.Point(255, 263);
            this.btn_mul.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Primary = true;
            this.btn_mul.Size = new System.Drawing.Size(75, 75);
            this.btn_mul.TabIndex = 14;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_div
            // 
            this.btn_div.Depth = 0;
            this.btn_div.Location = new System.Drawing.Point(255, 344);
            this.btn_div.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_div.Name = "btn_div";
            this.btn_div.Primary = true;
            this.btn_div.Size = new System.Drawing.Size(75, 75);
            this.btn_div.TabIndex = 15;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_res
            // 
            this.btn_res.Depth = 0;
            this.btn_res.Location = new System.Drawing.Point(174, 344);
            this.btn_res.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_res.Name = "btn_res";
            this.btn_res.Primary = true;
            this.btn_res.Size = new System.Drawing.Size(75, 75);
            this.btn_res.TabIndex = 16;
            this.btn_res.Text = "=";
            this.btn_res.UseVisualStyleBackColor = true;
            this.btn_res.Click += new System.EventHandler(this.btn_res_Click);
            // 
            // btn_bck
            // 
            this.btn_bck.Depth = 0;
            this.btn_bck.Location = new System.Drawing.Point(12, 344);
            this.btn_bck.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_bck.Name = "btn_bck";
            this.btn_bck.Primary = true;
            this.btn_bck.Size = new System.Drawing.Size(75, 75);
            this.btn_bck.TabIndex = 17;
            this.btn_bck.Text = "<";
            this.btn_bck.UseVisualStyleBackColor = true;
            this.btn_bck.Click += new System.EventHandler(this.btn_bck_Click);
            // 
            // historyField
            // 
            this.historyField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.historyField.Depth = 0;
            this.historyField.Font = new System.Drawing.Font("Roboto", 11F);
            this.historyField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.historyField.Location = new System.Drawing.Point(342, 72);
            this.historyField.MouseState = MaterialSkin.MouseState.HOVER;
            this.historyField.Name = "historyField";
            this.historyField.Size = new System.Drawing.Size(386, 347);
            this.historyField.TabIndex = 18;
            // 
            // resultField
            // 
            this.resultField.Depth = 0;
            this.resultField.Font = new System.Drawing.Font("Roboto", 11F);
            this.resultField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultField.Location = new System.Drawing.Point(13, 72);
            this.resultField.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultField.Name = "resultField";
            this.resultField.Size = new System.Drawing.Size(236, 26);
            this.resultField.TabIndex = 19;
            // 
            // btn_cln
            // 
            this.btn_cln.Depth = 0;
            this.btn_cln.Location = new System.Drawing.Point(255, 72);
            this.btn_cln.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cln.Name = "btn_cln";
            this.btn_cln.Primary = true;
            this.btn_cln.Size = new System.Drawing.Size(75, 26);
            this.btn_cln.TabIndex = 20;
            this.btn_cln.Text = "clear";
            this.btn_cln.UseVisualStyleBackColor = true;
            this.btn_cln.Click += new System.EventHandler(this.btn_cln_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 431);
            this.Controls.Add(this.btn_cln);
            this.Controls.Add(this.resultField);
            this.Controls.Add(this.historyField);
            this.Controls.Add(this.btn_bck);
            this.Controls.Add(this.btn_res);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.Sizable = false;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btn_1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_3;
        private MaterialSkin.Controls.MaterialRaisedButton btn_4;
        private MaterialSkin.Controls.MaterialRaisedButton btn_5;
        private MaterialSkin.Controls.MaterialRaisedButton btn_6;
        private MaterialSkin.Controls.MaterialRaisedButton btn_7;
        private MaterialSkin.Controls.MaterialRaisedButton btn_8;
        private MaterialSkin.Controls.MaterialRaisedButton btn_9;
        private MaterialSkin.Controls.MaterialRaisedButton btn_0;
        private MaterialSkin.Controls.MaterialRaisedButton btn_add;
        private MaterialSkin.Controls.MaterialRaisedButton btn_sub;
        private MaterialSkin.Controls.MaterialRaisedButton btn_mul;
        private MaterialSkin.Controls.MaterialRaisedButton btn_div;
        private MaterialSkin.Controls.MaterialRaisedButton btn_res;
        private MaterialSkin.Controls.MaterialRaisedButton btn_bck;
        private MaterialSkin.Controls.MaterialLabel historyField;
        private MaterialSkin.Controls.MaterialLabel resultField;
        private MaterialSkin.Controls.MaterialRaisedButton btn_cln;
    }
}

