namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tBox_Titulo_Libro = new TextBox();
            groupBox1 = new GroupBox();
            btn_RegistrarLibro = new Button();
            label11 = new Label();
            label2 = new Label();
            label14 = new Label();
            tB_Editorial = new TextBox();
            label13 = new Label();
            lB_LibrosDisponibles = new ListBox();
            tB_AutorLibro = new TextBox();
            label5 = new Label();
            cB_GeneroLibro = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label15 = new Label();
            label12 = new Label();
            btn_RegistrarCliente = new Button();
            radioButton4 = new RadioButton();
            btn_PrestarLibro = new Button();
            dateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            label9 = new Label();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            radioButton3 = new RadioButton();
            comboBox2 = new ComboBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            lB_LibrosPrestados = new ListBox();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 2;
            label1.Text = "Sistema de biblioteca";
            // 
            // tBox_Titulo_Libro
            // 
            tBox_Titulo_Libro.Location = new Point(94, 34);
            tBox_Titulo_Libro.Name = "tBox_Titulo_Libro";
            tBox_Titulo_Libro.Size = new Size(121, 27);
            tBox_Titulo_Libro.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn_RegistrarLibro);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(tB_Editorial);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(lB_LibrosDisponibles);
            groupBox1.Controls.Add(tB_AutorLibro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cB_GeneroLibro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tBox_Titulo_Libro);
            groupBox1.Location = new Point(32, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 187);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de libro";
            // 
            // btn_RegistrarLibro
            // 
            btn_RegistrarLibro.Location = new Point(391, 77);
            btn_RegistrarLibro.Name = "btn_RegistrarLibro";
            btn_RegistrarLibro.Size = new Size(91, 52);
            btn_RegistrarLibro.TabIndex = 16;
            btn_RegistrarLibro.Text = "Registrar libro";
            btn_RegistrarLibro.UseVisualStyleBackColor = true;
            btn_RegistrarLibro.Click += btn_RegistrarLibro_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(391, 54);
            label11.Name = "label11";
            label11.Size = new Size(84, 20);
            label11.TabIndex = 15;
            label11.Text = "nuevo libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 34);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 14;
            label2.Text = "Registrar";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(230, 32);
            label14.Name = "label14";
            label14.Size = new Size(132, 20);
            label14.TabIndex = 13;
            label14.Text = "Libros disponibles:";
            // 
            // tB_Editorial
            // 
            tB_Editorial.Location = new Point(94, 139);
            tB_Editorial.Name = "tB_Editorial";
            tB_Editorial.Size = new Size(121, 27);
            tB_Editorial.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 144);
            label13.Name = "label13";
            label13.Size = new Size(68, 20);
            label13.TabIndex = 11;
            label13.Text = "Editorial:";
            // 
            // lB_LibrosDisponibles
            // 
            lB_LibrosDisponibles.FormattingEnabled = true;
            lB_LibrosDisponibles.ItemHeight = 20;
            lB_LibrosDisponibles.Location = new Point(229, 59);
            lB_LibrosDisponibles.Name = "lB_LibrosDisponibles";
            lB_LibrosDisponibles.Size = new Size(147, 104);
            lB_LibrosDisponibles.TabIndex = 10;
            // 
            // tB_AutorLibro
            // 
            tB_AutorLibro.Location = new Point(94, 104);
            tB_AutorLibro.Name = "tB_AutorLibro";
            tB_AutorLibro.Size = new Size(121, 27);
            tB_AutorLibro.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 109);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 7;
            label5.Text = "Autor:";
            // 
            // cB_GeneroLibro
            // 
            cB_GeneroLibro.FormattingEnabled = true;
            cB_GeneroLibro.Location = new Point(94, 67);
            cB_GeneroLibro.Name = "cB_GeneroLibro";
            cB_GeneroLibro.Size = new Size(121, 28);
            cB_GeneroLibro.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 77);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Genero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 41);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Titulo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(btn_RegistrarCliente);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(btn_PrestarLibro);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(32, 261);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(510, 272);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prestamo de ejemplar";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(339, 43);
            label15.Name = "label15";
            label15.Size = new Size(160, 20);
            label15.TabIndex = 15;
            label15.Text = "Registrar nuevo cliente";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(361, 23);
            label12.Name = "label12";
            label12.Size = new Size(114, 20);
            label12.TabIndex = 20;
            label12.Text = "¿Nuevo cliente?";
            // 
            // btn_RegistrarCliente
            // 
            btn_RegistrarCliente.Location = new Point(368, 66);
            btn_RegistrarCliente.Name = "btn_RegistrarCliente";
            btn_RegistrarCliente.Size = new Size(91, 49);
            btn_RegistrarCliente.TabIndex = 19;
            btn_RegistrarCliente.Text = "Registrar cliente";
            btn_RegistrarCliente.UseVisualStyleBackColor = true;
            btn_RegistrarCliente.Click += btn_RegistrarCliente_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(103, 132);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(70, 24);
            radioButton4.TabIndex = 13;
            radioButton4.TabStop = true;
            radioButton4.Text = "Nuevo";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btn_PrestarLibro
            // 
            btn_PrestarLibro.Location = new Point(391, 203);
            btn_PrestarLibro.Name = "btn_PrestarLibro";
            btn_PrestarLibro.Size = new Size(108, 53);
            btn_PrestarLibro.TabIndex = 12;
            btn_PrestarLibro.Text = "Prestar Ejemplar";
            btn_PrestarLibro.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(170, 231);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 236);
            label10.Name = "label10";
            label10.Size = new Size(148, 20);
            label10.TabIndex = 10;
            label10.Text = "Fecha de devolucion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 106);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 3;
            label6.Text = "Estado de ejemplar:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 132);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Original";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 203);
            label9.Name = "label9";
            label9.Size = new Size(138, 20);
            label9.TabIndex = 9;
            label9.Text = "Fecha de prestamo:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(14, 160);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Usado";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(170, 198);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(103, 160);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(61, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Viejo";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(87, 26);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(149, 28);
            comboBox2.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 34);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 6;
            label8.Text = "Cliente:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 27);
            textBox3.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 66);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 4;
            label7.Text = "Ubicacion:";
            // 
            // lB_LibrosPrestados
            // 
            lB_LibrosPrestados.FormattingEnabled = true;
            lB_LibrosPrestados.ItemHeight = 20;
            lB_LibrosPrestados.Location = new Point(6, 26);
            lB_LibrosPrestados.Name = "lB_LibrosPrestados";
            lB_LibrosPrestados.Size = new Size(471, 444);
            lB_LibrosPrestados.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lB_LibrosPrestados);
            groupBox3.Location = new Point(548, 57);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(483, 476);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Libros prestados";
            // 
            // button1
            // 
            button1.Location = new Point(391, 135);
            button1.Name = "button1";
            button1.Size = new Size(91, 28);
            button1.TabIndex = 17;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(242, 25);
            button2.Name = "button2";
            button2.Size = new Size(91, 28);
            button2.TabIndex = 18;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 621);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Biblioteca";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox tBox_Titulo_Libro;
        private GroupBox groupBox1;
        private ListBox lB_LibrosDisponibles;
        private TextBox tB_AutorLibro;
        private Label label5;
        private ComboBox cB_GeneroLibro;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Label label6;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label14;
        private TextBox tB_Editorial;
        private Label label13;
        private Button btn_PrestarLibro;
        private DateTimePicker dateTimePicker2;
        private Label label10;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private Button btn_RegistrarLibro;
        private Label label11;
        private Label label2;
        private Label label15;
        private Label label12;
        private Button btn_RegistrarCliente;
        private RadioButton radioButton4;
        private ListBox lB_LibrosPrestados;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
    }
}