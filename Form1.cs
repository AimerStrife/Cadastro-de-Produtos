using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_adilson_13_09
{
    public partial class Form1 : Form

    {
        Fornecedor forn1 = new Fornecedor();

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forn1.setid(100);
            forn1.setnome("100");
            forn1.setcnpj("100");
            MessageBox.Show("Dados salvos com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Id..:" + forn1.getid() +
                            "\nNome:" + forn1.getnome() +
                            "\nCnpj:" + forn1.getcnpj(), "Consultar",MessageBoxButtons.OK,MessageBoxIcon.Information);
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Limpar();
        }
        public void Limpar()
        {
            textBox1.Clear(); //limpar box 1
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus(); //focar no box1
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
