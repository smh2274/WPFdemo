using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace WpfApp1
{
    class program:Application
    {
        [STAThread()]
        static void Main()
        {
            program app = new program();
            app.MainWindow = new Window1();
            app.MainWindow.ShowDialog();
        }
    }
}
