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

            this.zongji.Text = sum.ToString("f2");
        }
        //数据库连接
        private static OleDbConnection getConnect()
        {
            String exePath = System.Environment.CurrentDirectory;
            OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\\VisualStdio\\App1\\款单打印2.0\\款单打印2.0\\Database.mdb");
            return conn;
        }

        //大写转换
        private void Daxiemoney(object sender,RoutedEventArgs e)
        {
            String[] Da = {"壹","贰","叁","肆","伍","陆","柒","捌","玖", "拾", "佰","仟","万" };
        }
    }
    
}
