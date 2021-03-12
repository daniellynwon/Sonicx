namespace SmartMES_Sonicx
{
    partial class P1A02_PRODUCT
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPWProductQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1A = new SmartMES_Sonicx.P1A.DataSetP1A();
            this.sPW_Product_QueryTableAdapter = new SmartMES_Sonicx.P1A.DataSetP1ATableAdapters.SPW_Product_QueryTableAdapter();
            this.번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.중분류DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조달DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품군DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모델명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.스탠다드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단가DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구매처DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.안전재고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.참조DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.재고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.등록일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPWProductQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "품목정보";
            // 
            // pbPrint
            // 
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // pbSave
            // 
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbDel
            // 
            this.pbDel.Enabled = false;
            this.pbDel.Image = global::SmartMES_Sonicx.Properties.Resources.del_B;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // panSearch
            // 
            this.panSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSearch.AutoSize = true;
            this.panSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSearch.Controls.Add(this.rbC);
            this.panSearch.Controls.Add(this.rbB);
            this.panSearch.Controls.Add(this.rbA);
            this.panSearch.Controls.Add(this.tbSearch);
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 71);
            this.panSearch.TabIndex = 0;
            // 
            // rbC
            // 
            this.rbC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbC.AutoSize = true;
            this.rbC.ForeColor = System.Drawing.Color.Blue;
            this.rbC.Location = new System.Drawing.Point(338, 21);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(60, 25);
            this.rbC.TabIndex = 5;
            this.rbC.Text = "부품";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbB
            // 
            this.rbB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbB.AutoSize = true;
            this.rbB.ForeColor = System.Drawing.Color.Blue;
            this.rbB.Location = new System.Drawing.Point(248, 21);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(76, 25);
            this.rbB.TabIndex = 3;
            this.rbB.Text = "반제품";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbA
            // 
            this.rbA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbA.AutoSize = true;
            this.rbA.Checked = true;
            this.rbA.ForeColor = System.Drawing.Color.Blue;
            this.rbA.Location = new System.Drawing.Point(158, 21);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(60, 25);
            this.rbA.TabIndex = 2;
            this.rbA.TabStop = true;
            this.rbA.Text = "정품";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(840, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(265, 29);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(721, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목명/모델명";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.번호DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.자재코드DataGridViewTextBoxColumn,
            this.중분류DataGridViewTextBoxColumn,
            this.품목명,
            this.제품코드DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.조달DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.제품군DataGridViewTextBoxColumn,
            this.모델명DataGridViewTextBoxColumn,
            this.스탠다드DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.단가DataGridViewTextBoxColumn,
            this.구매처DataGridViewTextBoxColumn,
            this.안전재고DataGridViewTextBoxColumn,
            this.참조DataGridViewTextBoxColumn,
            this.재고DataGridViewTextBoxColumn,
            this.등록일자DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPWProductQueryBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 852);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // sPWProductQueryBindingSource
            // 
            this.sPWProductQueryBindingSource.DataMember = "SPW_Product_Query";
            this.sPWProductQueryBindingSource.DataSource = this.dataSetP1A;
            // 
            // dataSetP1A
            // 
            this.dataSetP1A.DataSetName = "DataSetP1A";
            this.dataSetP1A.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPW_Product_QueryTableAdapter
            // 
            this.sPW_Product_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // 번호DataGridViewTextBoxColumn
            // 
            this.번호DataGridViewTextBoxColumn.DataPropertyName = "번호";
            this.번호DataGridViewTextBoxColumn.FillWeight = 20F;
            this.번호DataGridViewTextBoxColumn.HeaderText = "No.";
            this.번호DataGridViewTextBoxColumn.Name = "번호DataGridViewTextBoxColumn";
            this.번호DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "품목코드";
            this.dataGridViewTextBoxColumn1.FillWeight = 40F;
            this.dataGridViewTextBoxColumn1.HeaderText = "품목ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // 자재코드DataGridViewTextBoxColumn
            // 
            this.자재코드DataGridViewTextBoxColumn.DataPropertyName = "자재코드";
            this.자재코드DataGridViewTextBoxColumn.FillWeight = 50F;
            this.자재코드DataGridViewTextBoxColumn.HeaderText = "품목코드";
            this.자재코드DataGridViewTextBoxColumn.Name = "자재코드DataGridViewTextBoxColumn";
            this.자재코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.자재코드DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.자재코드DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 중분류DataGridViewTextBoxColumn
            // 
            this.중분류DataGridViewTextBoxColumn.DataPropertyName = "중분류";
            this.중분류DataGridViewTextBoxColumn.FillWeight = 40F;
            this.중분류DataGridViewTextBoxColumn.HeaderText = "분류";
            this.중분류DataGridViewTextBoxColumn.Name = "중분류DataGridViewTextBoxColumn";
            this.중분류DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 품목명
            // 
            this.품목명.DataPropertyName = "품목명";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.품목명.DefaultCellStyle = dataGridViewCellStyle3;
            this.품목명.FillWeight = 70F;
            this.품목명.HeaderText = "품목명";
            this.품목명.Name = "품목명";
            this.품목명.ReadOnly = true;
            // 
            // 제품코드DataGridViewTextBoxColumn
            // 
            this.제품코드DataGridViewTextBoxColumn.DataPropertyName = "제품코드";
            this.제품코드DataGridViewTextBoxColumn.HeaderText = "제품코드";
            this.제품코드DataGridViewTextBoxColumn.Name = "제품코드DataGridViewTextBoxColumn";
            this.제품코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.제품코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "규격";
            this.dataGridViewTextBoxColumn2.HeaderText = "규격";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // 조달DataGridViewTextBoxColumn
            // 
            this.조달DataGridViewTextBoxColumn.DataPropertyName = "조달";
            this.조달DataGridViewTextBoxColumn.FillWeight = 40F;
            this.조달DataGridViewTextBoxColumn.HeaderText = "조달";
            this.조달DataGridViewTextBoxColumn.Name = "조달DataGridViewTextBoxColumn";
            this.조달DataGridViewTextBoxColumn.ReadOnly = true;
            this.조달DataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "분류코드";
            this.dataGridViewTextBoxColumn3.HeaderText = "분류코드";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // 제품군DataGridViewTextBoxColumn
            // 
            this.제품군DataGridViewTextBoxColumn.DataPropertyName = "제품군";
            this.제품군DataGridViewTextBoxColumn.HeaderText = "제품군";
            this.제품군DataGridViewTextBoxColumn.Name = "제품군DataGridViewTextBoxColumn";
            this.제품군DataGridViewTextBoxColumn.ReadOnly = true;
            this.제품군DataGridViewTextBoxColumn.Visible = false;
            // 
            // 모델명DataGridViewTextBoxColumn
            // 
            this.모델명DataGridViewTextBoxColumn.DataPropertyName = "모델명";
            this.모델명DataGridViewTextBoxColumn.FillWeight = 70F;
            this.모델명DataGridViewTextBoxColumn.HeaderText = "모델명";
            this.모델명DataGridViewTextBoxColumn.Name = "모델명DataGridViewTextBoxColumn";
            this.모델명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 스탠다드DataGridViewTextBoxColumn
            // 
            this.스탠다드DataGridViewTextBoxColumn.DataPropertyName = "스탠다드";
            this.스탠다드DataGridViewTextBoxColumn.HeaderText = "스탠다드";
            this.스탠다드DataGridViewTextBoxColumn.Name = "스탠다드DataGridViewTextBoxColumn";
            this.스탠다드DataGridViewTextBoxColumn.ReadOnly = true;
            this.스탠다드DataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "단위";
            this.dataGridViewTextBoxColumn4.FillWeight = 30F;
            this.dataGridViewTextBoxColumn4.HeaderText = "단위";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // 단가DataGridViewTextBoxColumn
            // 
            this.단가DataGridViewTextBoxColumn.DataPropertyName = "단가";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.단가DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.단가DataGridViewTextBoxColumn.FillWeight = 40F;
            this.단가DataGridViewTextBoxColumn.HeaderText = "단가";
            this.단가DataGridViewTextBoxColumn.Name = "단가DataGridViewTextBoxColumn";
            this.단가DataGridViewTextBoxColumn.ReadOnly = true;
            this.단가DataGridViewTextBoxColumn.Visible = false;
            // 
            // 구매처DataGridViewTextBoxColumn
            // 
            this.구매처DataGridViewTextBoxColumn.DataPropertyName = "구매처";
            this.구매처DataGridViewTextBoxColumn.FillWeight = 50F;
            this.구매처DataGridViewTextBoxColumn.HeaderText = "구매처";
            this.구매처DataGridViewTextBoxColumn.Name = "구매처DataGridViewTextBoxColumn";
            this.구매처DataGridViewTextBoxColumn.ReadOnly = true;
            this.구매처DataGridViewTextBoxColumn.Visible = false;
            // 
            // 안전재고DataGridViewTextBoxColumn
            // 
            this.안전재고DataGridViewTextBoxColumn.DataPropertyName = "안전재고";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.안전재고DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.안전재고DataGridViewTextBoxColumn.FillWeight = 40F;
            this.안전재고DataGridViewTextBoxColumn.HeaderText = "안전재고";
            this.안전재고DataGridViewTextBoxColumn.Name = "안전재고DataGridViewTextBoxColumn";
            this.안전재고DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 참조DataGridViewTextBoxColumn
            // 
            this.참조DataGridViewTextBoxColumn.DataPropertyName = "참조";
            this.참조DataGridViewTextBoxColumn.HeaderText = "참조";
            this.참조DataGridViewTextBoxColumn.Name = "참조DataGridViewTextBoxColumn";
            this.참조DataGridViewTextBoxColumn.ReadOnly = true;
            this.참조DataGridViewTextBoxColumn.Visible = false;
            // 
            // 재고DataGridViewTextBoxColumn
            // 
            this.재고DataGridViewTextBoxColumn.DataPropertyName = "재고";
            this.재고DataGridViewTextBoxColumn.HeaderText = "재고";
            this.재고DataGridViewTextBoxColumn.Name = "재고DataGridViewTextBoxColumn";
            this.재고DataGridViewTextBoxColumn.ReadOnly = true;
            this.재고DataGridViewTextBoxColumn.Visible = false;
            // 
            // 등록일자DataGridViewTextBoxColumn
            // 
            this.등록일자DataGridViewTextBoxColumn.DataPropertyName = "등록일자";
            this.등록일자DataGridViewTextBoxColumn.HeaderText = "등록일자";
            this.등록일자DataGridViewTextBoxColumn.Name = "등록일자DataGridViewTextBoxColumn";
            this.등록일자DataGridViewTextBoxColumn.ReadOnly = true;
            this.등록일자DataGridViewTextBoxColumn.Visible = false;
            // 
            // P1A02_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1A02_PRODUCT";
            this.Text = "P1A02_PRODUCT";
            this.Load += new System.EventHandler(this.P1A02_PRODUCT_Load);
            this.Controls.SetChildIndex(this.panSearch, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPWProductQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 분류코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 분류DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단위DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단위1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 재고대상DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 재고단가DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용DataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox tbSearch;
        public System.Windows.Forms.RadioButton rbB;
        public System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.BindingSource sPWProductQueryBindingSource;
        private P1A.DataSetP1A dataSetP1A;
        private P1A.DataSetP1ATableAdapters.SPW_Product_QueryTableAdapter sPW_Product_QueryTableAdapter;
        public System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.DataGridViewTextBoxColumn 번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn 자재코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 중분류DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조달DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품군DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 스탠다드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단가DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구매처DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 안전재고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 참조DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 재고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 등록일자DataGridViewTextBoxColumn;
    }
}
