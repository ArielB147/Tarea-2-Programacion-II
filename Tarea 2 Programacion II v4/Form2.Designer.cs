namespace Tarea_2_Programacion_II_v4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rtxt_contenido = new System.Windows.Forms.RichTextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Direccion:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtxt_contenido
            // 
            this.rtxt_contenido.Location = new System.Drawing.Point(12, 77);
            this.rtxt_contenido.Name = "rtxt_contenido";
            this.rtxt_contenido.Size = new System.Drawing.Size(297, 388);
            this.rtxt_contenido.TabIndex = 3;
            this.rtxt_contenido.Text = "";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(76, 22);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(254, 20);
            this.txt_direccion.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 78);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 495);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.rtxt_contenido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rtxt_contenido;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}