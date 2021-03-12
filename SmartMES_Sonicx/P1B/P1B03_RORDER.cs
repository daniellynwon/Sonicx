using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1B03_RORDER : SmartMES_Sonicx.FormBasic
    {
        int columnIndex = 0;
        int rowIndex = 0;
        bool endEdit = false;

        public P1B03_RORDER()
        {
            InitializeComponent();
        }
        private void P1B03_RORDER_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT Transport FROM contract GROUP BY Transport";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbInstall.DataSource = table;
                cbInstall.ValueMember = "Transport";
                cbInstall.DisplayMember = "Transport";
            }

            sql = @"SELECT Purpose from contract GROUP BY Purpose";
            m = new MariaCRUD();
            msg = string.Empty;
            table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbUse.DataSource = table;
                cbUse.ValueMember = "Purpose";
                cbUse.DisplayMember = "Purpose";
            }

            ListSearch1();
        }
        public void ListSearch1()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sSearch = tbSearch.Text.Trim();

                sPW_ROrderMain_QueryTableAdapter.Fill(dataSetP1B.SPW_ROrderMain_Query, sSearch);

                dataGridViewList.CurrentCell = null;
                dataGridViewList.ClearSelection();
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
        public void ListSearch2(int rowIndex)
        {
            Cursor.Current = Cursors.WaitCursor;
            lblMsg.Text = "";

            cbNo.Checked = false;
            tbNo.Text = dataGridViewList.Rows[rowIndex].Cells[0].Value.ToString();
            tbCust.Tag = dataGridViewList.Rows[rowIndex].Cells[1].Value.ToString();
            tbCust.Text = dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString();
            tbStaff.Text = dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString();
            tbLoc.Text = dataGridViewList.Rows[rowIndex].Cells[5].Value.ToString();
            dtpDate.Value = DateTime.Parse(dataGridViewList.Rows[rowIndex].Cells[7].Value.ToString());
            dtpDeliDate.Value = DateTime.Parse(dataGridViewList.Rows[rowIndex].Cells[8].Value.ToString());
            cbUse.Text = dataGridViewList.Rows[rowIndex].Cells[10].Value.ToString();
            cbInstall.Text = dataGridViewList.Rows[rowIndex].Cells[11].Value.ToString();
            tbContents.Text = dataGridViewList.Rows[rowIndex].Cells[12].Value.ToString();

            Cursor.Current = Cursors.Default;
        }
        public void ListSearch3()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sNo = tbNo.Text;

                sPW_ROrderSub_QueryTableAdapter.Fill(dataSetP1B.SPW_ROrderSub_Query, sNo);

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
        public void ListSearch4()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                int iCnt = 0;
                long lSum = 0;
                string sMoney;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value != null) iCnt++;   // 품목ID가 null이 아니면,

                    if (dataGridView1.Rows[i].Cells[16].Value == null ||
                        string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[15].Value.ToString())) // 금액이 null이면,
                        sMoney = "0";
                    else
                        sMoney = dataGridView1.Rows[i].Cells[16].Value.ToString();  // 금액 있으면,

                    lSum += long.Parse(sMoney); // lSum은 금액의 합
                }

                lblSumMoney.Text = "합계금액 : " + lSum.ToString("#,##0") + "원";
                lblCnt.Text = iCnt.ToString() + "건";
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
        public void ListInit()
        {
            lblMsg.Text = "";

            cbNo.Checked = false;
            tbNo.Text = string.Empty;
            dtpDate.Value = DateTime.Today;
            tbCust.Tag = string.Empty;
            tbCust.Text = string.Empty;
            tbLoc.Text = string.Empty;
            tbStaff.Text = string.Empty;
            //cbInstall.Text = string.Empty;
            //cbUse.Text = string.Empty;
            //dtpDeliDate.Value = DateTime.Today; 
            tbContents.Text = string.Empty;

            sPW_ROrderSub_QueryTableAdapter.Fill(dataSetP1B.SPW_ROrderSub_Query, "");

            lblSumMoney.Text = "합계금액 : 0원";
            lblCnt.Text = "0건";
        }

        #region Controls Event
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch1();
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (!cbNo.Checked)
            {
                lblMsg.Text = "복사할 수주번호를 체크해 주세요.";
                return;
            }

            string sNo = tbNo.Text;

            if (string.IsNullOrEmpty(sNo))
            {
                lblMsg.Text = "저장된 수주번호만 복사할 수 있습니다.";
                return;
            }

            DialogResult dr = MessageBox.Show("수주번호 : " + sNo + "\r\r해당 수주정보를 새로운 수주번호로 복사하시겠습니까?", this.lblTitle.Text + "[수주복사]", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            sql = "insert into contract (ContractID, CustomerID, CustomerStaff, ROrderDate, RequestDate, Stage, Purpose, Transport, Remark) " +
                  "select null, CustomerID, CustomerStaff, CURDATE(), CURDATE(), Stage, Purpose, Transport, Remark " +
                  "from contract " +
                  "where ContractID = " + sNo;

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }

            sql = "insert into contractsub (SContractID, ContractID, ProductID, Unit, Qty, UnitPrice, Amount, Addition, EnterQty, Certify, Color, SelOption) " +
                  "select null, " + getContractID() + ", ProductID, Unit, Qty, UnitPrice, Amount, Addition, EnterQty, Certify, Color, SelOption " +
                  "from contractsub " +
                  "where ContractID = " + sNo +
                  " order by SContractID";

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }

            tbSearch.Text = "";
            ListSearch1();

            for (int i = 0; i < dataGridViewList.Rows.Count; i++)
            {
                if (dataGridViewList.Rows[i].Cells[0].Value.ToString() == getContractID())
                {
                    dataGridViewList.CurrentCell = dataGridViewList[2, i];
                    dataGridViewList.CurrentCell.Selected = true;

                    ListSearch2(i);
                    ListSearch3();
                    ListSearch4();
                    break;
                }
            }

            lblMsg.Text = "복사되었습니다.";
        }        
        private void lblCust_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            CustFinder sub = new CustFinder();
            sub.FormSendEvent += new CustFinder.FormSendDataHandler(PostEventMethod);
            sub._gubun = "1"; //매출처1, 매입처2
            sub.ShowDialog();
        }
        private void PostEventMethod(object sender)
        {
            string sCust = sender.ToString();

            if (string.IsNullOrEmpty(sCust)) return;

            tbCust.Tag = Int32.Parse(sCust.Substring(0, 5)).ToString();
            tbCust.Text = sCust.Substring(5, sCust.Length - 5);
            tbLoc.Focus();
        }
        #endregion

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

        #region GridView Events
        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int index = dataGridViewList.CurrentRow.Index;

            ListSearch2(index);
            ListSearch3();
            ListSearch4();
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;

                    //if (columnIndex == dataGridView1.Columns.Count - 1)
                    if (columnIndex == 16)  // 마지막 Column이면 밑으로 내려가게
                        dataGridView1.CurrentCell = dataGridView1[4, rowIndex + 1];
                    else
                        dataGridView1.CurrentCell = dataGridView1[columnIndex + 1, rowIndex];
                }
                if (e.KeyCode == Keys.Tab)
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                rowIndex = dataGridView1.CurrentCell.RowIndex;
                endEdit = true;

                float money1 = 0;
                float money2 = 0;
                long moneyA = 0;
                long moneyB = 0;

                if (columnIndex == 14 || columnIndex == 15)       // 수량, 단가
                {
                    if (dataGridView1.Rows[rowIndex].Cells[14].Value != null &&
                        dataGridView1.Rows[rowIndex].Cells[14].Value.ToString().Length != 0)
                        money1 = float.Parse(dataGridView1.Rows[rowIndex].Cells[14].Value.ToString());

                    if (dataGridView1.Rows[rowIndex].Cells[15].Value != null &&
                        dataGridView1.Rows[rowIndex].Cells[15].Value.ToString().Length != 0)
                        money2 = float.Parse(dataGridView1.Rows[rowIndex].Cells[15].Value.ToString());

                    moneyA = (long)(money1 * money2);
                    dataGridView1.Rows[rowIndex].Cells[16].Value = moneyA;

                    ListSearch4();
                }
            }
            catch(Exception)
            {
                return;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMsg.Text = "";
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0) //"품목"
            {
                ProdFinder pop = new ProdFinder();
                pop.cbGubun.Text = "A.제품";
                pop.FormSendEvent += new ProdFinder.FormSendDataHandler(ProdEventMethod);
                pop.ShowDialog();
            }
            else if (e.ColumnIndex == 19) //"X"
            {
                try
                {
                    if(dataGridView1.RowCount <= 2)
                    {
                        lblMsg.Text = "수주번호 전체를 삭제하세요.";
                        return;
                    }

                    string sNo = tbNo.Text;

                    if (string.IsNullOrEmpty(sNo))
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                        return;
                    }

                    if (dataGridView1.Rows[e.RowIndex].Cells[1].Value == null ||
                        string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()))
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                        return;
                    }

                    string sSeq = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string sName = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                    DialogResult dr = MessageBox.Show("품목명: " + sName + "\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.No) return;

                    MariaCRUD m = new MariaCRUD();
                    string sql = "delete from contractsub where SContractID = " + sSeq;
                    string msg = string.Empty;
                    m.dbCUD(sql, ref msg);

                    if (msg != "OK")
                    {
                        MessageBox.Show(msg);
                        return;
                    }

                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                    m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sNo + " " + sSeq);
                }
                catch (Exception)
                {
                    return;
                }
            }

            ListSearch4();
        }
        private void ProdEventMethod(object sender)
        {
            try
            {
                string sProd = sender.ToString();
                if (string.IsNullOrEmpty(sProd)) return;

                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex < 0) return;

                dataGridView1.Rows[rowIndex].Cells[3].Value = sProd.Substring(0, sProd.IndexOf("#1/")); //품목ID
                dataGridView1.Rows[rowIndex].Cells[4].Value = sProd.Substring(sProd.IndexOf("#1/") + 3, sProd.IndexOf("#2/") - (sProd.IndexOf("#1/") + 3)); //품목코드
                dataGridView1.Rows[rowIndex].Cells[5].Value = sProd.Substring(sProd.IndexOf("#2/") + 3, sProd.IndexOf("#3/") - (sProd.IndexOf("#2/") + 3)); //품목명
                dataGridView1.Rows[rowIndex].Cells[7].Value = sProd.Substring(sProd.IndexOf("#3/") + 3, sProd.Length - (sProd.IndexOf("#3/") + 3)); //모델명
                dataGridView1.CurrentCell = dataGridView1[11, rowIndex];

            }
            catch(Exception)
            {
                return;
            }
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.RowCount < 2) return;

            long lCost1 = 0;
            long lCost2 = 0;
            long lAmount = 0;

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    lCost1 = Convert.ToInt64(row.Cells[14].Value);
                    lCost2 = Convert.ToInt64(row.Cells[15].Value);
                    lAmount = Convert.ToInt64(row.Cells[16].Value);

                    if ((lCost1 * lCost2) == lAmount)
                        row.Cells[16].Style.ForeColor = Color.Empty;
                    else
                        row.Cells[16].Style.ForeColor = Color.Red;
                }

                ListSearch4();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch1();

            string sNo = tbNo.Text;
            if (string.IsNullOrEmpty(sNo))
            {
                ListInit();
            }
            else
            {
                for (int i = 0; i < dataGridViewList.Rows.Count; i++)
                {
                    if (dataGridViewList.Rows[i].Cells[0].Value.ToString() == sNo)
                    {
                        dataGridViewList.CurrentCell = dataGridViewList[2, i];
                        dataGridViewList.CurrentCell.Selected = true;

                        ListSearch2(i);
                        ListSearch3();
                        ListSearch4();
                        break;
                    }
                }
            }
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            ListSearch1();
            ListInit();
        }
        private void pbDel_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (!cbNo.Checked)
            {
                lblMsg.Text = "삭제할 수주번호를 체크해 주세요.";
                return;
            }

            string sNo = tbNo.Text;

            if (string.IsNullOrEmpty(sNo))
            {
                lblMsg.Text = "저장된 수주번호만 삭제할 수 있습니다.";
                return;
            }

            DialogResult dr = MessageBox.Show("수주번호 : " + sNo + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from contractsub where ContractID = " + sNo;
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }

            sql = "delete from contract where ContractID = " + sNo;
            m = new MariaCRUD();
            msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }

            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sNo + " " + tbCust.Text);

            ListSearch1();
            ListInit();
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            dataGridView1.CurrentCell = dataGridView1[4, 0];
            lblMsg.Text = "";

            if (tbCust.Tag == null || string.IsNullOrEmpty(tbCust.Tag.ToString()))
            {
                lblMsg.Text = "거래처명을 선택해 주세요.";
                lblCust.Focus();
                return;
            }

            int iCnt = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (!(dataGridView1.Rows[i].Cells[3].Value == null ||
                    string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString()))) iCnt++;
            }

            if (iCnt == 0)
            {
                lblMsg.Text = "품목정보를 확인해 주세요.";
                dataGridView1.Focus();
                return;
            }

            string sNo = tbNo.Text;
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sCust = tbCust.Tag.ToString();
            string sLoc = tbLoc.Text.Trim();
            string sStaff = tbStaff.Text.Trim();
            string sDeliDate = dtpDeliDate.Value.ToString("yyyy-MM-dd");
            string sPurpose = cbUse.Text.Trim();
            string sInstall = cbInstall.Text.Trim();
            string sContents = tbContents.Text.Trim();

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sSeq = string.Empty;
            string sProdID = string.Empty;
            string sCertify = string.Empty;
            string sOption = string.Empty;
            string sColor = string.Empty;
            string sQty = string.Empty;
            string sDanga = string.Empty;
            string sAmount = string.Empty;
            string sAddition = string.Empty;

            if (string.IsNullOrEmpty(sNo)) //추가
            {
                sql = "insert into contract (ContractID, CustomerID, CustomerStaff, DeliverAddr, ROrderDate, RequestDate, Stage, Purpose, Transport, Remark ) " +
                    "values(null," + sCust + ",'" + sStaff + "','" + sLoc + "','" + sDate + "','" + sDeliDate + "', '출하대기','" + sPurpose + "','" + sInstall + "','" + sContents + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }

                sNo = getContractID();
                tbNo.Text = sNo;

                int seq = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value == null ||
                        string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString())) continue;

                    sProdID = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
                    sQty = dataGridView1.Rows[i].Cells[14].Value.ToString().Trim();
                    sDanga = dataGridView1.Rows[i].Cells[15].Value.ToString().Trim();
                    sAmount = dataGridView1.Rows[i].Cells[16].Value.ToString().Trim();
                    sAddition = dataGridView1.Rows[i].Cells[17].Value.ToString().Trim();
                    sCertify = dataGridView1.Rows[i].Cells[11].Value.ToString().Trim();
                    sColor = dataGridView1.Rows[i].Cells[13].Value.ToString().Trim();
                    sOption = dataGridView1.Rows[i].Cells[12].Value.ToString().Trim();

                    if (string.IsNullOrEmpty(sQty)) sQty = "0";
                    if (string.IsNullOrEmpty(sDanga)) sDanga = "0";
                    if (string.IsNullOrEmpty(sAmount)) sAmount = "0";

                    sql = "insert into contractsub (SContractID, ContractID, ProductID, Qty, UnitPrice, Amount, Addition, Certify, Color, SelOption) " +
                          "values(null," + sNo + "," + sProdID + "," + sQty + "," + sDanga + "," + sAmount + ",'" + sAddition + "','" + sCertify + "','" + sColor + "','" + sOption + "')";

                    m.dbCUD(sql, ref msg);
                }
            }
            else //수정
            {
                sql = "update contract " +
                    "set CustomerID = " + sCust + ", CustomerStaff = '" + sStaff + "', DeliverAddr = '" + sLoc + "', ROrderDate = '" + sDate + "', RequestDate = '" + sDeliDate + "', Purpose = '" + sPurpose + "', Transport = '" + sInstall + "', Remark = '" + sContents + "'" +
                    " where ContractID = '" + sNo + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value == null ||
                        string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString())) continue;

                    if (!(dataGridView1.Rows[i].Cells[2].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString())))
                    {
                        sSeq = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
                    }
                    else sSeq = "null";
                    sProdID = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
                    sQty = dataGridView1.Rows[i].Cells[14].Value.ToString().Trim();
                    sDanga = dataGridView1.Rows[i].Cells[15].Value.ToString().Trim();
                    sAmount = dataGridView1.Rows[i].Cells[16].Value.ToString().Trim();
                    sAddition = dataGridView1.Rows[i].Cells[17].Value.ToString().Trim();
                    sCertify = dataGridView1.Rows[i].Cells[11].Value.ToString().Trim();
                    sColor = dataGridView1.Rows[i].Cells[13].Value.ToString().Trim();
                    sOption = dataGridView1.Rows[i].Cells[12].Value.ToString().Trim();

                    if (string.IsNullOrEmpty(sQty)) sQty = "0";
                    if (string.IsNullOrEmpty(sDanga)) sDanga = "0";
                    if (string.IsNullOrEmpty(sAmount)) sAmount = "0";

                    sql = "insert into contractsub (SContractID, ContractID, ProductID, Qty, UnitPrice, Amount, Addition, Certify, Color, SelOption) " +
                          "values(" + sSeq + "," + sNo + "," + sProdID + "," + sQty + "," + sDanga + "," + sAmount + ",'" + sAddition + "','" + sCertify + "','" + sColor + "','" + sOption + "')" +
                        " on duplicate key update" +
                        " ProductID = " + sProdID + ", Qty = " + sQty + ", UnitPrice = " + sDanga + ", Amount = " + sAmount + ", Addition = '" + sAddition + "', Certify = '" + sCertify + "', Color = '" + sColor + "', SelOption = '" + sOption + "'";

                    m.dbCUD(sql, ref msg);
                }
            }

            tbSearch.Text = "";
            ListSearch1();

            for (int i = 0; i < dataGridViewList.Rows.Count; i++)
            {
                if (dataGridViewList.Rows[i].Cells[0].Value.ToString() == sNo)
                {
                    dataGridViewList.CurrentCell = dataGridViewList[2, i];
                    dataGridViewList.CurrentCell.Selected = true;

                    ListSearch2(i);
                    ListSearch3();
                    ListSearch4();
                    break;
                }
            }

            m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, sNo + "-" + tbCust.Text);
            lblMsg.Text = "저장되었습니다.";
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            //
        }
        #endregion

        #region 수주번호 생성
        private string getContractID()
        {
            string sql = @"select max(ContractID) from contract";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        #endregion

    }
}
