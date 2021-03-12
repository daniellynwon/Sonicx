using System;
using System.Data;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1A03_COMMON_SUB2 : Form
    {
        public P1A03_COMMON parentWin;
        private int rowIndex = 0;
        public P1A03_COMMON_SUB2()
        {
            InitializeComponent();
        }
        private void P1A03_COMMON_SUB2_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string sql = @"SELECT DefectID, DefectName FROM defecttype ORDER BY DefectID";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbKind.DataSource = table;
                cbKind.ValueMember = "DefectID";
                cbKind.DisplayMember = "DefectName";
            }

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                this.ActiveControl = cbKind;
                cbKind.SelectedIndex = 0;
            }
            else
            {
                rowIndex = parentWin.dataGridViewC.CurrentCell.RowIndex;

                tbKind.Text = parentWin.dataGridViewC.Rows[rowIndex].Cells[1].Value.ToString();
                cbKind.SelectedValue = parentWin.dataGridViewC.Rows[rowIndex].Cells[2].Value;
                tbDetail.Text = parentWin.dataGridViewC.Rows[rowIndex].Cells[3].Value.ToString();

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

            string sDetailID = tbKind.Text.Trim();
            string sKind = cbKind.SelectedValue.ToString();
            string sDetail = tbDetail.Text.Trim();
            string sDate = DateTime.Now.ToString("yyyy-MM-dd");

            if (String.IsNullOrEmpty(sDetail))
            {
                lblMsg.Text = "불량항목을 입력해 주세요.";
                tbDetail.Focus();
                return;
            }
            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                //입력한 불량항목이 중복인지 확인..
                if (isCommonItem(sDetail, sKind))
                {
                    lblMsg.Text = "이미 존재하는 항목입니다.";
                    tbDetail.Focus();
                    return;
                }

                sql = "insert into defectdetail (DetailID, DefectID, DetailName, RegDate) " +
                    "values(null, " + sKind + ",'" + sDetail + "','" + sDate + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                lblMsg.Text = "저장되었습니다.";

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridViewC.Rows.Count; i++)
                {
                    if (parentWin.dataGridViewC.Rows[i].Cells[1].Value.ToString() == sKind)
                    {
                        parentWin.dataGridViewC.CurrentCell = parentWin.dataGridViewC[0, i];
                        parentWin.dataGridViewC.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbKind.Text = string.Empty;
                cbKind.SelectedValue = 0;
                tbDetail.Text = string.Empty;
                cbKind.Focus();
            }
            else
            {
                sql = "update defectdetail " +
                    "set DefectID = " + sKind + ", DefectName = '" + sDetail + "'" +
                    " where DetailID = " + sDetailID;

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, tbKind.Text + " " + sKind);

                parentWin.ListSearch();
                parentWin.dataGridViewC.CurrentCell = parentWin.dataGridViewC[0, rowIndex];
                parentWin.dataGridViewC.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region 공통코드 생성 / 항목명 확인
        private bool isCommonItem(string _detail, string _defect)
        {
            string sql = @"select DefectName from defectdetail where DetailID = " + _detail + " and DefectID = " + _defect;

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
