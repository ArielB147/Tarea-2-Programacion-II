using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tarea_2_Programacion_II_v4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Buscar Archivo";
            openFileDialog1.ShowDialog();
            string Texto = openFileDialog1.FileName;

            if (File.Exists(openFileDialog1.FileName))
            {
                TextReader Leer = new StreamReader(Texto);
                rtxt_contenido.Text = Leer.ReadToEnd();
                MessageBox.Show(Leer.ReadToEnd());
                Leer.Close();

            }

            txt_direccion.Text = Texto;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
                {
                    
                    if (File.Exists(saveFileDialog1.FileName)) 
                    {
                        string txt = saveFileDialog1.FileName;
                        
                        StreamWriter textguardar = File.CreateText(txt);
                        textguardar.Write(rtxt_contenido.Text);
                        textguardar.Flush();
                        textguardar.Close();

                        txt_direccion.Text=txt;
                    
                    }
                    else 
                    {
                        string txt = saveFileDialog1.FileName;

                        StreamWriter textguardar = File.CreateText(txt);
                        textguardar.Write(rtxt_contenido.Text);
                        textguardar.Flush();
                        textguardar.Close();

                        txt_direccion.Text = txt;
                    }
                
                }





            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }

        }
    }
}
