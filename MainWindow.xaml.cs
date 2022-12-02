using LoginApp.Data;
using LoginApp.Model;
using System.Linq;
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

        private readonly Context context;
        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or Password is empty");
                return;
            }

            var user = context.Users.
                Where(b => b.Username == username && b.Password == password)
                .FirstOrDefault();



            if (user == null)
            {
                MessageBox.Show("Usuário autenticado");
                return;
            }

            MessageBox.Show("Credenciais inválidas");
        }

    }
}