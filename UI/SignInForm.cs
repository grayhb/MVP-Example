using System;
using System.Windows.Forms;
using Presentation.Views;

namespace UI
{
    public partial class SignInForm : Form, ISignInView
    {
        private readonly ApplicationContext _context;

        public SignInForm(ApplicationContext context)
        {
            _context = context;

            InitializeComponent();

            signInButton.Click += (sender, args) => Invoke(SignIn);
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }


        public string Login => loginText.Text;

        public string Password => passwordText.Text;

        public event Action SignIn;

        private void Invoke(Action action)
        {
            if (action != null) action();
        }
        
        public void ShowError(string errorMessage)
        {
            errorLabel.Text = errorMessage;
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("wtf?");
        }
    }
}
