using System;
using System.Windows;
using System.Windows.Input;

namespace Gas_Laws.Pages
{
    /// <summary>
    /// Логика взаимодействия для About_Programxaml.xaml
    /// </summary>
    public partial class About_Program : Window
    {
        public About_Program()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            GC.Collect();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
