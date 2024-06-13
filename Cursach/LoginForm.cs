using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cursach
{
    public partial class LoginForm : Form
    {
        private ErrorProvider errorProvider;
        private const string UsersFilePath = "users.txt";

        public LoginForm()
        {
            InitializeComponent();

            this.passField.Size = new Size(180, 30);
            this.passField.AutoSize = false;
            this.loginField.Size = new Size(180, 30);
            this.loginField.AutoSize = false;

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void RollUp(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RollUpButton_MouseEnter(object sender, EventArgs e)
        {
            rollUpButton.ForeColor = Color.Green;
        }

        private void RollUpButton_MouseLeave(object sender, EventArgs e)
        {
            rollUpButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void Panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CreateAccButton_Click(object sender, EventArgs e)
        {
            string login = loginField.Text.Trim();
            string password = passField.Text.Trim();

            errorProvider.SetError(loginField, "");
            errorProvider.SetError(passField, "");

            if (!IsValidLogin(login))
            {
                errorProvider.SetError(loginField, "Недопустимый логин.\nЛогин должен быть не менее 3 букв и цифр,\n" +
                    "не должен начинаться на запрещенные символы\nи не должен повторяться с уже существующими.");
                return;
            }

            if (!IsValidPassword(password))
            {
                errorProvider.SetError(passField, "Пароль должен быть не менее 8 символов.");
                return;
            }

            if (CheckUserExists(login))
            {
                errorProvider.SetError(loginField, "Этот логин уже занят.");
                return;
            }

            UserManager.RegisterUser(login, password);

            ClearFields();
        }

        private void ClearFields()
        {
            loginField.Clear();
            passField.Clear();
            errorProvider.SetError(loginField, "");
            errorProvider.SetError(passField, "");
        }

        private bool IsValidLogin(string login)
        {
            if (login.Length < 3 || Regex.IsMatch(login, @"^[@#\/!,._\?:%-]"))
            {
                return false;
            }
            return true;
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }

        private bool CheckUserExists(string login)
        {
            if (!File.Exists(UsersFilePath)) return false;

            var lines = File.ReadAllLines(UsersFilePath);
            return lines.Any(line => line.Split(',')[0] == login);
        }

        private void LoginField_Validating(object sender, CancelEventArgs e)
        {
            string login = loginField.Text.Trim();
            errorProvider.SetError(loginField, "");

            if (string.IsNullOrEmpty(login))
            {
                errorProvider.SetError(loginField, "Логин не может быть пустым.");
                e.Cancel = true;
            }
            else if (!IsValidLogin(login))
            {
                errorProvider.SetError(loginField, "Недопустимый логин.\nЛогин должен быть не менее 3 букв и цифр,\n" +
                    "не должен начинаться на запрещенные символы\nи не должен повторяться с уже существующими.");
                e.Cancel = true;
            }
        }

        private void PasswordField_Validating(object sender, CancelEventArgs e)
        {
            string password = passField.Text.Trim();
            errorProvider.SetError(passField, "");

            if (string.IsNullOrEmpty(password))
            {
                errorProvider.SetError(passField, "Пароль не может быть пустым.");
                e.Cancel = true;
            }
            else if (!IsValidPassword(password))
            {
                errorProvider.SetError(passField, "Пароль должен быть не менее 8 символов.");
                e.Cancel = true;
            }
        }

        public CatchAButton CatchAButtonForm { get; set; }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;
            string password = passField.Text;

            bool isValid = IsValidAccount(login, password);

            if (isValid)
            {
                CatchAButton btn = new CatchAButton(login);
                this.Hide();
                btn.Show();
                btn.FormClosed += (s, args) => this.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidAccount(string login, string password)
        {
            if (!File.Exists(UsersFilePath)) return false;

            var lines = File.ReadAllLines(UsersFilePath);
            return lines.Any(line =>
            {
                var parts = line.Split(',');
                return parts[0] == login && parts[1] == password;
            });
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<CatchAButton>().Count() == 0)
            {
                Application.Exit();
            }
        }
    }
}
