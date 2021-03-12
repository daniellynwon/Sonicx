using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1A06_BOM_LIST : SmartMES_Sonicx.FormBasic
    {
        public P1A06_BOM_LIST()
        {
            InitializeComponent();
        }
        private void P1A06_BOM_LIST_Load(object sender, EventArgs e)
        {
            ListSearch();
            this.ActiveControl = tbSearch;
        }
        public void ListSearch()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sSearch = tbSearch.Text.Trim();

                sPS_BOMLIST_QueryTableAdapter.Fill(dataSetP1A.SPS_BOMLIST_Query, sSearch);

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
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        #endregion


        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            //
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

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.RowCount < 1) return;

            try
            {
                string sCodeA = dataGridView1.Rows[0].Cells[1].Value.ToString();
                string sCodeB = dataGridView1.Rows[0].Cells[6].Value.ToString();

                for (int i = 1; i < dataGridView1.RowCount; i++)
                {
                    if (sCodeA == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[1].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.Transparent;
                    }
                    sCodeA = dataGridView1.Rows[i].Cells[0].Value.ToString();

                    //

                    if (sCodeB == dataGridView1.Rows[i].Cells[6].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[6].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[9].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[10].Style.ForeColor = Color.Transparent;
                    }
                    sCodeB = dataGridView1.Rows[i].Cells[6].Value.ToString();
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
    }
}

