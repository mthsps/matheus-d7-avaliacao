using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string text = "Usuário autenticado!";

            CreatePopup(text);
        }

        private void CreatePopup(string text) {

            Popup codePopup = new Popup();
            TextBlock popupText = new TextBlock();
            popupText.Text = text;
            popupText.Background = Brushes.White;
            popupText.Height = ActualHeight;
            popupText.Width = ActualWidth;
            popupText.HorizontalAlignment = HorizontalAlignment.Center;
            popupText.VerticalAlignment = VerticalAlignment.Center;
            popupText.FontSize = 24;
            codePopup.Child = popupText;
            codePopup.PlacementTarget = this;
            codePopup.Placement = PlacementMode.Center;
            codePopup.IsOpen = true;
            codePopup.Width = 300;
            codePopup.Height = 180;


        }
    }
}