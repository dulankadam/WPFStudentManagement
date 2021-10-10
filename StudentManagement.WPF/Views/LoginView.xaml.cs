using StudentManagement.Core.Common.Interfaces;
using StudentManagement.Core.Services;
using StudentManagement.Core.Services.LoginServices;
using StudentManagement.WPF.Services;
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

namespace StudentManagement.WPF.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        private readonly Core.Services.LoginServices.LoginService loginService;
        private readonly IApplicationDbContext _context;
        public LoginView(IApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
            loginService = new LoginService(_context);


        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var LoginResult = LoginService.ValidateLoginCredentials(txtUserName.Text, txtPassword.Password);
            MessageBox.Show(LoginResult.ToString());
        }
    }
}
