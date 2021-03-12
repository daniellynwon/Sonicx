using System;
using System.Linq;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1A03_COMMON : SmartMES_Sonicx.FormBasic
    {
        public P1A03_COMMON()
        {
            InitializeComponent();
        }
        private void P1A03_COMMON_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSetP1A.SPW_PartInOut_Query' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.sPW_PartInOut_QueryTableAdapter.Fill(this.dataSetP1A.SPW_PartInOut_Query);
            // TODO: 이 코드는 데이터를 'dataSetP1A.SPW_DefectDetail_Query' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.sPW_DefectDetail_QueryTableAdapter.Fill(this.dataSetP1A.SPW_DefectDetail_Query);
            // TODO: 이 코드는 데이터를 'dataSetP1A.SPW_DefectType_Query' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.sPW_DefectType_QueryTableAdapter.Fill(this.dataSetP1A.SPW_DefectType_Query);
            ListSearch();
        }

        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sKind = tabControl1.SelectedTab.Text.Substring(0, 1);

                sPW_PartInOut_QueryTableAdapter.Fill(dataSetP1A.SPW_PartInOut_Query);
                sPW_DefectDetail_QueryTableAdapter.Fill(dataSetP1A.SPW_DefectDetail_Query);
                sPW_DefectType_QueryTableAdapter.Fill(dataSetP1A.SPW_DefectType_Query);

                dataGridViewA.CurrentCell = null;
                dataGridViewA.ClearSelection();
                dataGridViewB.CurrentCell = null;
                dataGridViewB.ClearSelection();
                dataGridViewC.CurrentCell = null;
                dataGridViewC.ClearSelection();
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

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            string sKind = tabControl1.SelectedTab.Text.Substring(0, 1);
            if (sKind == "A")
            {
                P1A03_COMMON_SUB sub = new P1A03_COMMON_SUB();
                sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
                sub.parentWin = this;
                sub.ShowDialog();
            }
            else if (sKind == "B")
            {
                P1A03_COMMON_SUB1 sub = new P1A03_COMMON_SUB1();
                sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
                sub.parentWin = this;
                sub.ShowDialog();
            }
            else if (sKind == "C")
            {
                P1A03_COMMON_SUB2 sub = new P1A03_COMMON_SUB2();
                sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
                sub.parentWin = this;
                sub.ShowDialog();
            }
        }
        private void pbDel_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            //
        }
        #endregion

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 0) return;

            string sKind = tabControl1.SelectedTab.Text.Substring(0, 1);
            if (sKind == "A")
            {
                P1A03_COMMON_SUB sub = new P1A03_COMMON_SUB();
                sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
                sub.parentWin = this;
                sub.ShowDialog();
            }
            else if (sKind == "B")
            {
                P1A03_COMMON_SUB1 sub = new P1A03_COMMON_SUB1();
                sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
                sub.parentWin = this;
                sub.ShowDialog();
            }
            else if (sKind == "C")
            {
                P1A03_COMMON_SUB2 sub = new P1A03_COMMON_SUB2();
                sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
                sub.parentWin = this;
                sub.ShowDialog();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sKind = tabControl1.SelectedTab.Text.Substring(0, 1);
            DataGridView dataGridView = this.Controls.Find("dataGridView" + sKind, true).FirstOrDefault() as DataGridView;

            if (G.Authority == "D") return;
            if (dataGridView.RowCount < 1) return;
            if (e.ColumnIndex != 0) return;

            string sId = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string sName = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (string.IsNullOrEmpty(sId)) return;

            if (sKind == "A")
            {
                DialogResult dr = MessageBox.Show("반출입사유: " + sName + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No) return;

                MariaCRUD m = new MariaCRUD();
                string sql = "delete from partinouttype where PartInOutTypeID = " + sId;
                string msg = string.Empty;
                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }
                ListSearch();
            }
            else if (sKind == "B")
            {
                MessageBox.Show("삭제대상이 아닙니다.");
            }
            else if (sKind == "C")
            {
                string sDetail = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                DialogResult dr = MessageBox.Show("세부항목: " + sDetail + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No) return;

                MariaCRUD m = new MariaCRUD();
                string sql = "delete from defectdetail where DetailID = " + sId;
                string msg = string.Empty;
                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }
                ListSearch();
            }
        }
        #endregion
    }
}
