using System;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1A02_PROD_INFO : SmartMES_Sonicx.FormBasic
    {
        public P1A02_PROD_INFO()
        {
            InitializeComponent();
        }

        private void P1A02_PROD_INFO_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSetP1A.SPW_ProdModel_Query' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.sPW_ProdModel_QueryTableAdapter.Fill(this.dataSetP1A.SPW_ProdModel_Query);

        }
        public void ListSearch()
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                sPW_ProdModel_QueryTableAdapter.Fill(dataSetP1A.SPW_ProdModel_Query);

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
        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            P1A02_PROD_INFO_SUB sub = new P1A02_PROD_INFO_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            //sub.gubun = sGubun;
            sub.parentWin = this;
            sub.ShowDialog();
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

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 3) return;

            P1A02_PROD_INFO_SUB sub = new P1A02_PROD_INFO_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
            //sub.gubun = sGubun;
            sub.parentWin = this;
            sub.ShowDialog();
        }
        #endregion
    }
}
