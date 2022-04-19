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

    public partial class Form1 : Form
    {
        String senha, repitasenha, nome, email, loginEmail, LoginSenha;

        public Form1()
        {
            InitializeComponent();

        }
    
           private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                nome = (textBox1.Text);
                email = (textBox2.Text);
                senha = (textBox3.Text);
                repitasenha = (textBox4.Text);

                if (repitasenha != senha)
            {
                MessageBox.Show("As senham nao coecidem", "messagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Clear();
            }
            else if (nome == "")
            {

                MessageBox.Show("Campo 'nome' não esta preenchido ", "messagem", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (email == ""){

                MessageBox.Show("Campo 'email' não esta preenchido ", "messagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (senha == "")
            {

                MessageBox.Show("Campo 'senha' não esta preenchido ", "messagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (repitasenha == "")
            {

                MessageBox.Show("Campo 'Repita senha' não esta preenchido ", "messagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                MessageBox.Show("Voce esta cadastrado", "mensagem",
                    MessageBoxButtons.OK);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
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
            else {  
             if (loginEmail == email && LoginSenha == senha)
            {
                Form2 f = new Form2();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Email ou senha invalida", "messagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Clear();
            }
            }


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
