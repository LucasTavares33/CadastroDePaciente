using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_cadastro_de_pacientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            metodos identificacao = new metodos();
           
            Paciente pessoa = new Paciente();

            pessoa.nome = textBox1.Text.ToString();
            pessoa.cpf = textBox2.Text.ToString();
            pessoa.data = Convert.ToDateTime(textBox3.Text);
            string sexo;
            if (radioButton1.Checked) 
            {
                sexo = "M";
            }
            else 
            {
                sexo = "F";
            }
            pessoa.sexo = sexo;
            pessoa.id =  identificacao.PacienteId();

            string mensagem = identificacao.Cadastrar(pessoa);
            MessageBox.Show(mensagem);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            metodos lista = new metodos();

            listBox1.Items.Clear();

            List<string> listaP = lista.ReadText("PACIENTES.txt");
            
            foreach (string linha in listaP) 
            { 
              listBox1.Items.Add(linha);             
            }
            

            

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
