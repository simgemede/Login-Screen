using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "SimgeMede" && textBox2.Text == "Simge1234")
            {
                new Form2().Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınızı veya şifrenizi yanlış girdiniz");
            }
        }
    }
}
