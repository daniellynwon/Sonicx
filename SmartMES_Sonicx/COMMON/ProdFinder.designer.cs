﻿namespace SmartMES_Sonicx
{
    partial class ProdFinder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGubun = new System.Windows.Forms.ComboBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetCOMMON = new SmartMES_Sonicx.COMMON.DataSetCOMMON();
            this.sPSProductCommonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPS_Product_CommonTableAdapter = new SmartMES_Sonicx.COMMON.DataSetCOMMONTableAdapters.SPS_Product_CommonTableAdapter();
            this.구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.분류DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.모델IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모델그룹DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모델명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.타입DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCOMMON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSProductCommonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.구분DataGridViewTextBoxColumn,
            this.품목IDDataGridViewTextBoxColumn,
            this.품목코드DataGridViewTextBoxColumn,
            this.분류DataGridViewTextBoxColumn,
            this.품목명DataGridViewTextBoxColumn,
            this.모델IDDataGridViewTextBoxColumn,
            this.모델그룹DataGridViewTextBoxColumn,
            this.모델명DataGridViewTextBoxColumn,
            this.타입DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPSProductCommonBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(856, 561);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbGubun);
            this.panel1.Controls.Add(this.pbSearch);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 90);
            this.panel1.TabIndex = 0;
            // 
            // cbGubun
            // 
            this.cbGubun.BackColor = System.Drawing.SystemColors.Window;
            this.cbGubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGubun.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbGubun.FormattingEnabled = true;
            this.cbGubun.Items.AddRange(new object[] {
            "<전체>",
            "A.제품",
            "B.반제품",
            "C.자재"});
            this.cbGubun.Location = new System.Drawing.Point(630, 29);
            this.cbGubun.Name = "cbGubun";
            this.cbGubun.Size = new System.Drawing.Size(131, 29);
            this.cbGubun.TabIndex = 2;
            this.cbGubun.SelectedIndexChanged += new System.EventHandler(this.cbGubun_SelectedIndexChanged);
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Transparent;
            this.pbSearch.Image = global::SmartMES_Sonicx.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(471, 30);
            this.pbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(32, 26);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 4;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            this.pbSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSearch_MouseDown);
            this.pbSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbSearch_MouseUp);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbSearch.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbSearch.Location = new System.Drawing.Point(236, 29);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(273, 29);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(83, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "코드/품목명/모델명";
            // 
            // dataSetCOMMON
            // 
            this.dataSetCOMMON.DataSetName = "DataSetCOMMON";
            this.dataSetCOMMON.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPSProductCommonBindingSource
            // 
            this.sPSProductCommonBindingSource.DataMember = "SPS_Product_Common";
            this.sPSProductCommonBindingSource.DataSource = this.dataSetCOMMON;
            // 
            // sPS_Product_CommonTableAdapter
            // 
            this.sPS_Product_CommonTableAdapter.ClearBeforeFill = true;
            // 
            // 구분DataGridViewTextBoxColumn
            // 
            this.구분DataGridViewTextBoxColumn.DataPropertyName = "구분";
            this.구분DataGridViewTextBoxColumn.HeaderText = "구분";
            this.구분DataGridViewTextBoxColumn.Name = "구분DataGridViewTextBoxColumn";
            this.구분DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 품목IDDataGridViewTextBoxColumn
            // 
            this.품목IDDataGridViewTextBoxColumn.DataPropertyName = "품목ID";
            this.품목IDDataGridViewTextBoxColumn.HeaderText = "품목ID";
            this.품목IDDataGridViewTextBoxColumn.Name = "품목IDDataGridViewTextBoxColumn";
            this.품목IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.품목IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 품목코드DataGridViewTextBoxColumn
            // 
            this.품목코드DataGridViewTextBoxColumn.DataPropertyName = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.HeaderText = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.Name = "품목코드DataGridViewTextBoxColumn";
            this.품목코드DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 분류DataGridViewTextBoxColumn
            // 
            this.분류DataGridViewTextBoxColumn.DataPropertyName = "분류";
            this.분류DataGridViewTextBoxColumn.HeaderText = "분류";
            this.분류DataGridViewTextBoxColumn.Name = "분류DataGridViewTextBoxColumn";
            this.분류DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 품목명DataGridViewTextBoxColumn
            // 
            this.품목명DataGridViewTextBoxColumn.DataPropertyName = "품목명";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.품목명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.품목명DataGridViewTextBoxColumn.FillWeight = 200F;
            this.품목명DataGridViewTextBoxColumn.HeaderText = "품목명";
            this.품목명DataGridViewTextBoxColumn.Name = "품목명DataGridViewTextBoxColumn";
            this.품목명DataGridViewTextBoxColumn.ReadOnly = true;
            this.품목명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.품목명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 모델IDDataGridViewTextBoxColumn
            // 
            this.모델IDDataGridViewTextBoxColumn.DataPropertyName = "모델ID";
            this.모델IDDataGridViewTextBoxColumn.HeaderText = "모델ID";
            this.모델IDDataGridViewTextBoxColumn.Name = "모델IDDataGridViewTextBoxColumn";
            this.모델IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.모델IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 모델그룹DataGridViewTextBoxColumn
            // 
            this.모델그룹DataGridViewTextBoxColumn.DataPropertyName = "모델그룹";
            this.모델그룹DataGridViewTextBoxColumn.HeaderText = "모델그룹";
            this.모델그룹DataGridViewTextBoxColumn.Name = "모델그룹DataGridViewTextBoxColumn";
            this.모델그룹DataGridViewTextBoxColumn.ReadOnly = true;
            this.모델그룹DataGridViewTextBoxColumn.Visible = false;
            // 
            // 모델명DataGridViewTextBoxColumn
            // 
            this.모델명DataGridViewTextBoxColumn.DataPropertyName = "모델명";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.모델명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.모델명DataGridViewTextBoxColumn.FillWeight = 200F;
            this.모델명DataGridViewTextBoxColumn.HeaderText = "모델명";
            this.모델명DataGridViewTextBoxColumn.Name = "모델명DataGridViewTextBoxColumn";
            this.모델명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 타입DataGridViewTextBoxColumn
            // 
            this.타입DataGridViewTextBoxColumn.DataPropertyName = "타입";
            this.타입DataGridViewTextBoxColumn.HeaderText = "타입";
            this.타입DataGridViewTextBoxColumn.Name = "타입DataGridViewTextBoxColumn";
            this.타입DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProdFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 682);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdFinder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "품목 검색기";
            this.Load += new System.EventHandler(this.ProdFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCOMMON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSProductCommonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbGubun;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구분DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 분류DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델그룹DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 타입DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPSProductCommonBindingSource;
        private COMMON.DataSetCOMMON dataSetCOMMON;
        private COMMON.DataSetCOMMONTableAdapters.SPS_Product_CommonTableAdapter sPS_Product_CommonTableAdapter;
    }
}