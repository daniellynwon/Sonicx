using System;
using System.Data;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1A02_PRODUCT_SUB : Form
    {
        public P1A02_PRODUCT parentWin;
        public string gubun;

        private int rowIndex = 0;
        private string prodCode = string.Empty;

        public P1A02_PRODUCT_SUB()
        {
            InitializeComponent();
        }

        private void P1A02_PRODUCT_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (gubun == "A") cbGubun.Text = "A.정품";
            else if (gubun == "B") cbGubun.Text = "B.부품";
            else if (gubun == "C") cbGubun.Text = "C.반제품";

            string sql = @"SELECT Classify FROM materials GROUP BY Classify";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbKind.DataSource = table;
                cbKind.ValueMember = "Classify";
                cbKind.DisplayMember = "Classify";
            }

            sql = @"SELECT ProductID, ModelName FROM product ORDER BY ProductID";
            m = new MariaCRUD();
            msg = string.Empty;
            table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbModel.DataSource = table;
                cbModel.ValueMember = "ProductID";
                cbModel.DisplayMember = "ModelName";
            }

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                cbKind.SelectedIndex = 0;
                this.ActiveControl = tbCode;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                prodCode = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                tbCode.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                cbKind.SelectedValue = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value;
                tbProdName.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                cbModel.SelectedValue = parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value;
                tbStock.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();


                cbGubun.Enabled = false;
                this.ActiveControl = btnSave;
            }
        }

        #region 엔터키로 포커스 이동
        public bool NextFocus(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                return true;
            }
            return false;
        }
        private void nextFocus_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = NextFocus(sender, e);
        }
        #endregion

        private void Save()
        {
            lblMsg.Text = "";

            string sCode = tbCode.Text.Trim();
            string sProdName = tbProdName.Text.Trim();

            if (String.IsNullOrEmpty(sCode))
            {
                lblMsg.Text = "품목코드를 입력해 주세요.";
                tbProdName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(sProdName))
            {
                lblMsg.Text = "품목명을 입력해 주세요.";
                tbProdName.Focus();
                return;
            }

            string sGubun = cbGubun.Text.Substring(0, 1);
            string sKind = cbKind.SelectedValue.ToString();

            sKind = sKind.Replace("'", "''");

            string sModel = cbModel.SelectedValue.ToString();
            string sStock = tbStock.Text.Trim();

            if (string.IsNullOrEmpty(sStock)) sStock = "0";

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                //입력한 자재코드 중복인지 확인..
                if (isProdCode(sCode))
                {
                    lblMsg.Text = "이미 존재하는 품목코드입니다.";
                    tbCode.Focus();
                    return;
                }

                sql = "insert into materials (MaterialID, MaterialCode, Classify, MaterialName, ProductID, SafeStock) " +
                    "values(null,'" + sCode + "','" + sKind + "','" + sProdName + "'," + sModel + "," + sStock + ")";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                lblMsg.Text = "저장되었습니다.";

                parentWin.tbSearch.Text = "";
                if (sGubun == "A") parentWin.rbA.Checked = true;
                else if (sGubun == "B") parentWin.rbB.Checked = true;
                else if (sGubun == "C") parentWin.rbC.Checked = true;

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
                {
                    if (parentWin.dataGridView1.Rows[i].Cells[2].Value.ToString() == getProdCode(sCode))
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[2, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbProdName.Text = string.Empty;
                tbProdName.Focus();
            }
            else
            {
                sql = "update materials " +
                    "set MaterialCode = '" + sCode + "', Classify = '" + sKind + "', MaterialName = '" + sProdName + "', ProductID = " + sModel + ", SafeStock = " + sStock +
                    " where MaterialID = '" + prodCode + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, prodCode + " " + sProdName);

                parentWin.ListSearch();
                parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, rowIndex];
                parentWin.dataGridView1.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region 품목코드 생성 / 품목명 확인 
        private string getProdCode(string _gubun)
        {
            string sql = @"select MAX(ProductID) from product";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        private bool isProdCode(string _prodCode)
        {
            string sql = @"SELECT MaterialCode FROM materials WHERE MaterialCode = '" + _prodCode + "'";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            object id = m.dbRonlyOne(sql, ref msg);

            if (msg == "OK" && id != null)
                return true;
            else
                return false;
        }
        #endregion

        #region Button Controls
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
