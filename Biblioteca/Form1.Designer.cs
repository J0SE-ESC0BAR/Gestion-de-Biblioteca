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
            groupBox_BuscarLibro = new GroupBox();
            btn_mdificarLibro = new Button();
            radioButton6 = new RadioButton();
            textBox1 = new TextBox();
            button1 = new Button();
            radioButton5 = new RadioButton();
            dataGridView_LibrosDisponibles = new DataGridView();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label_LibrosDisponibles = new Label();
            labelBusquedaPor = new Label();
            groupBox_AsignarPrestamo = new GroupBox();
            label2 = new Label();
            btn_mdificarUsuario = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            boton_PrestarLibro = new Button();
            dateTimePicker_FechaDevolucion = new DateTimePicker();
            label_FechaDevolucion = new Label();
            label_FechaPrestamo = new Label();
            dateTimePicker_FechaPrestamo = new DateTimePicker();
            comboBox_Cliente = new ComboBox();
            label_Cliente = new Label();
            groupBox_ListaLibrosPrestados = new GroupBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            id_libro = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            autor = new DataGridViewTextBoxColumn();
            año_publicacion = new DataGridViewTextBoxColumn();
            editorial = new DataGridViewTextBoxColumn();
            groupBox_BuscarLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LibrosDisponibles).BeginInit();
            groupBox_AsignarPrestamo.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox_ListaLibrosPrestados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 2;
            label1.Text = "Sistema de biblioteca";
            // 
            // groupBox_BuscarLibro
            // 
            groupBox_BuscarLibro.Controls.Add(btn_mdificarLibro);
            groupBox_BuscarLibro.Controls.Add(radioButton6);
            groupBox_BuscarLibro.Controls.Add(textBox1);
            groupBox_BuscarLibro.Controls.Add(button1);
            groupBox_BuscarLibro.Controls.Add(radioButton5);
            groupBox_BuscarLibro.Controls.Add(dataGridView_LibrosDisponibles);
            groupBox_BuscarLibro.Controls.Add(radioButton4);
            groupBox_BuscarLibro.Controls.Add(radioButton3);
            groupBox_BuscarLibro.Controls.Add(radioButton2);
            groupBox_BuscarLibro.Controls.Add(radioButton1);
            groupBox_BuscarLibro.Controls.Add(label_LibrosDisponibles);
            groupBox_BuscarLibro.Controls.Add(labelBusquedaPor);
            groupBox_BuscarLibro.Location = new Point(32, 45);
            groupBox_BuscarLibro.Name = "groupBox_BuscarLibro";
            groupBox_BuscarLibro.Size = new Size(481, 361);
            groupBox_BuscarLibro.TabIndex = 4;
            groupBox_BuscarLibro.TabStop = false;
            groupBox_BuscarLibro.Text = "Catalogo de libros";
            // 
            // btn_mdificarLibro
            // 
            btn_mdificarLibro.Location = new Point(348, 320);
            btn_mdificarLibro.Name = "btn_mdificarLibro";
            btn_mdificarLibro.Size = new Size(108, 34);
            btn_mdificarLibro.TabIndex = 13;
            btn_mdificarLibro.Text = "Modificar";
            btn_mdificarLibro.UseVisualStyleBackColor = true;
            btn_mdificarLibro.Click += btn_mdificarLibro_Click;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Checked = true;
            radioButton6.Location = new Point(170, 77);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(67, 24);
            radioButton6.TabIndex = 23;
            radioButton6.TabStop = true;
            radioButton6.Text = "Todos";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(182, 115);
            button1.Name = "button1";
            button1.Size = new Size(80, 31);
            button1.TabIndex = 23;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(91, 77);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(54, 24);
            radioButton5.TabIndex = 22;
            radioButton5.TabStop = true;
            radioButton5.Text = "Año";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // dataGridView_LibrosDisponibles
            // 
            dataGridView_LibrosDisponibles.AllowUserToAddRows = false;
            dataGridView_LibrosDisponibles.AllowUserToDeleteRows = false;
            dataGridView_LibrosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_LibrosDisponibles.Columns.AddRange(new DataGridViewColumn[] { id_libro, titulo, autor, año_publicacion, editorial });
            dataGridView_LibrosDisponibles.Location = new Point(10, 175);
            dataGridView_LibrosDisponibles.Name = "dataGridView_LibrosDisponibles";
            dataGridView_LibrosDisponibles.ReadOnly = true;
            dataGridView_LibrosDisponibles.RowTemplate.Height = 29;
            dataGridView_LibrosDisponibles.Size = new Size(446, 139);
            dataGridView_LibrosDisponibles.TabIndex = 9;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(170, 57);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(83, 24);
            radioButton4.TabIndex = 21;
            radioButton4.TabStop = true;
            radioButton4.Text = "Editorial";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(91, 57);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(64, 24);
            radioButton3.TabIndex = 20;
            radioButton3.TabStop = true;
            radioButton3.Text = "Autor";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(14, 77);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 24);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "Titulo";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 57);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(42, 24);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "ID";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label_LibrosDisponibles
            // 
            label_LibrosDisponibles.AutoSize = true;
            label_LibrosDisponibles.Location = new Point(6, 152);
            label_LibrosDisponibles.Name = "label_LibrosDisponibles";
            label_LibrosDisponibles.Size = new Size(132, 20);
            label_LibrosDisponibles.TabIndex = 13;
            label_LibrosDisponibles.Text = "Libros disponibles:";
            // 
            // labelBusquedaPor
            // 
            labelBusquedaPor.AutoSize = true;
            labelBusquedaPor.Location = new Point(14, 32);
            labelBusquedaPor.Name = "labelBusquedaPor";
            labelBusquedaPor.Size = new Size(104, 20);
            labelBusquedaPor.TabIndex = 4;
            labelBusquedaPor.Text = "Busqueda por:";
            // 
            // groupBox_AsignarPrestamo
            // 
            groupBox_AsignarPrestamo.Controls.Add(label2);
            groupBox_AsignarPrestamo.Controls.Add(btn_mdificarUsuario);
            groupBox_AsignarPrestamo.Controls.Add(textBox2);
            groupBox_AsignarPrestamo.Controls.Add(label3);
            groupBox_AsignarPrestamo.Controls.Add(groupBox1);
            groupBox_AsignarPrestamo.Controls.Add(boton_PrestarLibro);
            groupBox_AsignarPrestamo.Controls.Add(dateTimePicker_FechaDevolucion);
            groupBox_AsignarPrestamo.Controls.Add(label_FechaDevolucion);
            groupBox_AsignarPrestamo.Controls.Add(label_FechaPrestamo);
            groupBox_AsignarPrestamo.Controls.Add(dateTimePicker_FechaPrestamo);
            groupBox_AsignarPrestamo.Controls.Add(comboBox_Cliente);
            groupBox_AsignarPrestamo.Controls.Add(label_Cliente);
            groupBox_AsignarPrestamo.Location = new Point(532, 45);
            groupBox_AsignarPrestamo.Name = "groupBox_AsignarPrestamo";
            groupBox_AsignarPrestamo.Size = new Size(516, 361);
            groupBox_AsignarPrestamo.TabIndex = 6;
            groupBox_AsignarPrestamo.TabStop = false;
            groupBox_AsignarPrestamo.Text = "Informacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 29);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 26;
            label2.Text = "Modificar usuario";
            // 
            // btn_mdificarUsuario
            // 
            btn_mdificarUsuario.Location = new Point(392, 52);
            btn_mdificarUsuario.Name = "btn_mdificarUsuario";
            btn_mdificarUsuario.Size = new Size(108, 34);
            btn_mdificarUsuario.TabIndex = 14;
            btn_mdificarUsuario.Text = "Modificar";
            btn_mdificarUsuario.UseVisualStyleBackColor = true;
            btn_mdificarUsuario.Click += btn_mdificarUsuario_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 27);
            textBox2.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 67);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 22;
            label3.Text = "Ubicacion:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton8);
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Location = new Point(14, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 49);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(94, 19);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(86, 24);
            radioButton8.TabIndex = 18;
            radioButton8.TabStop = true;
            radioButton8.Text = "Ejemplar";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 19);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(61, 24);
            radioButton7.TabIndex = 17;
            radioButton7.TabStop = true;
            radioButton7.Text = "Libro";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // boton_PrestarLibro
            // 
            boton_PrestarLibro.Location = new Point(393, 286);
            boton_PrestarLibro.Name = "boton_PrestarLibro";
            boton_PrestarLibro.Size = new Size(108, 53);
            boton_PrestarLibro.TabIndex = 12;
            boton_PrestarLibro.Text = "Prestar libro";
            boton_PrestarLibro.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_FechaDevolucion
            // 
            dateTimePicker_FechaDevolucion.Location = new Point(172, 314);
            dateTimePicker_FechaDevolucion.Name = "dateTimePicker_FechaDevolucion";
            dateTimePicker_FechaDevolucion.Size = new Size(200, 27);
            dateTimePicker_FechaDevolucion.TabIndex = 11;
            dateTimePicker_FechaDevolucion.Value = new DateTime(2023, 5, 12, 0, 0, 0, 0);
            // 
            // label_FechaDevolucion
            // 
            label_FechaDevolucion.AutoSize = true;
            label_FechaDevolucion.Location = new Point(14, 319);
            label_FechaDevolucion.Name = "label_FechaDevolucion";
            label_FechaDevolucion.Size = new Size(148, 20);
            label_FechaDevolucion.TabIndex = 10;
            label_FechaDevolucion.Text = "Fecha de devolucion:";
            // 
            // label_FechaPrestamo
            // 
            label_FechaPrestamo.AutoSize = true;
            label_FechaPrestamo.Location = new Point(14, 286);
            label_FechaPrestamo.Name = "label_FechaPrestamo";
            label_FechaPrestamo.Size = new Size(138, 20);
            label_FechaPrestamo.TabIndex = 9;
            label_FechaPrestamo.Text = "Fecha de prestamo:";
            // 
            // dateTimePicker_FechaPrestamo
            // 
            dateTimePicker_FechaPrestamo.Location = new Point(172, 281);
            dateTimePicker_FechaPrestamo.MaxDate = new DateTime(2023, 5, 12, 0, 0, 0, 0);
            dateTimePicker_FechaPrestamo.Name = "dateTimePicker_FechaPrestamo";
            dateTimePicker_FechaPrestamo.Size = new Size(200, 27);
            dateTimePicker_FechaPrestamo.TabIndex = 8;
            dateTimePicker_FechaPrestamo.Value = new DateTime(2023, 5, 12, 0, 0, 0, 0);
            // 
            // comboBox_Cliente
            // 
            comboBox_Cliente.FormattingEnabled = true;
            comboBox_Cliente.Location = new Point(114, 29);
            comboBox_Cliente.Name = "comboBox_Cliente";
            comboBox_Cliente.Size = new Size(149, 28);
            comboBox_Cliente.TabIndex = 7;
            // 
            // label_Cliente
            // 
            label_Cliente.AutoSize = true;
            label_Cliente.Location = new Point(14, 32);
            label_Cliente.Name = "label_Cliente";
            label_Cliente.Size = new Size(62, 20);
            label_Cliente.TabIndex = 6;
            label_Cliente.Text = "Usuario:";
            // 
            // groupBox_ListaLibrosPrestados
            // 
            groupBox_ListaLibrosPrestados.Controls.Add(dataGridView1);
            groupBox_ListaLibrosPrestados.Location = new Point(32, 431);
            groupBox_ListaLibrosPrestados.Name = "groupBox_ListaLibrosPrestados";
            groupBox_ListaLibrosPrestados.Size = new Size(1016, 303);
            groupBox_ListaLibrosPrestados.TabIndex = 8;
            groupBox_ListaLibrosPrestados.TabStop = false;
            groupBox_ListaLibrosPrestados.Text = "Libros prestados";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1004, 271);
            dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(925, 740);
            button2.Name = "button2";
            button2.Size = new Size(108, 34);
            button2.TabIndex = 9;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(811, 740);
            button3.Name = "button3";
            button3.Size = new Size(108, 34);
            button3.TabIndex = 10;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            // 
            // id_libro
            // 
            id_libro.HeaderText = "ID";
            id_libro.Name = "id_libro";
            id_libro.ReadOnly = true;
            id_libro.Width = 40;
            // 
            // titulo
            // 
            titulo.HeaderText = "Titulo";
            titulo.Name = "titulo";
            titulo.ReadOnly = true;
            titulo.Width = 140;
            // 
            // autor
            // 
            autor.HeaderText = "Autor";
            autor.Name = "autor";
            autor.ReadOnly = true;
            autor.Width = 75;
            // 
            // año_publicacion
            // 
            año_publicacion.HeaderText = "Año";
            año_publicacion.Name = "año_publicacion";
            año_publicacion.ReadOnly = true;
            año_publicacion.Width = 63;
            // 
            // editorial
            // 
            editorial.HeaderText = "Editorial";
            editorial.Name = "editorial";
            editorial.ReadOnly = true;
            editorial.Width = 85;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 789);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox_ListaLibrosPrestados);
            Controls.Add(groupBox_AsignarPrestamo);
            Controls.Add(groupBox_BuscarLibro);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Biblioteca";
            groupBox_BuscarLibro.ResumeLayout(false);
            groupBox_BuscarLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LibrosDisponibles).EndInit();
            groupBox_AsignarPrestamo.ResumeLayout(false);
            groupBox_AsignarPrestamo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox_ListaLibrosPrestados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox_TituloLibro;
        private GroupBox groupBox_BuscarLibro;
        private TextBox textBox_AutorLibro;
        private Label label_Autor;
        private ComboBox comboBox_GeneroLibro;
        private Label label_Genero;
        private Label labelBusquedaPor;
        private GroupBox groupBox_AsignarPrestamo;
        private Label label_LibrosDisponibles;
        private TextBox textBox_Editorial;
        private Label label_Editorial;
        private Button boton_PrestarLibro;
        private DateTimePicker dateTimePicker_FechaDevolucion;
        private Label label_FechaDevolucion;
        private Label label_FechaPrestamo;
        private DateTimePicker dateTimePicker_FechaPrestamo;
        private ComboBox comboBox_Cliente;
        private Label label_Cliente;
        private GroupBox groupBox_ListaLibrosPrestados;
        public DataGridView dataGridView_LibrosDisponibles;
        private Button button1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private RadioButton radioButton6;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button btn_mdificarLibro;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Button btn_mdificarUsuario;
        private DataGridViewTextBoxColumn id_libro;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn año_publicacion;
        private DataGridViewTextBoxColumn editorial;
    }
}