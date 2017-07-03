using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace 款单打印2._0
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void combo1_Initialized(object sender, EventArgs e)
        {
         
            DataSet set = new DataSet();
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "select [SHOUKUAN] from [table]";
            OleDbDataAdapter oleadpter = new OleDbDataAdapter(sql, conn);
            oleadpter.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    this.combo1.Items.Add(set.Tables[0].Rows[i]["SHOUKUAN"].ToString());//需要转成String类型

                }
            }
            set.Reset();
            set.Clear();

        }

        private void drop_danwei(object sender,EventArgs e)
        {
            
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printdialog = new PrintDialog();
            if (printdialog.ShowDialog() == true)
            {
                printdialog.PrintVisual(gridsummary, "款单打印");
            }
        }

        private void Adddanwei_Click(object sender, RoutedEventArgs e)
        {
            //this.combo1.Items.Add(this.danweibox.Text);
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "insert into [table]([SHOUKUAN]) values("+ "'"+this.danweibox.Text+"'"+")";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            this.danweibox.Text = null;
            this.combo1.Items.Clear();
            this.combo1_Initialized(sender,e);
            MessageBox.Show("插入成功！");
            
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "delete from [table] where SHOUKUAN="+"'"+this.danweibox.Text+"'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            for(int i = 0; i < combo1.Items.Count; i++)
            {
                if (combo1.Items[i].ToString().Equals(this.danweibox.Text))
                {
                    this.danweibox.Text = null;
                    this.combo1.Items.Clear();
                    this.combo1_Initialized(sender, e);
                    return;
                }
            }          
            MessageBox.Show("删除失败！");
        }
        private void Addmoney(object sender,RoutedEventArgs e)
        {
            Double sum = 0.00;
            if (!this.money1.Text.Trim().Equals(""))
            {
                Double money1 = Double.Parse(this.money1.Text);
                sum += money1;
            }
            if (!this.money2.Text.Trim().Equals(""))
            {
                Double money2 = Double.Parse(this.money2.Text);
                sum += money2;
            }
            if (!this.money3.Text.Trim().Equals(""))
            {
                Double money3 = Double.Parse(this.money3.Text);
                sum += money3;
            }
            if (!this.money4.Text.Trim().Equals(""))
            {
                Double money4 = Double.Parse(this.money4.Text);
                sum += money4;
            }
            if (!this.money5.Text.Trim().Equals(""))
            {
                Double money5= Double.Parse(this.money5.Text);
                sum += money5;
            }
            if (!this.money6.Text.Trim().Equals(""))
            {
                Double money6 = Double.Parse(this.money6.Text);
                sum += money6;
            }
            if (!this.money7.Text.Trim().Equals(""))
            {
                Double money7 = Double.Parse(this.money7.Text);
                sum += money7;
            }
            if (!this.money8.Text.Trim().Equals(""))
            {
                Double money8 = Double.Parse(this.money8.Text);
                sum += money8;
            }
            if (!this.money9.Text.Trim().Equals(""))
            {
                Double money9 = Double.Parse(this.money9.Text);
                sum += money9;
            }

            this.zongji.Text = sum.ToString("f2");
        }
        //数据库连接
        private static OleDbConnection getConnect()
        {
            String exePath = System.Environment.CurrentDirectory;
            OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb");
            return conn;
        }

        //大写转换
        private void Daxiemoney(object sender,RoutedEventArgs e)
        {
           this.daxie.Text=new MoneyConvertChinese().MoneyToChinese(this.zongji.Text);
        }
    }

    /// <summary>
    /// 金额转为大写金额
    /// </summary>
    public class MoneyConvertChinese
    {
        /// <summary>
        /// 金额转为大写金额
        /// </summary>
        /// <param name="LowerMoney"></param>
        /// <returns></returns>
        public string MoneyToChinese(string LowerMoney)
        {
            string functionReturnValue = null;
            bool IsNegative = false; // 是否是负数
            if (LowerMoney.Trim().Substring(0, 1) == "-")
            {
                // 是负数则先转为正数
                LowerMoney = LowerMoney.Trim().Remove(0, 1);
                IsNegative = true;
            }
            string strLower = null;
            string strUpart = null;
            string strUpper = null;
            int iTemp = 0;
            // 保留两位小数 123.489→123.49　　123.4→123.4
            LowerMoney = Math.Round(double.Parse(LowerMoney), 2).ToString();
            if (LowerMoney.IndexOf(".") > 0)
            {
                if (LowerMoney.IndexOf(".") == LowerMoney.Length - 2)
                {
                    LowerMoney = LowerMoney + "0";
                }
            }
            else
            {
                LowerMoney = LowerMoney + ".00";
            }
            strLower = LowerMoney;
            iTemp = 1;
            strUpper = "";
            while (iTemp <= strLower.Length)
            {
                switch (strLower.Substring(strLower.Length - iTemp, 1))
                {
                    case ".":
                        strUpart = "元";
                        break;
                    case "0":
                        strUpart = "零";
                        break;
                    case "1":
                        strUpart = "壹";
                        break;
                    case "2":
                        strUpart = "贰";
                        break;
                    case "3":
                        strUpart = "叁";
                        break;
                    case "4":
                        strUpart = "肆";
                        break;
                    case "5":
                        strUpart = "伍";
                        break;
                    case "6":
                        strUpart = "陆";
                        break;
                    case "7":
                        strUpart = "柒";
                        break;
                    case "8":
                        strUpart = "捌";
                        break;
                    case "9":
                        strUpart = "玖";
                        break;
                }

                switch (iTemp)
                {
                    case 1:
                        strUpart = strUpart + "分";
                        break;
                    case 2:
                        strUpart = strUpart + "角";
                        break;
                    case 3:
                        strUpart = strUpart + "";
                        break;
                    case 4:
                        strUpart = strUpart + "";
                        break;
                    case 5:
                        strUpart = strUpart + "拾";
                        break;
                    case 6:
                        strUpart = strUpart + "佰";
                        break;
                    case 7:
                        strUpart = strUpart + "仟";
                        break;
                    case 8:
                        strUpart = strUpart + "万";
                        break;
                    case 9:
                        strUpart = strUpart + "拾";
                        break;
                    case 10:
                        strUpart = strUpart + "佰";
                        break;
                    case 11:
                        strUpart = strUpart + "仟";
                        break;
                    case 12:
                        strUpart = strUpart + "亿";
                        break;
                    case 13:
                        strUpart = strUpart + "拾";
                        break;
                    case 14:
                        strUpart = strUpart + "佰";
                        break;
                    case 15:
                        strUpart = strUpart + "仟";
                        break;
                    case 16:
                        strUpart = strUpart + "万";
                        break;
                    default:
                        strUpart = strUpart + "";
                        break;
                }

                strUpper = strUpart + strUpper;
                iTemp = iTemp + 1;
            }

            strUpper = strUpper.Replace("零拾", "零");
            strUpper = strUpper.Replace("零佰", "零");
            strUpper = strUpper.Replace("零仟", "零");
            strUpper = strUpper.Replace("零零零", "零");
            strUpper = strUpper.Replace("零零", "零");
            strUpper = strUpper.Replace("零角零分", "整");
            strUpper = strUpper.Replace("零分", "整");
            strUpper = strUpper.Replace("零角", "零");
            strUpper = strUpper.Replace("零亿零万零圆", "亿圆");
            strUpper = strUpper.Replace("亿零万零圆", "亿圆");
            strUpper = strUpper.Replace("零亿零万", "亿");
            strUpper = strUpper.Replace("零万零圆", "万圆");
            strUpper = strUpper.Replace("零亿", "亿");
            strUpper = strUpper.Replace("零万", "万");
            strUpper = strUpper.Replace("零圆", "圆");
            strUpper = strUpper.Replace("零零", "零");

            // 对壹圆以下的金额的处理
            if (strUpper.Substring(0, 1) == "圆")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "零")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "角")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "分")
            {
                strUpper = strUpper.Substring(1, strUpper.Length - 1);
            }
            if (strUpper.Substring(0, 1) == "整")
            {
                strUpper = "零圆整";
            }
            functionReturnValue = strUpper;

            if (IsNegative == true)
            {
                return "负" + functionReturnValue;
            }
            else
            {
                return functionReturnValue;
            }
        }
    }
}
