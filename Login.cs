using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teladelogin { 

    public partial class Login : Form
    {
        String senha, repitasenha, nome, email, loginEmail, LoginSenha;

        public Login()
        {
            InitializeComponent();

        }
    
           private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            loginEmail = textBox5.Text;
            LoginSenha = textBox6.Text;

            if (loginEmail == "" && LoginSenha == "")
            {
                MessageBox.Show("PREENCHA OS CAMPOS", "messagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
            Principal f = new Principal();
            this.Hide();
            f.Show();

        }

        private void button3_Click(object sender, EventArgs e)
                {
            MessageBox.Show("Lamento :(  \n Faça um novo cadastro","IIIII", 
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
