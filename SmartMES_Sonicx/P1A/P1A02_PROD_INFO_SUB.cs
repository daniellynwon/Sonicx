using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1A02_PROD_INFO_SUB : Form
    {
        public P1A02_PROD_INFO parentWin;
        private int rowIndex = 0;
        public P1A02_PROD_INFO_SUB()
        {
            InitializeComponent();
        }
        private void P1A02_PROD_INFO_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string sql = @"SELECT ProductGroup FROM product GROUP BY ProductGroup";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbGroup.DataSource = table;
                cbGroup.ValueMember = "ProductGroup";
                cbGroup.DisplayMember = "ProductGroup";
            }

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                cbGroup.SelectedIndex = 0;
                this.ActiveControl = tbCode;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                tbID.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                tbCode.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                cbGroup.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                tbModel.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                tbContents.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                dtpDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());

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

            string sModelName = tbModel.Text.Trim();
            string sId = tbID.Text.Trim();

            if (String.IsNullOrEmpty(sModelName))
            {
                lblMsg.Text = "모델명을 입력해 주세요.";
                tbModel.Focus();
                return;
            }

            string sCode = tbCode.Text.Trim();
            string sGroup = cbGroup.Text.ToString();
            string sModel = tbModel.Text.Trim();
            string sContents = tbContents.Text.Trim();
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                //입력한 모델코드 중복인지 확인..
                if (isProdCode(sCode))
                {
                    lblMsg.Text = "이미 존재하는 모델코드입니다.";
                    tbCode.Focus();
                    return;
                }
                sql = "insert into product (ProductID, ProductCode, ProductGroup, ModelName, Remark, RegDate) " +
                    "values(null,'" + sCode + "','" + sGroup + "','" + sModel + "','" + sContents + "','" + sDate + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                lblMsg.Text = "저장되었습니다.";
                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
                {
                    if (parentWin.dataGridView1.Rows[i].Cells[1].Value.ToString() == getProdCode(sId))
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbCode.Text = string.Empty;
                tbModel.Text = string.Empty;
                tbContents.Text = string.Empty;
                tbModel.Focus();
            }
            else
            {
                sql = "update product " +
                    "set ProductCode = '" + sCode + "', ProductGroup = '" + sGroup + "', ModelName = '" + sModel + "', Remark = '" + sContents + "'" +
                    " where ProductID = '" + sId + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, sId + " " + sModel);

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
            string sql = @"SELECT ProductCode FROM product WHERE ProductCode = '" + _prodCode + "'";

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
