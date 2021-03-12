using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1C01_PROD_ORDER : SmartMES_Sonicx.FormBasic
    {
        public P1C01_PROD_ORDER()
        {
            InitializeComponent();
        }
        private void P1C01_PROD_ORDER_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
            this.ActiveControl = tbSearch;
        }
        public void ListSearch()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sFrom = dtpFromDate.Value.ToString("yyyy-MM-dd");
                string sTo = dtpToDate.Value.ToString("yyyy-MM-dd");
                string sSearch = tbSearch.Text.Trim();

                sPS_ProdOrder_QueryTableAdapter.Fill(dataSetP1D.SPS_ProdOrder_Query, DateTime.Parse(sFrom), DateTime.Parse(sTo), sSearch);

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();
            }
            catch (NullReferenceException)
            {
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #region Condition Bar Events
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        #endregion

        #region GridView Events
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMsg.Text = "";

            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 4) return;

            P1C01_PROD_ORDER_SUB sub = new P1C01_PROD_ORDER_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
            sub.parentWin = this;
            sub.parentRowIdx = e.RowIndex;
            sub.ShowDialog();
        }
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            P1C01_PROD_ORDER_SUB sub = new P1C01_PROD_ORDER_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        private void pbDel_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (G.Authority == "D") return;
            if (dataGridView1.RowCount == 0) return;

            int index = 0;
            string sDate = string.Empty;
            string sProdID = string.Empty;
            string sProdName = string.Empty;

            try
            {
                index = dataGridView1.CurrentRow.Index;
                sDate = DateTime.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()).ToString("yyyy-MM-dd");
                sProdID = dataGridView1.Rows[index].Cells[1].Value.ToString();
                sProdName = dataGridView1.Rows[index].Cells[4].Value.ToString();

                if (dataGridView1.Rows[index].Selected != true)
                {
                    MessageBox.Show("삭제 정보가 선택되지 않았습니다.", this.lblTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("삭제 정보가 선택되지 않았습니다.", this.lblTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("계획일자 : " + sDate + "\r품 목 명 : " + sProdID + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            string sql = @"select SaleQty from productionplan where PlanDate = '" + sDate + "' and ProductID = " + sProdID;
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            string com = m.dbRonlyOne(sql, ref msg).ToString();

            if (msg == "OK" && Int32.Parse(com) > 0)
                sql = "update from productionplan set ProdQty = 0 where PlanDate = '" + sDate + "' and ProductID = " + sProdID;
            else
                sql = "delete from productionplan where PlanDate = '" + sDate + "' and ProductID = " + sProdID;

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }

            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sDate + " " + sProdName);

            ListSearch();
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (dataGridView1.RowCount == 0) return;

            string reportFileName = "SmartMES_Sonicx.Reports.P1C01_PROD_ORDER.rdlc";

            string reportParm1 = "계획기간 : ";
            string reportParm2 = "제품명/분류/모델명 : ";
            string reportParm3 = "";

            reportParm1 = reportParm1 + dtpFromDate.Value.ToString("yyyy-MM-dd") + " ~ " + dtpToDate.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(tbSearch.Text.Trim())) reportParm2 = reportParm2 + "전체";
            else reportParm2 = reportParm2 + tbSearch.Text.Trim();

            ViewReport_V viewReport = new ViewReport_V();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPSProdOrderQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion
    }
}

