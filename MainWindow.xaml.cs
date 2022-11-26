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

            Popup popup = new Popup();
            popup.PlacementTarget = this;
            popup.Placement = PlacementMode.Center;
            popup.AllowsTransparency = true;
            popup.IsOpen = true;

            TextBlock textBlock = new TextBlock();
            textBlock.Text = text;
            textBlock.Background = Brushes.White;
            textBlock.Foreground = Brushes.Black;
            textBlock.Padding = new Thickness(10);
            textBlock.FontSize = 20;
            textBlock.Width = 300;
            textBlock.Height = 180;
            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.VerticalAlignment = VerticalAlignment.Center;

            Grid grid = new Grid();

            grid.Children.Add(textBlock);

            popup.Child = grid;

        }
    }
}