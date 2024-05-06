using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace newVectores2
{
    public partial class Form1 : Form
    {
        classVector vec1, vec2, vec3, vec4;

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = vec1.descargar();
        }

        private void cargarElexEleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ter, cant;
            vec1 = new classVector();
            cant = int.Parse(Interaction.InputBox("Ingrese la cantidad: "));
            for(ter = 1; ter <= cant; ter++)
            {
                vec1.cargarElexEle(int.Parse(Interaction.InputBox("Ingrese los elementos: " + ter)));
            }
        }

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.elemFrecuFibonacci(int.Parse(textBox1.Text), int.Parse(textBox2.Text), ref vec2, ref vec3);
            textBox5.Text = vec2.descargar();
            textBox6.Text = vec3.descargar();
        }

        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1 = new classVector();
            vec1.cargarSinRepet(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vec1 = new classVector();
            vec2 = new classVector();
            vec3 = new classVector();
            vec4 = new classVector();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.cargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }
    }
}
