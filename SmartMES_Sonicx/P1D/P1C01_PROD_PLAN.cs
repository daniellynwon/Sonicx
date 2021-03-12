using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartMES_Sonicx
{
    public partial class P1C01_PROD_PLAN : SmartMES_Sonicx.FormBasic
    {
        public P1C01_PROD_PLAN()
        {
            InitializeComponent();
        }

        private void P1C01_PROD_PLAN_Load(object sender, EventArgs e)
        {
            lbModel.Text = "";
            tbYM.Text = DateTime.Today.ToString("yyyy년 MM월");
            lblM.Text = DateTime.Today.ToString("M월");

            CalendarMade(tbYM.Text);
        }

        public void CalendarMade(string _date)
        {
            Cursor.Current = Cursors.WaitCursor;

            DateTime dtFromDate = DateTime.Parse(_date.Substring(0, 4) + "-" + _date.Substring(6, 2) + "-01");
            DateTime dtToDate = dtFromDate.AddMonths(1).AddDays(-1);

            int[] array = Enumerable.Repeat<int>(0, 37).ToArray<int>();

            int iStart = Int32.Parse(dtFromDate.DayOfWeek.ToString("d"));
            int iDay = 0;

            for (int i = iStart; i < (dtToDate.Day + iStart); i++)
            {
                iDay++;
                array[i] = iDay;
            }

            //

            Label lbD, lbJ, lbY, lbJU, lbYA, lbS;
            string workDate;

            string sProd = "%";
            if (!(tbProd.Tag == null || string.IsNullOrEmpty(tbProd.Tag.ToString())))
                sProd = tbProd.Tag.ToString();

            string sql;
            string msg = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                lbD = this.Controls.Find("lbDay" + i.ToString(), true).FirstOrDefault() as Label;
                lbJ = this.Controls.Find("lbJ" + i.ToString(), true).FirstOrDefault() as Label;
                lbY = this.Controls.Find("lbY" + i.ToString(), true).FirstOrDefault() as Label;
                lbJU = this.Controls.Find("lbJU" + i.ToString(), true).FirstOrDefault() as Label;
                lbYA = this.Controls.Find("lbYA" + i.ToString(), true).FirstOrDefault() as Label;
                lbS = this.Controls.Find("lbScript" + i.ToString(), true).FirstOrDefault() as Label;

                if (array[i] == 0)
                {
                    lbD.Text = string.Empty;
                    lbJ.Text = string.Empty;
                    lbY.Text = string.Empty;
                    lbJU.Text = string.Empty;
                    lbYA.Text = string.Empty;
                    lbS.Text = string.Empty;
                }
                else
                {
                    lbD.Text = array[i].ToString();
                    workDate = dtFromDate.ToString("yyyy-MM") + "-" + array[i].ToString("00");

                    sql = @"SELECT Sum(pp.SaleQty), Sum(pp.ProdQty), if('" + sProd + "' = '%', '',Max(pp.Contents)) FROM productionplan pp WHERE pp.PlanDate = '" + workDate + "' AND CONCAT(pp.ProductID) LIKE '" + sProd + "'";
                    
                    MariaCRUD m = new MariaCRUD();
                    DataTable table = m.dbDataTable(sql, ref msg);

                    lbJ.Text = string.Empty;
                    lbY.Text = string.Empty;
                    lbJU.Text = string.Empty;
                    lbYA.Text = string.Empty;
                    lbS.Text = string.Empty;

                    if (msg == "OK")
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            lbJ.Text = "판매";
                            lbY.Text = "생산";
                            lbJU.Text = row[0].ToString();
                            lbYA.Text = row[1].ToString();
                            lbS.Text = row[2].ToString();
                        }
                    }
                }
            }

            Cursor.Current = Cursors.Default;
        }

        #region Condition Bar Events
        private void lblProd_Click(object sender, EventArgs e)
        {
            ProdFinder pop = new ProdFinder();
            pop.cbGubun.Text = "A.제품";
            pop.FormSendEvent += new ProdFinder.FormSendDataHandler(ProdEventMethod);
            pop.ShowDialog();
        }
        private void ProdEventMethod(object sender)
        {
            string sProd = sender.ToString();
            if (string.IsNullOrEmpty(sProd)) return;

            tbProd.Tag = sProd.Substring(0, sProd.IndexOf("#1/"));
            tbProd.Text = sProd.Substring(sProd.IndexOf("#2/") + 3, sProd.IndexOf("#3/") - (sProd.IndexOf("#2/") + 3));
            lbModel.Text = sProd.Substring(sProd.IndexOf("#3/") + 3, sProd.Length - (sProd.IndexOf("#3/") + 3));

            CalendarMade(tbYM.Text);
        }
        private void pbProdDel_Click(object sender, EventArgs e)
        {
            tbProd.Tag = null;
            tbProd.Text = "";
            lbModel.Text = "";

            CalendarMade(tbYM.Text);
        }
        private void ubtnLeft_Click(object sender, EventArgs e)
        {
            tbYM.Text = DateTime.Parse(tbYM.Text.Substring(0, 4) + "-" + tbYM.Text.Substring(6, 2) + "-01").AddMonths(-1).ToString("yyyy년 MM월");
            lblM.Text = Int32.Parse(tbYM.Text.Substring(6, 2)).ToString() + "월";

            CalendarMade(tbYM.Text);
        }
        private void ubtnRight_Click(object sender, EventArgs e)
        {
            tbYM.Text = DateTime.Parse(tbYM.Text.Substring(0, 4) + "-" + tbYM.Text.Substring(6, 2) + "-01").AddMonths(1).ToString("yyyy년 MM월");
            lblM.Text = Int32.Parse(tbYM.Text.Substring(6, 2)).ToString() + "월";

            CalendarMade(tbYM.Text);
        }
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            CalendarMade(tbYM.Text);
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

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            if (tbProd.Tag == null || string.IsNullOrEmpty(tbProd.Tag.ToString()))
            {
                MessageBox.Show("제품명을 선택해 주세요.");
                return;
            }

            Panel p = (Panel)sender;

            Label lbD = this.Controls.Find("lbDay" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;

            if (string.IsNullOrEmpty(lbD.Text)) return;

            Label lbJ = this.Controls.Find("lbJU" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;
            Label lbY = this.Controls.Find("lbYA" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;
            Label lbS = this.Controls.Find("lbScript" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;

            //

            P1C01_PROD_PLAN_SUB sub = new P1C01_PROD_PLAN_SUB();
            sub.parentWin = this;

            sub.tbPlanDate.Text = tbYM.Text.Substring(0, 4) + "-" + tbYM.Text.Substring(6, 2) + "-" + Int32.Parse(lbD.Text).ToString("00");
            sub.tbProduct.Tag = tbProd.Tag;
            sub.tbProduct.Text = tbProd.Text;
            sub.tbModel.Text = lbModel.Text;
            if (lbJ.Text != "0") sub.tbSaleQty.Text = lbJ.Text;
            if (lbY.Text != "0") sub.tbProdQty.Text = lbY.Text;
            sub.tbContents.Text = lbS.Text;

            sub.ShowDialog();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (tbProd.Tag == null || string.IsNullOrEmpty(tbProd.Tag.ToString()))
            {
                return;
            }

            if ((Control.ModifierKeys & Keys.Control) != 0)
            {
                Panel p = (Panel)sender;

                Label lbD = this.Controls.Find("lbDay" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;

                if (string.IsNullOrEmpty(lbD.Text)) return;

                string sDate = tbYM.Text.Substring(0, 4) + "-" + tbYM.Text.Substring(6, 2) + "-" + Int32.Parse(lbD.Text).ToString("00");
                sDate = sDate + p.Name.Substring(1, p.Name.Length - 1);

                DoDragDrop(sDate, DragDropEffects.Copy);
            }
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (tbProd.Tag == null || string.IsNullOrEmpty(tbProd.Tag.ToString()))
            {
                return;
            }

            if (e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            if (tbProd.Tag == null || string.IsNullOrEmpty(tbProd.Tag.ToString()))
            {
                return;
            }

            Panel p = (Panel)sender;

            Label lbD = this.Controls.Find("lbDay" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;
            
            if (string.IsNullOrEmpty(lbD.Text))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            string sScrDate = (string)e.Data.GetData(DataFormats.StringFormat);
            string sScrNo = sScrDate.Substring(10, sScrDate.Length-10);
            sScrDate = sScrDate.Substring(0, 10);
            string sTrkDate = tbYM.Text.Substring(0, 4) + "-" + tbYM.Text.Substring(6, 2) + "-" + Int32.Parse(lbD.Text).ToString("00");
            string sProd = tbProd.Tag.ToString();

            Label lbJ = this.Controls.Find("lbJU" + sScrNo, true).FirstOrDefault() as Label;
            Label lbY = this.Controls.Find("lbYA" + sScrNo, true).FirstOrDefault() as Label;
            Label lbS = this.Controls.Find("lbScript" + sScrNo, true).FirstOrDefault() as Label;
            string sJ = lbJ.Text;
            string sY = lbY.Text;
            string sS = lbS.Text;
            if (sJ == null || string.IsNullOrEmpty(sJ)) sJ = "0";
            if (sY == null || string.IsNullOrEmpty(sY)) sY = "0";

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (DateTime.Parse(sScrDate) < DateTime.Parse(sTrkDate))
            {
                for (int i = 0; i < Int32.Parse(lbD.Text) - DateTime.Parse(sScrDate).Day; i++)
                {
                    sql = "insert into productionplan(PlanDate, ProductID, SaleQty, ProdQty, Contents)" +
                    " values('" + sTrkDate + "', " + sProd + ", " + sJ + ", " + sY + ", '" + sS + "')" +
                    " on duplicate key update" +
                    " SaleQty = " + sJ + ", ProdQty = " + sY + ", Contents = '" + sS + "'";

                    m.dbCUD(sql, ref msg);

                    sTrkDate = DateTime.Parse(sTrkDate).AddDays(-1).ToString("yyyy-MM-dd");
                }
            }
            else
            {
                sql = "insert into productionplan(PlanDate, ProductID, SaleQty, ProdQty, Contents)" +
                    " values('" + sTrkDate + "', " + sProd + ", " + sJ + ", " + sY + ", '" + sS + "')" +
                    " on duplicate key update" +
                    " SaleQty = " + sJ + ", ProdQty = " + sY + ", Contents = '" + sS + "'";

                m.dbCUD(sql, ref msg);
            }

            CalendarMade(tbYM.Text);
        }
    }
}
