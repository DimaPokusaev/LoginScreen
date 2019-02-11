using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public static string username;

        private void Form1_Load(object sender, EventArgs e)
        {
            Mainscreen ln = new Mainscreen();
            this.Controls.Add(ln);
        }
    }
}
