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
            this.combo1.Items.Add("中国银行");
            this.combo1.Items.Add("建设银行");
            this.combo1.Items.Add("农业银行");
            this.combo1.Items.Add("工商银行");
        
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
            this.combo1.Items.Add(this.danweibox.Text);
            this.danweibox.Text = null;
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            this.combo1.Items.Remove(this.danweibox.Text);
            this.danweibox.Text = null;
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
        private void Daxiemoney(object sender,RoutedEventArgs e)
        {
            String[] Da = {"壹","贰","叁","肆","伍","陆","柒","捌","玖", "拾", "佰","仟","万" };
        }
    }
    
}
