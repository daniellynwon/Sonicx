
namespace SmartMES_Sonicx
{
    partial class P1A01_CUSTOMER_SUB
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
            this.panTitle = new System.Windows.Forms.Panel();
            this.tbHp = new System.Windows.Forms.TextBox();
            this.tbCustMan = new System.Windows.Forms.TextBox();
            this.tbBusiNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddr1 = new System.Windows.Forms.TextBox();
            this.tbPostNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGubun = new System.Windows.Forms.ComboBox();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbCeo = new System.Windows.Forms.TextBox();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbKind = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new SmartMES_Sonicx.UserButtonA();
            this.btnSave = new SmartMES_Sonicx.UserButtonA();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.SystemColors.Info;
            this.panTitle.BackgroundImage = global::SmartMES_Sonicx.Properties.Resources.photo_background;
            this.panTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(1007, 54);
            this.panTitle.TabIndex = 2;
            // 
            // tbHp
            // 
            this.tbHp.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbHp.Location = new System.Drawing.Point(484, 490);
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(217, 29);
            this.tbHp.TabIndex = 13;
            this.tbHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbCustMan
            // 
            this.tbCustMan.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCustMan.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbCustMan.Location = new System.Drawing.Point(123, 490);
            this.tbCustMan.Name = "tbCustMan";
            this.tbCustMan.Size = new System.Drawing.Size(217, 29);
            this.tbCustMan.TabIndex = 12;
            this.tbCustMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCustMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbBusiNo
            // 
            this.tbBusiNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbBusiNo.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbBusiNo.Location = new System.Drawing.Point(123, 272);
            this.tbBusiNo.Name = "tbBusiNo";
            this.tbBusiNo.Size = new System.Drawing.Size(217, 29);
            this.tbBusiNo.TabIndex = 5;
            this.tbBusiNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBusiNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(29, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "사업자번호";
            // 
            // tbAddr1
            // 
            this.tbAddr1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbAddr1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbAddr1.Location = new System.Drawing.Point(123, 371);
            this.tbAddr1.Name = "tbAddr1";
            this.tbAddr1.Size = new System.Drawing.Size(578, 29);
            this.tbAddr1.TabIndex = 8;
            this.tbAddr1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbPostNo
            // 
            this.tbPostNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbPostNo.Location = new System.Drawing.Point(123, 335);
            this.tbPostNo.Name = "tbPostNo";
            this.tbPostNo.Size = new System.Drawing.Size(217, 29);
            this.tbPostNo.TabIndex = 7;
            this.tbPostNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPostNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(29, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "우편주소";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPost.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline);
            this.lblPost.ForeColor = System.Drawing.Color.Blue;
            this.lblPost.Location = new System.Drawing.Point(29, 339);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(74, 21);
            this.lblPost.TabIndex = 24;
            this.lblPost.Text = "우편번호";
            this.lblPost.Click += new System.EventHandler(this.lblPost_Click);
            // 
            // tbContents
            // 
            this.tbContents.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbContents.Location = new System.Drawing.Point(729, 209);
            this.tbContents.Multiline = true;
            this.tbContents.Name = "tbContents";
            this.tbContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContents.Size = new System.Drawing.Size(251, 290);
            this.tbContents.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(735, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 23;
            this.label14.Text = "특이사항";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(378, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "담당자연락처";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(29, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "거래담당자";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(378, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "팩스번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(29, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "전화번호";
            // 
            // cbGubun
            // 
            this.cbGubun.BackColor = System.Drawing.SystemColors.Window;
            this.cbGubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGubun.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbGubun.FormattingEnabled = true;
            this.cbGubun.Items.AddRange(new object[] {
            "1.매출처",
            "2.매입처",
            "3.공통"});
            this.cbGubun.Location = new System.Drawing.Point(484, 209);
            this.cbGubun.Name = "cbGubun";
            this.cbGubun.Size = new System.Drawing.Size(217, 29);
            this.cbGubun.TabIndex = 4;
            this.cbGubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbFax
            // 
            this.tbFax.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbFax.Location = new System.Drawing.Point(484, 427);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(217, 29);
            this.tbFax.TabIndex = 11;
            this.tbFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbTel.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbTel.Location = new System.Drawing.Point(123, 427);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(217, 29);
            this.tbTel.TabIndex = 10;
            this.tbTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbCeo
            // 
            this.tbCeo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCeo.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbCeo.Location = new System.Drawing.Point(123, 209);
            this.tbCeo.Name = "tbCeo";
            this.tbCeo.Size = new System.Drawing.Size(217, 29);
            this.tbCeo.TabIndex = 3;
            this.tbCeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCeo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbCustName
            // 
            this.tbCustName.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCustName.Location = new System.Drawing.Point(123, 146);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(217, 29);
            this.tbCustName.TabIndex = 1;
            this.tbCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCustName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(29, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "대표자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(378, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "입출처구분";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(29, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "거래처명";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(27, 95);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 25;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCountry.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbCountry.Location = new System.Drawing.Point(484, 272);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(217, 29);
            this.tbCountry.TabIndex = 6;
            this.tbCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(379, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 46;
            this.label12.Text = "해외구분";
            // 
            // tbKind
            // 
            this.tbKind.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbKind.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbKind.Location = new System.Drawing.Point(484, 147);
            this.tbKind.Name = "tbKind";
            this.tbKind.Size = new System.Drawing.Size(217, 29);
            this.tbKind.TabIndex = 2;
            this.tbKind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(379, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 48;
            this.label13.Text = "업체구분";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Sonicx.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.buttonImage = global::SmartMES_Sonicx.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(525, 579);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 43;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::SmartMES_Sonicx.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.buttonImage = global::SmartMES_Sonicx.Properties.Resources.save;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(369, 579);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 15;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "거래처정보";
            // 
            // P1A01_CUSTOMER_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1007, 656);
            this.Controls.Add(this.panTitle);
            this.Controls.Add(this.tbKind);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbHp);
            this.Controls.Add(this.tbCustMan);
            this.Controls.Add(this.tbBusiNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAddr1);
            this.Controls.Add(this.tbPostNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.tbContents);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbGubun);
            this.Controls.Add(this.tbFax);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbCeo);
            this.Controls.Add(this.tbCustName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblMsg);
            this.Name = "P1A01_CUSTOMER_SUB";
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1A01_CUSTOMER_SUB_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.TextBox tbHp;
        private System.Windows.Forms.TextBox tbCustMan;
        private System.Windows.Forms.TextBox tbBusiNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddr1;
        private System.Windows.Forms.TextBox tbPostNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.TextBox tbContents;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbGubun;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbCeo;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMsg;
        private UserButtonA btnSave;
        private UserButtonA btnClose;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbKind;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblTitle;
    }
}