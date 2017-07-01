using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace WpfApp1
{
    class Window1:Window
    {
        private Button button1;
        public Window1()
        {
            InitializeCompent();
        }
        public void InitializeCompent()
        {
            this.Width=this.Height=500;
            this.Left = this.Top = 100;
            this.Title = "new Windows";

            DockPanel dockpanel1 = new DockPanel();

            button1 = new Button();
            button1.Content = "Please click me";
            button1.Margin = new Thickness(30);
            button1.Click += button1_Click;

            IAddChild container = dockpanel1;
            container.AddChild(button1);

            container = this;
            container.AddChild(dockpanel1);

        }

        private void button1_Click(object sender,RoutedEventArgs e)
        {
            button1.Content = "Thank you";
        }
    }
}
