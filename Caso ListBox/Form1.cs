using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_ListBox
{
    public partial class Form1 : Form
    {
        int contador = 0;
        int contadorPosicion = 99;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Debe escribir la tarea a agregar");
            else if (contador == 0)
            {
                contador++;
                checkBox2.Text = textBox1.Text;
            }
            else if (contador <= 12)
            {
                contador++;
                CheckBox checkBox = new CheckBox();
                this.Controls.Add(checkBox);
                checkBox.Location = new Point(266, contadorPosicion);
                checkBox.Visible = true;
                checkBox.AutoSize = true;
                checkBox.Font = new Font("Arial", 10, FontStyle.Regular);
                checkBox.Text = textBox1.Text;
                checkBox.TabIndex = 1;
                checkBox.BringToFront();
                checkBox.BackColor = checkBox2.BackColor;
                contadorPosicion += 23;

            }
            else
                MessageBox.Show("El numero de tareas maximo es de 13");
        }
        
    }
}
