using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorEstudianteControllers.Managers;
using ManejadorEstudianteControllers.Models;

namespace ManejadorEstudianteUIForm
{
    public partial class Form1 : Form
    {
        EstudianteManager manager;
        public Form1()
        {
            InitializeComponent();
            manager = new EstudianteManager();
        }

        // metodos de clase

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox2.Text))
            {
                this.button1.BackColor = Color.Red;
                return;
            }
            this.button1.BackColor = Color.Coral;
            string nombre = this.textBox1.Text;
            string codigo = this.textBox2.Text;
            //string texte = string.Format("Agregar Estudiante con nombre {0} y codigo {1}", nombre, codigo);
            //MessageBox.Show(texte);
            manager.AgregarEstudiante(nombre, codigo);
            LimpiarTextos();
            ActualizarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mostrar Estudiante");
        }

        private void LimpiarTextos()
        {
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
        }

        private void ActualizarLista()
        {
            listBox1.Items.Clear();
            foreach (Estudiante estudiante in manager.ListaEstudiantes)
            {
                listBox1.Items.Add(estudiante);
            }
        }
    }
}
