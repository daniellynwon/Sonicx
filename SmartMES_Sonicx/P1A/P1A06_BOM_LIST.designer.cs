namespace SmartMES_Sonicx
{
    partial class P1A06_BOM_LIST
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPSBOMLISTQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1A = new SmartMES_Sonicx.P1A.DataSetP1A();
            this.sPS_BOMLIST_QueryTableAdapter = new SmartMES_Sonicx.P1A.DataSetP1ATableAdapters.SPS_BOMLIST_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSBOMLISTQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "BOM현황";
            // 
            // pbPrint
            // 
            this.pbPrint.Image = global::SmartMES_Sonicx.Properties.Resources.out_B;
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = global::SmartMES_Sonicx.Properties.Resources.save_B;
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
            this.pbAdd.Enabled = false;
            this.pbAdd.Image = global::SmartMES_Sonicx.Properties.Resources.add_B;
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
            this.panSearch.Controls.Add(this.lblMsg);
            this.panSearch.Controls.Add(this.tbSearch);
            this.panSearch.Controls.Add(this.label5);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 72);
            this.panSearch.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(15, 45);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(565, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(277, 29);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(442, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "분류/코드/품명";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aidDataGridViewTextBoxColumn,
            this.acodeDataGridViewTextBoxColumn,
            this.aclassDataGridViewTextBoxColumn,
            this.anameDataGridViewTextBoxColumn,
            this.amodelDataGridViewTextBoxColumn,
            this.bidDataGridViewTextBoxColumn,
            this.bcodeDataGridViewTextBoxColumn,
            this.bclassDataGridViewTextBoxColumn,
            this.bnameDataGridViewTextBoxColumn,
            this.bmodelDataGridViewTextBoxColumn,
            this.bqtyDataGridViewTextBoxColumn,
            this.cidDataGridViewTextBoxColumn,
            this.ccodeDataGridViewTextBoxColumn,
            this.cclassDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.cmodelDataGridViewTextBoxColumn,
            this.cqtyDataGridViewTextBoxColumn,
            this.tOTqtyDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPSBOMLISTQueryBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 852);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // aidDataGridViewTextBoxColumn
            // 
            this.aidDataGridViewTextBoxColumn.DataPropertyName = "A_id";
            this.aidDataGridViewTextBoxColumn.HeaderText = "A_id";
            this.aidDataGridViewTextBoxColumn.Name = "aidDataGridViewTextBoxColumn";
            this.aidDataGridViewTextBoxColumn.ReadOnly = true;
            this.aidDataGridViewTextBoxColumn.Visible = false;
            // 
            // acodeDataGridViewTextBoxColumn
            // 
            this.acodeDataGridViewTextBoxColumn.DataPropertyName = "A_code";
            this.acodeDataGridViewTextBoxColumn.FillWeight = 70F;
            this.acodeDataGridViewTextBoxColumn.HeaderText = "A.코드";
            this.acodeDataGridViewTextBoxColumn.Name = "acodeDataGridViewTextBoxColumn";
            this.acodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aclassDataGridViewTextBoxColumn
            // 
            this.aclassDataGridViewTextBoxColumn.DataPropertyName = "A_class";
            this.aclassDataGridViewTextBoxColumn.FillWeight = 70F;
            this.aclassDataGridViewTextBoxColumn.HeaderText = "A.분류";
            this.aclassDataGridViewTextBoxColumn.Name = "aclassDataGridViewTextBoxColumn";
            this.aclassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anameDataGridViewTextBoxColumn
            // 
            this.anameDataGridViewTextBoxColumn.DataPropertyName = "A_name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.anameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.anameDataGridViewTextBoxColumn.FillWeight = 150F;
            this.anameDataGridViewTextBoxColumn.HeaderText = "A.품명";
            this.anameDataGridViewTextBoxColumn.Name = "anameDataGridViewTextBoxColumn";
            this.anameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amodelDataGridViewTextBoxColumn
            // 
            this.amodelDataGridViewTextBoxColumn.DataPropertyName = "A_model";
            this.amodelDataGridViewTextBoxColumn.HeaderText = "A.모델";
            this.amodelDataGridViewTextBoxColumn.Name = "amodelDataGridViewTextBoxColumn";
            this.amodelDataGridViewTextBoxColumn.ReadOnly = true;
            this.amodelDataGridViewTextBoxColumn.Visible = false;
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "B_id";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.bidDataGridViewTextBoxColumn.HeaderText = "B_id";
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidDataGridViewTextBoxColumn.Visible = false;
            // 
            // bcodeDataGridViewTextBoxColumn
            // 
            this.bcodeDataGridViewTextBoxColumn.DataPropertyName = "B_code";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bcodeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.bcodeDataGridViewTextBoxColumn.FillWeight = 70F;
            this.bcodeDataGridViewTextBoxColumn.HeaderText = "B.코드";
            this.bcodeDataGridViewTextBoxColumn.Name = "bcodeDataGridViewTextBoxColumn";
            this.bcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bclassDataGridViewTextBoxColumn
            // 
            this.bclassDataGridViewTextBoxColumn.DataPropertyName = "B_class";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bclassDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.bclassDataGridViewTextBoxColumn.FillWeight = 70F;
            this.bclassDataGridViewTextBoxColumn.HeaderText = "B.분류";
            this.bclassDataGridViewTextBoxColumn.Name = "bclassDataGridViewTextBoxColumn";
            this.bclassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bnameDataGridViewTextBoxColumn
            // 
            this.bnameDataGridViewTextBoxColumn.DataPropertyName = "B_name";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.bnameDataGridViewTextBoxColumn.FillWeight = 150F;
            this.bnameDataGridViewTextBoxColumn.HeaderText = "B.품명";
            this.bnameDataGridViewTextBoxColumn.Name = "bnameDataGridViewTextBoxColumn";
            this.bnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bmodelDataGridViewTextBoxColumn
            // 
            this.bmodelDataGridViewTextBoxColumn.DataPropertyName = "B_model";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bmodelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.bmodelDataGridViewTextBoxColumn.HeaderText = "B.모델";
            this.bmodelDataGridViewTextBoxColumn.Name = "bmodelDataGridViewTextBoxColumn";
            this.bmodelDataGridViewTextBoxColumn.ReadOnly = true;
            this.bmodelDataGridViewTextBoxColumn.Visible = false;
            // 
            // bqtyDataGridViewTextBoxColumn
            // 
            this.bqtyDataGridViewTextBoxColumn.DataPropertyName = "B_qty";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bqtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.bqtyDataGridViewTextBoxColumn.FillWeight = 60F;
            this.bqtyDataGridViewTextBoxColumn.HeaderText = "B.수량";
            this.bqtyDataGridViewTextBoxColumn.Name = "bqtyDataGridViewTextBoxColumn";
            this.bqtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.bqtyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "C_id";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.cidDataGridViewTextBoxColumn.HeaderText = "C_id";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidDataGridViewTextBoxColumn.Visible = false;
            // 
            // ccodeDataGridViewTextBoxColumn
            // 
            this.ccodeDataGridViewTextBoxColumn.DataPropertyName = "C_code";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ccodeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.ccodeDataGridViewTextBoxColumn.FillWeight = 70F;
            this.ccodeDataGridViewTextBoxColumn.HeaderText = "C.코드";
            this.ccodeDataGridViewTextBoxColumn.Name = "ccodeDataGridViewTextBoxColumn";
            this.ccodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cclassDataGridViewTextBoxColumn
            // 
            this.cclassDataGridViewTextBoxColumn.DataPropertyName = "C_class";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cclassDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.cclassDataGridViewTextBoxColumn.FillWeight = 70F;
            this.cclassDataGridViewTextBoxColumn.HeaderText = "C.분류";
            this.cclassDataGridViewTextBoxColumn.Name = "cclassDataGridViewTextBoxColumn";
            this.cclassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "C_name";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cnameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.cnameDataGridViewTextBoxColumn.FillWeight = 150F;
            this.cnameDataGridViewTextBoxColumn.HeaderText = "C.품명";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmodelDataGridViewTextBoxColumn
            // 
            this.cmodelDataGridViewTextBoxColumn.DataPropertyName = "C_model";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmodelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.cmodelDataGridViewTextBoxColumn.HeaderText = "C.모델";
            this.cmodelDataGridViewTextBoxColumn.Name = "cmodelDataGridViewTextBoxColumn";
            this.cmodelDataGridViewTextBoxColumn.ReadOnly = true;
            this.cmodelDataGridViewTextBoxColumn.Visible = false;
            // 
            // cqtyDataGridViewTextBoxColumn
            // 
            this.cqtyDataGridViewTextBoxColumn.DataPropertyName = "C_qty";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cqtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.cqtyDataGridViewTextBoxColumn.FillWeight = 60F;
            this.cqtyDataGridViewTextBoxColumn.HeaderText = "C.수량";
            this.cqtyDataGridViewTextBoxColumn.Name = "cqtyDataGridViewTextBoxColumn";
            this.cqtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.cqtyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tOTqtyDataGridViewTextBoxColumn
            // 
            this.tOTqtyDataGridViewTextBoxColumn.DataPropertyName = "TOT_qty";
            this.tOTqtyDataGridViewTextBoxColumn.FillWeight = 60F;
            this.tOTqtyDataGridViewTextBoxColumn.HeaderText = "합계량";
            this.tOTqtyDataGridViewTextBoxColumn.Name = "tOTqtyDataGridViewTextBoxColumn";
            this.tOTqtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTqtyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sPSBOMLISTQueryBindingSource
            // 
            this.sPSBOMLISTQueryBindingSource.DataMember = "SPS_BOMLIST_Query";
            this.sPSBOMLISTQueryBindingSource.DataSource = this.dataSetP1A;
            // 
            // dataSetP1A
            // 
            this.dataSetP1A.DataSetName = "DataSetP1A";
            this.dataSetP1A.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPS_BOMLIST_QueryTableAdapter
            // 
            this.sPS_BOMLIST_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1A06_BOM_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1A06_BOM_LIST";
            this.Text = "P1A06_BOM_LIST";
            this.Load += new System.EventHandler(this.P1A06_BOM_LIST_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPSBOMLISTQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn aidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPSBOMLISTQueryBindingSource;
        private P1A.DataSetP1A dataSetP1A;
        private P1A.DataSetP1ATableAdapters.SPS_BOMLIST_QueryTableAdapter sPS_BOMLIST_QueryTableAdapter;
    }
}
