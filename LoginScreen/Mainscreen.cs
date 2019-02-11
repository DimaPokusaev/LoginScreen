using System;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Mainscreen : UserControl
    {
        public Mainscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNameBox.Text == " " || PasswordTextBox.Text == " ")
            {
                ErrorMessage.Visible = true;
            }
            else
            {
                Form1.username = UserNameBox.Text;
                Form f = this.FindForm();
                f.Controls.Remove(this);
                Loged_In ln = new Loged_In();
                f.Controls.Add(ln);
            }
        }
    }
}
