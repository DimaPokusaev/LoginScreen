using System;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Loged_In : UserControl
    {
        public Loged_In()
        {
            InitializeComponent();
        }

        private void Loged_In_Load(object sender, EventArgs e)
        {
            Output.Text = "Welcome " + Convert.ToString(Form1.username);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            Mainscreen ms = new Mainscreen();
            f.Controls.Add(ms);
        }
    }
}
