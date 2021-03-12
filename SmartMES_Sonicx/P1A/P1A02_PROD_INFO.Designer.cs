
namespace SmartMES_Sonicx
{
    partial class P1A02_PROD_INFO
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPWProdModelQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1A = new SmartMES_Sonicx.P1A.DataSetP1A();
            this.panSearch = new System.Windows.Forms.Panel();
            this.sPW_ProdModel_QueryTableAdapter = new SmartMES_Sonicx.P1A.DataSetP1ATableAdapters.SPW_ProdModel_QueryTableAdapter();
            this.모델ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모델코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모델군 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모델명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.참조DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.재고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.등록일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPWProdModelQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "제품모델정보";
            // 
            // pbDel
            // 
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
            this.모델ID,
            this.모델코드,
            this.모델군,
            this.모델명DataGridViewTextBoxColumn,
            this.참조DataGridViewTextBoxColumn,
            this.재고DataGridViewTextBoxColumn,
            this.등록일DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPWProdModelQueryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 852);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sPWProdModelQueryBindingSource
            // 
            this.sPWProdModelQueryBindingSource.DataMember = "SPW_ProdModel_Query";
            this.sPWProdModelQueryBindingSource.DataSource = this.dataSetP1A;
            // 
            // dataSetP1A
            // 
            this.dataSetP1A.DataSetName = "DataSetP1A";
            this.dataSetP1A.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panSearch
            // 
            this.panSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSearch.AutoSize = true;
            this.panSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 71);
            this.panSearch.TabIndex = 9;
            // 
            // sPW_ProdModel_QueryTableAdapter
            // 
            this.sPW_ProdModel_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // 모델ID
            // 
            this.모델ID.DataPropertyName = "모델ID";
            this.모델ID.HeaderText = "모델ID";
            this.모델ID.Name = "모델ID";
            this.모델ID.ReadOnly = true;
            // 
            // 모델코드
            // 
            this.모델코드.DataPropertyName = "모델코드";
            this.모델코드.HeaderText = "모델코드";
            this.모델코드.Name = "모델코드";
            this.모델코드.ReadOnly = true;
            // 
            // 모델군
            // 
            this.모델군.DataPropertyName = "모델군";
            this.모델군.HeaderText = "모델군";
            this.모델군.Name = "모델군";
            this.모델군.ReadOnly = true;
            // 
            // 모델명DataGridViewTextBoxColumn
            // 
            this.모델명DataGridViewTextBoxColumn.DataPropertyName = "모델명";
            this.모델명DataGridViewTextBoxColumn.HeaderText = "모델명";
            this.모델명DataGridViewTextBoxColumn.Name = "모델명DataGridViewTextBoxColumn";
            this.모델명DataGridViewTextBoxColumn.ReadOnly = true;
            this.모델명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.모델명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 참조DataGridViewTextBoxColumn
            // 
            this.참조DataGridViewTextBoxColumn.DataPropertyName = "참조";
            this.참조DataGridViewTextBoxColumn.HeaderText = "참조";
            this.참조DataGridViewTextBoxColumn.Name = "참조DataGridViewTextBoxColumn";
            this.참조DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 재고DataGridViewTextBoxColumn
            // 
            this.재고DataGridViewTextBoxColumn.DataPropertyName = "재고";
            this.재고DataGridViewTextBoxColumn.HeaderText = "재고";
            this.재고DataGridViewTextBoxColumn.Name = "재고DataGridViewTextBoxColumn";
            this.재고DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 등록일DataGridViewTextBoxColumn
            // 
            this.등록일DataGridViewTextBoxColumn.DataPropertyName = "등록일";
            this.등록일DataGridViewTextBoxColumn.HeaderText = "등록일";
            this.등록일DataGridViewTextBoxColumn.Name = "등록일DataGridViewTextBoxColumn";
            this.등록일DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // P1A02_PROD_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.panSearch);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Name = "P1A02_PROD_INFO";
            this.Text = "P1A02_PROD_INFO";
            this.Load += new System.EventHandler(this.P1A02_PROD_INFO_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.panSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPWProdModelQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panSearch;
        private P1A.DataSetP1A dataSetP1A;
        private System.Windows.Forms.BindingSource sPWProdModelQueryBindingSource;
        private P1A.DataSetP1ATableAdapters.SPW_ProdModel_QueryTableAdapter sPW_ProdModel_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 제품코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품군DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델군;
        private System.Windows.Forms.DataGridViewLinkColumn 모델명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 참조DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 재고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 등록일DataGridViewTextBoxColumn;
    }
}