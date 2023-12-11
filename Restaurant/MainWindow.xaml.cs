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
using System.Windows.Shapes;

namespace Restaurant
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance { get; private set; }

        public delegate void ChangeContentDelegate(UserControl uc);
        public event ChangeContentDelegate OnChangeContent;

        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new Startseite();
            OnChangeContent += changeContent;
            Instance = this;
            this.Background = Constants.Constants.DEFAULT_BACKGROUND_COLOR;
        }

        public void changeContent(UserControl uc)
        {
            MainContent.Content = uc;
        }
    }
}
