using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParadigmaEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("T.I");
            comboBox1.Items.Add("C.C");
            comboBox1.Items.Add("Pasaporte");

            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");
            comboBox2.Items.Add("6");
            comboBox2.Items.Add("7");
            comboBox2.Items.Add("8");
            comboBox2.Items.Add("9");
            comboBox2.Items.Add("10");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String prueba = "Fecha:" + Convert.ToString(dateTimePicker1.Value) + "\r\n"
            + "Nombre:" + Convert.ToString(textBox1.Text) + "\r\n" +
            "Tipo de Documento:" + Convert.ToString(comboBox1.SelectedItem) + "\r\n"
            +"Número de documento:" + Convert.ToString(textBox2.Text) + "\r\n" +
            "Semestre:" + Convert.ToString(comboBox2.Text) + "\r\n";


            textBox1.Clear();
            textBox2.Clear();

            richTextBox1.Text = prueba + richTextBox1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Formulario = new Form2();
            Formulario.textBox1.Text = richTextBox1.Text;
            Formulario.Show();
        }
    }
}






