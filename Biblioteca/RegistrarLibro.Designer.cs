namespace Biblioteca
{
    partial class RegistrarLibro
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker_AñoPublicacion = new DateTimePicker();
            numericUpDown_Paginas = new NumericUpDown();
            label6 = new Label();
            textBox_Genero = new TextBox();
            textBox_Editorial = new TextBox();
            textBox_Autor = new TextBox();
            textBox_Titulo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button_Registrar = new Button();
            button_Cancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Paginas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Autor:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker_AñoPublicacion);
            groupBox1.Controls.Add(numericUpDown_Paginas);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox_Genero);
            groupBox1.Controls.Add(textBox_Editorial);
            groupBox1.Controls.Add(textBox_Autor);
            groupBox1.Controls.Add(textBox_Titulo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 218);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del cliente";
            // 
            // dateTimePicker_AñoPublicacion
            // 
            dateTimePicker_AñoPublicacion.Location = new Point(132, 121);
            dateTimePicker_AñoPublicacion.Name = "dateTimePicker_AñoPublicacion";
            dateTimePicker_AñoPublicacion.Size = new Size(144, 27);
            dateTimePicker_AñoPublicacion.TabIndex = 11;
            // 
            // numericUpDown_Paginas
            // 
            numericUpDown_Paginas.Location = new Point(132, 185);
            numericUpDown_Paginas.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_Paginas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Paginas.Name = "numericUpDown_Paginas";
            numericUpDown_Paginas.Size = new Size(144, 27);
            numericUpDown_Paginas.TabIndex = 5;
            numericUpDown_Paginas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 192);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 10;
            label6.Text = "Paginas:";
            // 
            // textBox_Genero
            // 
            textBox_Genero.Location = new Point(132, 152);
            textBox_Genero.Name = "textBox_Genero";
            textBox_Genero.Size = new Size(144, 27);
            textBox_Genero.TabIndex = 9;
            // 
            // textBox_Editorial
            // 
            textBox_Editorial.Location = new Point(132, 86);
            textBox_Editorial.Name = "textBox_Editorial";
            textBox_Editorial.Size = new Size(144, 27);
            textBox_Editorial.TabIndex = 7;
            // 
            // textBox_Autor
            // 
            textBox_Autor.Location = new Point(132, 53);
            textBox_Autor.Name = "textBox_Autor";
            textBox_Autor.Size = new Size(144, 27);
            textBox_Autor.TabIndex = 6;
            // 
            // textBox_Titulo
            // 
            textBox_Titulo.Location = new Point(132, 20);
            textBox_Titulo.Name = "textBox_Titulo";
            textBox_Titulo.Size = new Size(144, 27);
            textBox_Titulo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 159);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Genero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 126);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 3;
            label4.Text = "Año publicacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 93);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Editorial:";
            // 
            // button_Registrar
            // 
            button_Registrar.Location = new Point(204, 236);
            button_Registrar.Name = "button_Registrar";
            button_Registrar.Size = new Size(96, 32);
            button_Registrar.TabIndex = 3;
            button_Registrar.Text = "Registrar";
            button_Registrar.UseVisualStyleBackColor = true;
            button_Registrar.Click += button_Registrar_Click;
            // 
            // button_Cancelar
            // 
            button_Cancelar.Location = new Point(42, 236);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(96, 32);
            button_Cancelar.TabIndex = 4;
            button_Cancelar.Text = "Cancelar";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // RegistrarLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 291);
            Controls.Add(button_Cancelar);
            Controls.Add(button_Registrar);
            Controls.Add(groupBox1);
            Name = "RegistrarLibro";
            Text = "Registro de libro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Paginas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox_Genero;
        private TextBox textBox_Editorial;
        private TextBox textBox_Autor;
        private TextBox textBox_Titulo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button_Registrar;
        private Button button_Cancelar;
        private DateTimePicker dateTimePicker_AñoPublicacion;
        private NumericUpDown numericUpDown_Paginas;
        private Label label6;
    }
}