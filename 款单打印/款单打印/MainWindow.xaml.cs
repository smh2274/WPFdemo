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
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace 款单打印
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //打印功能
        private void Print_Click(object sender, RoutedEventArgs e)
        {
            this.comboBox.Visibility = System.Windows.Visibility.Hidden;
            this.comboBox1.Visibility = System.Windows.Visibility.Hidden;
            this.comboBox2.Visibility = System.Windows.Visibility.Hidden;
            this.comboBox3.Visibility = System.Windows.Visibility.Hidden;
            this.comboBox4.Visibility = System.Windows.Visibility.Hidden;
            this.comboBox5.Visibility = System.Windows.Visibility.Hidden;
            this.comboBox6.Visibility = System.Windows.Visibility.Hidden;
            this.comboBox7.Visibility = System.Windows.Visibility.Hidden;
            this.comboBox8.Visibility = System.Windows.Visibility.Hidden;
            this.comboBox9.Visibility = System.Windows.Visibility.Hidden;
            PrintDialog print = new PrintDialog();
            if (print.ShowDialog() == true)
            {
                print.PrintVisual(GridSummary, "款单打印");
            }
            this.comboBox.Visibility = System.Windows.Visibility.Visible;
            this.comboBox1.Visibility = System.Windows.Visibility.Visible;
            this.comboBox2.Visibility = System.Windows.Visibility.Visible;
            this.comboBox3.Visibility = System.Windows.Visibility.Visible;
            this.comboBox4.Visibility = System.Windows.Visibility.Visible;
            this.comboBox5.Visibility = System.Windows.Visibility.Visible;
            this.comboBox6.Visibility = System.Windows.Visibility.Visible;
            this.comboBox7.Visibility = System.Windows.Visibility.Visible;
            this.comboBox8.Visibility = System.Windows.Visibility.Visible;
            this.comboBox9.Visibility = System.Windows.Visibility.Visible;
        }
        private void changeSize(object sender,EventArgs e)
        {
            if (this.textBox2.Text.Length < 17)
            {
                //textBox2.Font= new Font(textBox2.Font.FontFamily, 12, textBox2.Font.Style);
                this.textBox2.FontSize = 14;
            }
            else
            {
                this.textBox2.FontSize = 12;
            }
        }
        //
        private void getSummary(object sender, EventArgs e)
        {
            textBox2.Text = this.comboBox.Text;
        }
        private void get1(object sender, EventArgs e)
        {
            textmoney1.Text = this.comboBox1.Text;
        }
        private void get2(object sender, EventArgs e)
        {
            textmoney2.Text = this.comboBox2.Text;
        }
        private void get3(object sender, EventArgs e)
        {
            textmoney3.Text = this.comboBox3.Text;
        }
        private void get4(object sender, EventArgs e)
        {
            textmoney4.Text = this.comboBox4.Text;
        }
        private void get5(object sender, EventArgs e)
        {
            textmoney5.Text = this.comboBox5.Text;
        }
        private void get6(object sender, EventArgs e)
        {
            textmoney6.Text = this.comboBox6.Text;
        }
        private void get7(object sender, EventArgs e)
        {
            textmoney7.Text = this.comboBox7.Text;
        }
        private void get8(object sender, EventArgs e)
        {
            textmoney8.Text = this.comboBox8.Text;
        }
        private void get9(object sender, EventArgs e)
        {
            textmoney9.Text = this.comboBox9.Text;
        }
        //数据库连接
        private static OleDbConnection getConnect()
        {
            String exePath = System.Environment.CurrentDirectory;
            OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb");
            return conn;
        }

        //初始化券别
        private void quanbie_Initialized(object sender, EventArgs e)
        {

            DataSet set = new DataSet();
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "select [QUANBIE] from [table2]";
            OleDbDataAdapter oleadpter = new OleDbDataAdapter(sql, conn);
            oleadpter.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    this.comboBox1.Items.Add(set.Tables[0].Rows[i]["QUANBIE"].ToString());//需要转成String类型
                }
            }
            set.Reset();
            set.Clear();

        }
        private void quanbie2_Initialized(object sender, EventArgs e)
        {

            DataSet set = new DataSet();
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "select [QUANBIE] from [table2]";
            OleDbDataAdapter oleadpter = new OleDbDataAdapter(sql, conn);
            oleadpter.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    this.comboBox2.Items.Add(set.Tables[0].Rows[i]["QUANBIE"].ToString());//需要转成String类型
                }
            }
            set.Reset();
            set.Clear();
        }
        private void quanbie3_Initialized(object sender, EventArgs e)
        {

            DataSet set = new DataSet();
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "select [QUANBIE] from [table2]";
            OleDbDataAdapter oleadpter = new OleDbDataAdapter(sql, conn);
            oleadpter.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    this.comboBox3.Items.Add(set.Tables[0].Rows[i]["QUANBIE"].ToString());//需要转成String类型
                }
            }
            set.Reset();
            set.Clear();
        }
        private void quanbie4_Initialized(object sender, EventArgs e)
        {

            DataSet set = new DataSet();
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "select [QUANBIE] from [table2]";
            OleDbDataAdapter oleadpter = new OleDbDataAdapter(sql, conn);
            oleadpter.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    this.comboBox4.Items.Add(set.Tables[0].Rows[i]["QUANBIE"].ToString());//需要转成String类型
                }
            }
            set.Reset();
            set.Clear();
        }
        private void quanbie5_Initialized(object sender, EventArgs e)
        {

            DataSet set = new DataSet();
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "select [QUANBIE] from [table2]";
            OleDbDataAdapter oleadpter = new OleDbDataAdapter(sql, conn);
            oleadpter.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    this.comboBox5.Items.Add(set.Tables[0].Rows[i]["QUANBIE"].ToString());//需要转成String类型
                }
            }
            set.Reset();
            set.Clear();
        }
        private void quanbie6_Initialized(object sender, EventArgs e)
        {

            DataSet set = new DataSet();
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "select [QUANBIE] from [table2]";
            OleDbDataAdapter oleadpter = new OleDbDataAdapter(sql, conn);
            oleadpter.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    this.comboBox6.Items.Add(set.Tables[0].Rows[i]["QUANBIE"].ToString());//需要转成String类型
                }
            }
            set.Reset();
            set.Clear();
        }
        private void quanbie7_Initialized(object sender, EventArgs e)
        {

            DataSet set = new DataSet();
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "select [QUANBIE] from [table2]";
            OleDbDataAdapter oleadpter = new OleDbDataAdapter(sql, conn);
            oleadpter.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    this.comboBox7.Items.Add(set.Tables[0].Rows[i]["QUANBIE"].ToString());//需要转成String类型
                }
            }
            set.Reset();
            set.Clear();
        }
        private void quanbie8_Initialized(object sender, EventArgs e)
        {

            DataSet set = new DataSet();
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "select [QUANBIE] from [table2]";
            OleDbDataAdapter oleadpter = new OleDbDataAdapter(sql, conn);
            oleadpter.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    this.comboBox8.Items.Add(set.Tables[0].Rows[i]["QUANBIE"].ToString());//需要转成String类型
                }
            }
            set.Reset();
            set.Clear();
        }
        private void quanbie9_Initialized(object sender, EventArgs e)
        {

            DataSet set = new DataSet();
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "select [QUANBIE] from [table2]";
            OleDbDataAdapter oleadpter = new OleDbDataAdapter(sql, conn);
            oleadpter.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    this.comboBox9.Items.Add(set.Tables[0].Rows[i]["QUANBIE"].ToString());//需要转成String类型
                }
            }
            set.Reset();
            set.Clear();
        }

        //券别增删
        private void AddQuanbie_Click(object sender, RoutedEventArgs e)
        {
            //this.combo1.Items.Add(this.danweibox.Text);
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "insert into [table2]([QUANBIE]) values(" + "'" + this.textBox1.Text + "'" + ")";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            this.textBox1.Text = null;
            this.comboBox1.Items.Clear();
            this.quanbie_Initialized(sender, e);
            this.comboBox2.Items.Clear();
            this.quanbie2_Initialized(sender, e);
            this.comboBox3.Items.Clear();
            this.quanbie3_Initialized(sender, e);
            this.comboBox4.Items.Clear();
            this.quanbie4_Initialized(sender, e);
            this.comboBox5.Items.Clear();
            this.quanbie5_Initialized(sender, e);
            this.comboBox6.Items.Clear();
            this.quanbie6_Initialized(sender, e);
            this.comboBox7.Items.Clear();
            this.quanbie7_Initialized(sender, e);
            this.comboBox8.Items.Clear();
            this.quanbie8_Initialized(sender, e);
            this.comboBox9.Items.Clear();
            this.quanbie9_Initialized(sender, e);
            MessageBox.Show("插入成功！");

        }
        private void DeleteQuanbie_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "delete from [table2] where QUANBIE=" + "'" + this.textBox1.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.Items[i].ToString().Equals(this.textBox1.Text))
                {
                    this.textBox1.Text = null;
                    this.comboBox1.Items.Clear();
                    this.quanbie_Initialized(sender, e);
                    this.comboBox2.Items.Clear();
                    this.quanbie2_Initialized(sender, e);
                    this.comboBox3.Items.Clear();
                    this.quanbie3_Initialized(sender, e);
                    this.comboBox4.Items.Clear();
                    this.quanbie4_Initialized(sender, e);
                    this.comboBox5.Items.Clear();
                    this.quanbie5_Initialized(sender, e);
                    this.comboBox6.Items.Clear();
                    this.quanbie6_Initialized(sender, e);
                    this.comboBox7.Items.Clear();
                    this.quanbie7_Initialized(sender, e);
                    this.comboBox8.Items.Clear();
                    this.quanbie8_Initialized(sender, e);
                    this.comboBox9.Items.Clear();
                    this.quanbie9_Initialized(sender, e);
                    return;
                }
            }
            MessageBox.Show("删除失败！");
        }

        //初始化摘要
        private void comboBox_Initialized(object sender, EventArgs e)
        {
    
            DataSet set = new DataSet();
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "select [ZHAIYAO] from [table]";
            OleDbDataAdapter oleadpter = new OleDbDataAdapter(sql, conn);
            oleadpter.Fill(set);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    this.comboBox.Items.Add(set.Tables[0].Rows[i]["ZHAIYAO"].ToString());//需要转成String类型

                }
            }
            set.Reset();
            set.Clear();

        }

        //摘要增删
        private void AddZhaiyao_Click(object sender, RoutedEventArgs e)
        {
            //this.combo1.Items.Add(this.danweibox.Text);
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "insert into [table]([ZHAIYAO]) values(" + "'" + this.textBox.Text + "'" + ")";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            comm.ExecuteNonQuery();
          
            conn.Close();
            this.textBox.Text = null;
            this.comboBox.Items.Clear();
            this.comboBox_Initialized(sender, e);
            MessageBox.Show("插入成功！");

        }
        private void DeleteZhaiyao_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection conn = getConnect();
            conn.Open();
            String sql = "delete from [table] where ZHAIYAO = " + "'" + this.textBox.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i].ToString().Equals(this.textBox.Text))
                {
                    this.comboBox.Text = null;
                    this.comboBox.Items.Clear();
                    this.comboBox_Initialized(sender, e);
                    return;
                }
            }
            MessageBox.Show("删除失败！");
        }
        
        //合计钱
        private void Addmoney(object sender, RoutedEventArgs e)
        {
            Double sum = 0.00;
            if (!this.money1.Text.Trim().Equals(""))
            {
                Double money1 = Double.Parse(this.money1.Text);
                sum += money1;
                StringBuilder str =new StringBuilder(money1.ToString("f2"));
                int index = str.Length-3;
                for (int i = index - 3; i > 0; i -= 3)
                {
                    str.Insert(i, ",");
                }
                this.money1.Text = str.ToString();
            }
            if (!this.money2.Text.Trim().Equals(""))
            {
                Double money2 = Double.Parse(this.money2.Text);
                sum += money2;
                StringBuilder str = new StringBuilder(money2.ToString("f2"));
                int index = str.Length - 3;
                for (int i = index - 3; i > 0; i -= 3)
                {
                    str.Insert(i, ",");
                }
                this.money2.Text = str.ToString();
            }
            if (!this.money3.Text.Trim().Equals(""))
            {
                Double money3 = Double.Parse(this.money3.Text);
                sum += money3;
                StringBuilder str = new StringBuilder(money3.ToString("f2"));
                int index = str.Length - 3;
                for (int i = index - 3; i > 0; i -= 3)
                {
                    str.Insert(i, ",");
                }
                this.money3.Text = str.ToString();
            }
            if (!this.money4.Text.Trim().Equals(""))
            {
                Double money4 = Double.Parse(this.money4.Text);
                sum += money4;
                StringBuilder str = new StringBuilder(money4.ToString("f2"));
                int index = str.Length - 3;
                for (int i = index - 3; i > 0; i -= 3)
                {
                    str.Insert(i, ",");
                }
                this.money4.Text = str.ToString();
            }
            if (!this.money5.Text.Trim().Equals(""))
            {
                Double money5 = Double.Parse(this.money5.Text);
                sum += money5;
                StringBuilder str = new StringBuilder(money5.ToString("f2"));
                int index = str.Length - 3;
                for (int i = index - 3; i > 0; i -= 3)
                {
                    str.Insert(i, ",");
                }
                this.money5.Text = str.ToString();
            }
            if (!this.money6.Text.Trim().Equals(""))
            {
                Double money6 = Double.Parse(this.money6.Text);
                sum += money6;
                StringBuilder str = new StringBuilder(money6.ToString("f2"));
                int index = str.Length - 3;
                for (int i = index - 3; i > 0; i -= 3)
                {
                    str.Insert(i, ",");
                }
                this.money6.Text = str.ToString();
            }
            if (!this.money7.Text.Trim().Equals(""))
            {
                Double money7 = Double.Parse(this.money7.Text);
                sum += money7;
                StringBuilder str = new StringBuilder(money7.ToString("f2"));
                int index = str.Length - 3;
                for (int i = index - 3; i > 0; i -= 3)
                {
                    str.Insert(i, ",");
                }
                this.money7.Text = str.ToString();
            }
            if (!this.money8.Text.Trim().Equals(""))
            {
                Double money8 = Double.Parse(this.money8.Text);
                sum += money8;
                StringBuilder str = new StringBuilder(money8.ToString("f2"));
                int index = str.Length - 3;
                for (int i = index - 3; i > 0; i -= 3)
                {
                    str.Insert(i, ",");
                }
                this.money8.Text = str.ToString();
            }
            if (!this.money9.Text.Trim().Equals(""))
            {
                Double money9 = Double.Parse(this.money9.Text);
                sum += money9;
                StringBuilder str = new StringBuilder(money9.ToString("f2"));
                int index = str.Length - 3;
                for (int i = index - 3; i > 0; i -= 3)
                {
                    str.Insert(i, ",");
                }
                this.money9.Text = str.ToString();
            }

            StringBuilder stri = new StringBuilder(sum.ToString("f2"));
            int indexe = stri.Length - 3;
            for (int i = indexe - 3; i > 0; i -= 3)
            {
                stri.Insert(i, ",");
            }
            this.zongji.Text = stri.ToString();
        }

        //大写转换
        private void Daxiemoney(object sender, RoutedEventArgs e)
        {
            if (this.zongji.Text.Trim().Equals(""))
            {
                this.daxie.Text = "";
                return;
            }
            // this.daxie.Text = new MoneyConvertChinese().MoneyToChinese(this.zongji.Text);
           StringBuilder str= new StringBuilder(new MoneyConvertChinese().MoneyToChinese(this.zongji.Text)); 
           str.Replace("零元", "元");
            this.daxie.Text = str.ToString();
            
        }

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

 
}
