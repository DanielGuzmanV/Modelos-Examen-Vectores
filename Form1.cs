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

        private void pregunta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.elimPosMultiplos(int.Parse(textBox1.Text));
            textBox5.Text = vec1.descargar();
        }

        private void pregunta4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.segmentarRepetYNoRepet();
            textBox5.Text = vec1.descargar();
        }

        private void pregunta5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.elementFrecu(int.Parse(textBox1.Text), int.Parse(textBox2.Text), ref vec2, ref vec3);
            textBox5.Text = vec2.descargar();
            textBox6.Text = vec3.descargar();
        }

        private void pregunta6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.ordenMayMenPosMulti(int.Parse(textBox1.Text));
            textBox5.Text = vec1.descargar();
        }

        private void pregunta7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.elimElemRepet();
            textBox5.Text = vec1.descargar();
        }

        private void ordenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.ordenSinparametros();
            textBox5.Text = vec1.descargar();
        }

        private void cargarRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.cargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarSinRepetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1 = new classVector();
            vec1.cargarSinRepet(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox4.Text = vec1.descargar();
        }

        private void cargarRandomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vec2.cargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void cargarSinRepetirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vec2 = new classVector();
            vec2.cargarSinRepet(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox5.Text = vec2.descargar();
        }

        private void pregunta8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.unioVectoresSinRepet(vec2, ref vec3);
            textBox6.Text = vec3.descargar();
        }

        private void pregunta9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.interMayMen(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox5.Text = vec1.descargar();
        }

        private void pregunta10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.elemMasFrecu(int.Parse(textBox1.Text), int.Parse(textBox2.Text), ref vec2, ref vec3);
            textBox5.Text = vec2.descargar();
            textBox6.Text = vec3.descargar();
        }

        private void pregunta11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.elimPosMulti(int.Parse(textBox1.Text));
            textBox5.Text = vec1.descargar();
        }

        private void pregunta12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(vec1.elemDife(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
        }

        private void pregunta13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.diferenSimetri(vec2, ref vec3);
            textBox6.Text = vec3.descargar();
        }

        private void cargarExeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ter, cant;
            vec1 = new classVector();
            cant = int.Parse(Interaction.InputBox("Ingrese la cantidad: "));
            for (ter = 1; ter <= cant; ter++)
            {
                vec1.cargarElexEle(int.Parse(Interaction.InputBox("Ingrese los elementos: " + ter)));
            }
        }

        private void cargarExeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int ter, cant;
            vec2 = new classVector();
            cant = int.Parse(Interaction.InputBox("Ingrese la cantidad: "));
            for (ter = 1; ter <= cant; ter++)
            {
                vec2.cargarElexEle(int.Parse(Interaction.InputBox("Ingrese los elementos: " + ter)));
            }
        }

        private void busqueFiboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //vec1 = new classVector();
            textBox5.Text = string.Concat(vec1.busquedaFibo(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)));
            //textBox5.Text = string.Concat(vec1.busquedaFibo(int.Parse(textBox1.Text)));
        }

        private void pregunta14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.segmenFiboNoFibo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox5.Text = vec1.descargar();
        }

        private void pregunta15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.elimElemVector(vec2, ref vec3);
            textBox6.Text = vec3.descargar();
        }

        private void pregunta16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vec1.segmenFiboNoFibo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox5.Text = vec1.descargar();
        }

        private void esPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textBox5.Text = string.Concat(vec1.elemPrimo(int.Parse(textBox1.Text)));
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
