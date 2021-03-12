using System;
using System.Data;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1A01_CUSTOMER_SUB : Form
    {
        public P1A01_CUSTOMER parentWin;
        private int rowIndex = 0;
        private string custCode = string.Empty;
        public P1A01_CUSTOMER_SUB()
        {
            InitializeComponent();
        }
        private void P1A01_CUSTOMER_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                this.ActiveControl = tbCustName;
                cbGubun.SelectedIndex = 0;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                custCode = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                cbGubun.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                tbCustName.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                tbTel.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                tbFax.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                tbCustMan.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
                tbHp.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                tbAddr1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
                tbPostNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
                tbBusiNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
                tbCeo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
                tbContents.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[13].Value.ToString();
                tbCountry.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();
                tbKind.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[16].Value.ToString();
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

        #region 주소
        private void lblPost_Click(object sender, EventArgs e)
        {
            PostAddr post = new PostAddr();
            post.FormSendEvent += new PostAddr.FormSendDataHandler(PostEventMethod);
            post.ShowDialog();
        }
        private void PostEventMethod(object sender)
        {
            string sAddr = sender.ToString();

            if (string.IsNullOrEmpty(sAddr)) return;

            tbPostNo.Text = sAddr.Substring(1, 5);
            tbAddr1.Text = sAddr.Substring(7, sAddr.Length - 7);
        }
        #endregion

        private void Save()
        {
            lblMsg.Text = "";

            string sCustName = tbCustName.Text.Trim();

            if (String.IsNullOrEmpty(sCustName))
            {
                lblMsg.Text = "거래처명을 입력해 주세요.";
                tbCustName.Focus();
                return;
            }

            string sCeo = tbCeo.Text.Trim();
            string sGubun = cbGubun.Text.Substring(0, 1);
            string sBusiNo = tbBusiNo.Text.Trim();
            string sPostNo = tbPostNo.Text.Trim();
            string sAddr = tbAddr1.Text.Trim();
            string sTel = tbTel.Text.Trim();
            string sFax = tbFax.Text.Trim();
            string sCustMan = tbCustMan.Text.Trim();
            string sManHp = tbHp.Text.Trim();
            string sContents = tbContents.Text.Trim();
            string sCountry = tbCountry.Text.Trim();
            string sKind = tbKind.Text.Trim();

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                if(sGubun == "1")
                {
                    sql = "insert into customer (CustomerID, CustomerName, RTel, FaxNo, CStaff, HHP, Address, Zipcode, CRegNo, CEO, Remark, Country, CKind) " +
                        "values(null," + sCustName + "','" + sTel + "','" + sFax + "','" + sCustMan + "','" + sManHp + "','" + sAddr + "','" + sPostNo + "','" + sBusiNo + "','" + sCeo + "','" + sContents + "','" + sCountry + "','" + sKind + "')";

                    m.dbCUD(sql, ref msg);

                    if (msg != "OK")
                    {
                        lblMsg.Text = msg;
                        return;
                    }
                }
                else if(sGubun == "2")
                {
                    sql = "insert into supplier (SupplierID, SupplierName, RTel, FaxNo, CStaff, HHP, Address, Zipcode, Remark) " +
                        "values(null," + sCustName + "','" + sTel + "','" + sFax + "','" + sCustMan + "','" + sManHp + "','" + sAddr + "','" + sPostNo + "','" + sContents + "')";

                    m.dbCUD(sql, ref msg);

                    if (msg != "OK")
                    {
                        lblMsg.Text = msg;
                        return;
                    }
                }
                
                lblMsg.Text = "저장되었습니다.";

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
                {
                    if (parentWin.dataGridView1.Rows[i].Cells[1].Value.ToString() == getCustCode(sGubun))
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbCustName.Text = string.Empty;
                tbCeo.Text = string.Empty;
                tbBusiNo.Text = string.Empty;
                tbPostNo.Text = string.Empty;
                tbAddr1.Text = string.Empty;
                tbTel.Text = string.Empty;
                tbFax.Text = string.Empty;
                tbCustMan.Text = string.Empty;
                tbHp.Text = string.Empty;
                tbContents.Text = string.Empty;
                tbCountry.Text = string.Empty;
                tbKind.Text = string.Empty;
                tbCustName.Focus();
            }
            else
            {
                if(sGubun == "1")
                {
                    sql = "update customer " +
                        "set CustomerName = '" + sCustName + "', RTel = '" + sTel + "', FaxNo = '" + sFax + "', CStaff = '" + sCustMan + "', HHP = '" + sManHp + "', Address = '" + sAddr + "', Zipcode = '" + sPostNo + "', CRegNo = '" + sBusiNo + "', CEO = '" + sCeo +
                        "', Remark = '" + sContents + "', Country = '" + sCountry + "', CKind = '" + sKind + "' " +
                        " where CustomerID = " + custCode;
                }
                else if(sGubun == "2")
                {
                    sql = "update supplier " +
                        "set SupplierName = '" + sCustName + "', RTel = '" + sTel + "', FaxNo = '" + sFax + "', CStaff = '" + sCustMan + "', HHP = '" + sManHp + "', Address = '" + sAddr + "', Zipcode = '" + sPostNo + "', Remark = '" + sContents + "' " +
                        " where SupplierID = " + custCode;
                }

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, custCode + " " + sCustName);

                parentWin.ListSearch();
                parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, rowIndex];
                parentWin.dataGridView1.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region 거래처코드 생성 / 거래처명 확인
        private string getCustCode(string gubun)
        {
            string sql = string.Empty;
            if(gubun == "1")
            {
                sql = "select MAX(CustomerID) from customer";
            }
            else if(gubun == "2")
            {
                sql = "select MAX(SupplierID) from supplier";
            }

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
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
