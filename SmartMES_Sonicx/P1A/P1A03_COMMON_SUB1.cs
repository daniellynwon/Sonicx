using System;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1A03_COMMON_SUB1 : Form
    {
        public P1A03_COMMON parentWin;
        private int rowIndex = 0;

        public P1A03_COMMON_SUB1()
        {
            InitializeComponent();
        }

        private void P1A03_COMMON_SUB1_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                this.ActiveControl = tbType;
            }
            else
            {
                rowIndex = parentWin.dataGridViewB.CurrentCell.RowIndex;

                tbKind.Text = parentWin.dataGridViewB.Rows[rowIndex].Cells[1].Value.ToString();
                tbType.Text = parentWin.dataGridViewB.Rows[rowIndex].Cells[2].Value.ToString();
                tbConts.Text = parentWin.dataGridViewB.Rows[rowIndex].Cells[3].Value.ToString();

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
            string sType = tbType.Text.Trim();

            if (String.IsNullOrEmpty(sType))
            {
                lblMsg.Text = "불량항목을 입력해 주세요.";
                tbType.Focus();
                return;
            }
            string sConts = tbConts.Text.Trim();

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                //입력한 불량항목이 중복인지 확인..
                if (isCommonItem(sType))
                {
                    lblMsg.Text = "이미 존재하는 항목입니다.";
                    tbType.Focus();
                    return;
                }

                sql = "insert into defecttype (DefectID, DefectName, Remark) " +
                    "values(null, '" + sType + "','" + sConts + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                lblMsg.Text = "저장되었습니다.";

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridViewB.Rows.Count; i++)
                {
                    if (parentWin.dataGridViewB.Rows[i].Cells[1].Value.ToString() == sType)
                    {
                        parentWin.dataGridViewB.CurrentCell = parentWin.dataGridViewB[0, i];
                        parentWin.dataGridViewB.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbKind.Text = string.Empty;
                tbType.Text = string.Empty;
                tbConts.Text = string.Empty;
                tbType.Focus();
            }
            else
            {
                sql = "update defecttype " +
                    "set DefectName = '" + sType + "', Remark = '" + sConts + "'" +
                    " where DefectID = " + sKind;

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, tbType.Text + " " + sKind);

                parentWin.ListSearch();
                parentWin.dataGridViewB.CurrentCell = parentWin.dataGridViewB[0, rowIndex];
                parentWin.dataGridViewB.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region 공통코드 생성 / 항목명 확인
        private bool isCommonItem(string _item)
        {
            string sql = @"select DefectName from defecttype where DefectName = '" + _item + "'";

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
