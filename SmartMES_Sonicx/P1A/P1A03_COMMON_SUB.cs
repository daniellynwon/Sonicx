using System;
using System.Data;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1A03_COMMON_SUB : Form
    {
        public P1A03_COMMON parentWin;
        private int rowIndex = 0;

        public P1A03_COMMON_SUB()
        {
            InitializeComponent();
        }

        private void P1A03_COMMON_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                this.ActiveControl = tbSayu;
                cbType.SelectedIndex = 0;
            }
            else
            {
                rowIndex = parentWin.dataGridViewA.CurrentCell.RowIndex;

                tbKind.Text = parentWin.dataGridViewA.Rows[rowIndex].Cells[1].Value.ToString();
                tbSayu.Text = parentWin.dataGridViewA.Rows[rowIndex].Cells[2].Value.ToString();

                string sTypeValue = parentWin.dataGridViewA.Rows[rowIndex].Cells[3].Value.ToString().Substring(0,1);
                if (sTypeValue == "1") cbType.SelectedIndex = 0;
                else if(sTypeValue == "2") cbType.SelectedIndex = 1;
                else if(sTypeValue == "3") cbType.SelectedIndex = 2;
                else if(sTypeValue == "4") cbType.SelectedIndex = 3;

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

            string sKind = tbKind.Text.Trim();
            string sSayu = tbSayu.Text.Trim();

            if (String.IsNullOrEmpty(sSayu))
            {
                lblMsg.Text = "사유를 입력해 주세요.";
                tbSayu.Focus();
                return;
            }

            string sType = cbType.Text.Substring(0, 1);

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                tbKind.Text = getCommonCode(sType);

                sql = "insert into partinouttype (PartInOutTypeID, PartInOutTypeName, ClassFlag) " +
                    "values(" + tbKind.Text + ",'" + sSayu + "'," + sType + ")";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                lblMsg.Text = "저장되었습니다.";

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridViewA.Rows.Count; i++)
                {
                    if (parentWin.dataGridViewA.Rows[i].Cells[1].Value.ToString() == sSayu)
                    {
                        parentWin.dataGridViewA.CurrentCell = parentWin.dataGridViewA[0, i];
                        parentWin.dataGridViewA.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbKind.Text = getCommonCode(sType);
                tbSayu.Text = string.Empty;
                cbType.SelectedIndex = 0;
                tbSayu.Focus();
            }
            else
            {
                sql = "update partinouttype " +
                    "set PartInOutTypeName = '" + sSayu + "', ClassFlag = '" + sType + "'" +
                    " where PartInOutTypeID = '" + sKind + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, tbSayu.Text + " " + sType);

                parentWin.ListSearch();
                parentWin.dataGridViewA.CurrentCell = parentWin.dataGridViewA[0, rowIndex];
                parentWin.dataGridViewA.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region 공통코드 생성 / 항목명 확인
        private string getCommonCode(string _flag)
        {
            string sql = @"select max(PartInOutTypeID) from partinouttype where ClassFlag = " + _flag;

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            string id =  m.dbRonlyOne(sql, ref msg).ToString();

            if (msg == "OK" && id != null)
            {
                id = (Int32.Parse(id.Substring(1, id.Length - 1)) + 1).ToString();
                return id = _flag + id;
            }
            else
                return id = _flag + "1";

        }
        private bool isCommonItem(string _kind, string _item)
        {
            string sql = @"select ClassFlag from partinouttype where PartInOutTypeID = " + _kind + " and PartInOutTypeName = '" + _item + "'";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            object id = m.dbRonlyOne(sql, ref msg);

            if (msg == "OK" && id != null)
                return true;
            else
                return false;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
