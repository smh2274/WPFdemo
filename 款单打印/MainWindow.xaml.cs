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
using System.Collections.ObjectModel;


namespace 款单打印
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Member> data = new ObservableCollection<Member>();
            data.Add(new Member()
            {
                danwei = danweiOpt.中国银行,
                kong=null,
                quanbie = "hhh",
                jine=100000
            });
            data.Add(new Member()
            {
                danwei = danweiOpt.农业银行,
                kong = null,
                quanbie = "hhh",
                jine = 10044
            });
            data.Add(new Member()
            {
                danwei = danweiOpt.中国银行,
                kong = null,
                quanbie = "hhh",
                jine = 10130
            });
            dataGrid.DataContext = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


        

    }
    public enum danweiOpt { 中国银行, 建设银行, 工商银行, 农业银行 };

    public class Member
    {
        public danweiOpt danwei { get; set; }
        public String kong { get; set; }
        public String quanbie { get; set; }
        public long jine { get; set; }
    }



}
