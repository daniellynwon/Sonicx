using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class ProdFinder : Form
    {
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;

        public ProdFinder()
        {
            InitializeComponent();
        }
        private void ProdFinder_Load(object sender, EventArgs e)
        {
            //ListSearch();
            this.ActiveControl = tbSearch;
        }

        public void ListSearch()
        {
            try
            {
                string sSearch = tbSearch.Text.Trim();
                string sGubun = cbGubun.Text;
                if (sGubun == "<전체>") sGubun = "%";
                else sGubun = sGubun.Substring(0, 1);

                sPS_Product_CommonTableAdapter.Fill(dataSetCOMMON.SPS_Product_Common, sGubun, sSearch);

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbSearch_MouseDown(object sender, MouseEventArgs e)
        {
            pbSearch.Location = new Point(pbSearch.Location.X + 1, pbSearch.Location.Y + 1);
        }
        private void pbSearch_MouseUp(object sender, MouseEventArgs e)
        {
            pbSearch.Location = new Point(pbSearch.Location.X - 1, pbSearch.Location.Y - 1);
        }
        private void cbGubun_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSearch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 4) return;

            string s1 = dataGridView1[1, e.RowIndex].Value.ToString(); //품목ID
            string s2 = dataGridView1[2, e.RowIndex].Value.ToString(); //품목코드
            string s3 = dataGridView1[4, e.RowIndex].Value.ToString(); //품목명
            string s4 = dataGridView1[7, e.RowIndex].Value.ToString(); //모델명

            this.FormSendEvent(s1 + "#1/" + s2 + "#2/" + s3 + "#3/" + s4);
            this.Dispose();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
