using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_2_Programacion_II_v4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel) 
            {
                textBox1.BackColor = colorDialog1.Color;
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.ShowDialog();
        }
    }
}
