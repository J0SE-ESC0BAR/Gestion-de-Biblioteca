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
            textBox1 = new TextBox();
            button1 = new Button();
            radioButton5 = new RadioButton();
            boton_RegistrarLibro = new Button();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dataGridView_LibrosDisponibles = new DataGridView();
            id_libro = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            año_publicacion = new DataGridViewTextBoxColumn();
            boton_EliminarLibro = new Button();
            label11 = new Label();
            label2 = new Label();
            label_LibrosDisponibles = new Label();
            labelBusquedaPor = new Label();
            groupBox_AsignarPrestamo = new GroupBox();
            boton_EliminarCliente = new Button();
            label15 = new Label();
            label12 = new Label();
            boton_RegistrarCliente = new Button();
            radioButton_Nuevo = new RadioButton();
            boton_PrestarLibro = new Button();
            dateTimePicker_FechaDevolucion = new DateTimePicker();
            label_FechaDevolucion = new Label();
            label_EstadoEjemplar = new Label();
            radioButton_Original = new RadioButton();
            label_FechaPrestamo = new Label();
            radioButton_Usado = new RadioButton();
            dateTimePicker_FechaPrestamo = new DateTimePicker();
            radioButton_Viejo = new RadioButton();
            comboBox_Cliente = new ComboBox();
            label_Cliente = new Label();
            textBox_Ubicacion = new TextBox();
            labelUbicacion = new Label();
            listBox_LibrosPrestados = new ListBox();
            groupBox_ListaLibrosPrestados = new GroupBox();
            groupBox_BuscarLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LibrosDisponibles).BeginInit();
            groupBox_AsignarPrestamo.SuspendLayout();
            groupBox_ListaLibrosPrestados.SuspendLayout();
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
            // groupBox_BuscarLibro
            // 
            groupBox_BuscarLibro.Controls.Add(textBox1);
            groupBox_BuscarLibro.Controls.Add(button1);
            groupBox_BuscarLibro.Controls.Add(radioButton5);
            groupBox_BuscarLibro.Controls.Add(boton_RegistrarLibro);
            groupBox_BuscarLibro.Controls.Add(radioButton4);
            groupBox_BuscarLibro.Controls.Add(radioButton3);
            groupBox_BuscarLibro.Controls.Add(radioButton2);
            groupBox_BuscarLibro.Controls.Add(radioButton1);
            groupBox_BuscarLibro.Controls.Add(dataGridView_LibrosDisponibles);
            groupBox_BuscarLibro.Controls.Add(boton_EliminarLibro);
            groupBox_BuscarLibro.Controls.Add(label11);
            groupBox_BuscarLibro.Controls.Add(label2);
            groupBox_BuscarLibro.Controls.Add(label_LibrosDisponibles);
            groupBox_BuscarLibro.Controls.Add(labelBusquedaPor);
            groupBox_BuscarLibro.Location = new Point(32, 57);
            groupBox_BuscarLibro.Name = "groupBox_BuscarLibro";
            groupBox_BuscarLibro.Size = new Size(594, 187);
            groupBox_BuscarLibro.TabIndex = 4;
            groupBox_BuscarLibro.TabStop = false;
            groupBox_BuscarLibro.Text = "Busqueda de libro";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(110, 138);
            button1.Name = "button1";
            button1.Size = new Size(86, 27);
            button1.TabIndex = 23;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(14, 118);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(54, 24);
            radioButton5.TabIndex = 22;
            radioButton5.TabStop = true;
            radioButton5.Text = "Año";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // boton_RegistrarLibro
            // 
            boton_RegistrarLibro.Location = new Point(489, 83);
            boton_RegistrarLibro.Name = "boton_RegistrarLibro";
            boton_RegistrarLibro.Size = new Size(91, 52);
            boton_RegistrarLibro.TabIndex = 16;
            boton_RegistrarLibro.Text = "Registrar libro";
            boton_RegistrarLibro.UseVisualStyleBackColor = true;
            boton_RegistrarLibro.Click += btn_RegistrarLibro_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(14, 138);
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
            radioButton3.Location = new Point(14, 97);
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
            // dataGridView_LibrosDisponibles
            // 
            dataGridView_LibrosDisponibles.AllowUserToAddRows = false;
            dataGridView_LibrosDisponibles.AllowUserToDeleteRows = false;
            dataGridView_LibrosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_LibrosDisponibles.Columns.AddRange(new DataGridViewColumn[] { id_libro, titulo, año_publicacion });
            dataGridView_LibrosDisponibles.Location = new Point(226, 57);
            dataGridView_LibrosDisponibles.Name = "dataGridView_LibrosDisponibles";
            dataGridView_LibrosDisponibles.ReadOnly = true;
            dataGridView_LibrosDisponibles.RowTemplate.Height = 29;
            dataGridView_LibrosDisponibles.Size = new Size(249, 109);
            dataGridView_LibrosDisponibles.TabIndex = 9;
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
            // 
            // año_publicacion
            // 
            año_publicacion.HeaderText = "Año";
            año_publicacion.Name = "año_publicacion";
            año_publicacion.ReadOnly = true;
            año_publicacion.Width = 45;
            // 
            // boton_EliminarLibro
            // 
            boton_EliminarLibro.Location = new Point(489, 135);
            boton_EliminarLibro.Name = "boton_EliminarLibro";
            boton_EliminarLibro.Size = new Size(91, 28);
            boton_EliminarLibro.TabIndex = 17;
            boton_EliminarLibro.Text = "Eliminar";
            boton_EliminarLibro.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(489, 54);
            label11.Name = "label11";
            label11.Size = new Size(84, 20);
            label11.TabIndex = 15;
            label11.Text = "nuevo libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 34);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 14;
            label2.Text = "Registrar";
            // 
            // label_LibrosDisponibles
            // 
            label_LibrosDisponibles.AutoSize = true;
            label_LibrosDisponibles.Location = new Point(230, 32);
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
            groupBox_AsignarPrestamo.Controls.Add(boton_EliminarCliente);
            groupBox_AsignarPrestamo.Controls.Add(label15);
            groupBox_AsignarPrestamo.Controls.Add(label12);
            groupBox_AsignarPrestamo.Controls.Add(boton_RegistrarCliente);
            groupBox_AsignarPrestamo.Controls.Add(radioButton_Nuevo);
            groupBox_AsignarPrestamo.Controls.Add(boton_PrestarLibro);
            groupBox_AsignarPrestamo.Controls.Add(dateTimePicker_FechaDevolucion);
            groupBox_AsignarPrestamo.Controls.Add(label_FechaDevolucion);
            groupBox_AsignarPrestamo.Controls.Add(label_EstadoEjemplar);
            groupBox_AsignarPrestamo.Controls.Add(radioButton_Original);
            groupBox_AsignarPrestamo.Controls.Add(label_FechaPrestamo);
            groupBox_AsignarPrestamo.Controls.Add(radioButton_Usado);
            groupBox_AsignarPrestamo.Controls.Add(dateTimePicker_FechaPrestamo);
            groupBox_AsignarPrestamo.Controls.Add(radioButton_Viejo);
            groupBox_AsignarPrestamo.Controls.Add(comboBox_Cliente);
            groupBox_AsignarPrestamo.Controls.Add(label_Cliente);
            groupBox_AsignarPrestamo.Controls.Add(textBox_Ubicacion);
            groupBox_AsignarPrestamo.Controls.Add(labelUbicacion);
            groupBox_AsignarPrestamo.Location = new Point(32, 261);
            groupBox_AsignarPrestamo.Name = "groupBox_AsignarPrestamo";
            groupBox_AsignarPrestamo.Size = new Size(594, 272);
            groupBox_AsignarPrestamo.TabIndex = 6;
            groupBox_AsignarPrestamo.TabStop = false;
            groupBox_AsignarPrestamo.Text = "Prestamo de ejemplar";
            // 
            // boton_EliminarCliente
            // 
            boton_EliminarCliente.Location = new Point(242, 25);
            boton_EliminarCliente.Name = "boton_EliminarCliente";
            boton_EliminarCliente.Size = new Size(91, 28);
            boton_EliminarCliente.TabIndex = 18;
            boton_EliminarCliente.Text = "Eliminar";
            boton_EliminarCliente.UseVisualStyleBackColor = true;
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
            // boton_RegistrarCliente
            // 
            boton_RegistrarCliente.Location = new Point(368, 66);
            boton_RegistrarCliente.Name = "boton_RegistrarCliente";
            boton_RegistrarCliente.Size = new Size(91, 49);
            boton_RegistrarCliente.TabIndex = 19;
            boton_RegistrarCliente.Text = "Registrar cliente";
            boton_RegistrarCliente.UseVisualStyleBackColor = true;
            boton_RegistrarCliente.Click += btn_RegistrarCliente_Click;
            // 
            // radioButton_Nuevo
            // 
            radioButton_Nuevo.AutoSize = true;
            radioButton_Nuevo.Location = new Point(103, 132);
            radioButton_Nuevo.Name = "radioButton_Nuevo";
            radioButton_Nuevo.Size = new Size(70, 24);
            radioButton_Nuevo.TabIndex = 13;
            radioButton_Nuevo.TabStop = true;
            radioButton_Nuevo.Text = "Nuevo";
            radioButton_Nuevo.UseVisualStyleBackColor = true;
            // 
            // boton_PrestarLibro
            // 
            boton_PrestarLibro.Location = new Point(391, 203);
            boton_PrestarLibro.Name = "boton_PrestarLibro";
            boton_PrestarLibro.Size = new Size(108, 53);
            boton_PrestarLibro.TabIndex = 12;
            boton_PrestarLibro.Text = "Prestar Ejemplar";
            boton_PrestarLibro.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_FechaDevolucion
            // 
            dateTimePicker_FechaDevolucion.Location = new Point(170, 231);
            dateTimePicker_FechaDevolucion.Name = "dateTimePicker_FechaDevolucion";
            dateTimePicker_FechaDevolucion.Size = new Size(200, 27);
            dateTimePicker_FechaDevolucion.TabIndex = 11;
            // 
            // label_FechaDevolucion
            // 
            label_FechaDevolucion.AutoSize = true;
            label_FechaDevolucion.Location = new Point(7, 236);
            label_FechaDevolucion.Name = "label_FechaDevolucion";
            label_FechaDevolucion.Size = new Size(148, 20);
            label_FechaDevolucion.TabIndex = 10;
            label_FechaDevolucion.Text = "Fecha de devolucion:";
            // 
            // label_EstadoEjemplar
            // 
            label_EstadoEjemplar.AutoSize = true;
            label_EstadoEjemplar.Location = new Point(6, 106);
            label_EstadoEjemplar.Name = "label_EstadoEjemplar";
            label_EstadoEjemplar.Size = new Size(141, 20);
            label_EstadoEjemplar.TabIndex = 3;
            label_EstadoEjemplar.Text = "Estado de ejemplar:";
            // 
            // radioButton_Original
            // 
            radioButton_Original.AutoSize = true;
            radioButton_Original.Location = new Point(14, 132);
            radioButton_Original.Name = "radioButton_Original";
            radioButton_Original.Size = new Size(80, 24);
            radioButton_Original.TabIndex = 0;
            radioButton_Original.TabStop = true;
            radioButton_Original.Text = "Original";
            radioButton_Original.UseVisualStyleBackColor = true;
            // 
            // label_FechaPrestamo
            // 
            label_FechaPrestamo.AutoSize = true;
            label_FechaPrestamo.Location = new Point(7, 203);
            label_FechaPrestamo.Name = "label_FechaPrestamo";
            label_FechaPrestamo.Size = new Size(138, 20);
            label_FechaPrestamo.TabIndex = 9;
            label_FechaPrestamo.Text = "Fecha de prestamo:";
            // 
            // radioButton_Usado
            // 
            radioButton_Usado.AutoSize = true;
            radioButton_Usado.Location = new Point(14, 160);
            radioButton_Usado.Name = "radioButton_Usado";
            radioButton_Usado.Size = new Size(69, 24);
            radioButton_Usado.TabIndex = 1;
            radioButton_Usado.TabStop = true;
            radioButton_Usado.Text = "Usado";
            radioButton_Usado.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_FechaPrestamo
            // 
            dateTimePicker_FechaPrestamo.Location = new Point(170, 198);
            dateTimePicker_FechaPrestamo.Name = "dateTimePicker_FechaPrestamo";
            dateTimePicker_FechaPrestamo.Size = new Size(200, 27);
            dateTimePicker_FechaPrestamo.TabIndex = 8;
            // 
            // radioButton_Viejo
            // 
            radioButton_Viejo.AutoSize = true;
            radioButton_Viejo.Location = new Point(103, 160);
            radioButton_Viejo.Name = "radioButton_Viejo";
            radioButton_Viejo.Size = new Size(61, 24);
            radioButton_Viejo.TabIndex = 2;
            radioButton_Viejo.TabStop = true;
            radioButton_Viejo.Text = "Viejo";
            radioButton_Viejo.UseVisualStyleBackColor = true;
            // 
            // comboBox_Cliente
            // 
            comboBox_Cliente.FormattingEnabled = true;
            comboBox_Cliente.Location = new Point(87, 26);
            comboBox_Cliente.Name = "comboBox_Cliente";
            comboBox_Cliente.Size = new Size(149, 28);
            comboBox_Cliente.TabIndex = 7;
            // 
            // label_Cliente
            // 
            label_Cliente.AutoSize = true;
            label_Cliente.Location = new Point(6, 34);
            label_Cliente.Name = "label_Cliente";
            label_Cliente.Size = new Size(58, 20);
            label_Cliente.TabIndex = 6;
            label_Cliente.Text = "Cliente:";
            // 
            // textBox_Ubicacion
            // 
            textBox_Ubicacion.Location = new Point(87, 60);
            textBox_Ubicacion.Name = "textBox_Ubicacion";
            textBox_Ubicacion.Size = new Size(149, 27);
            textBox_Ubicacion.TabIndex = 5;
            // 
            // labelUbicacion
            // 
            labelUbicacion.AutoSize = true;
            labelUbicacion.Location = new Point(6, 66);
            labelUbicacion.Name = "labelUbicacion";
            labelUbicacion.Size = new Size(78, 20);
            labelUbicacion.TabIndex = 4;
            labelUbicacion.Text = "Ubicacion:";
            // 
            // listBox_LibrosPrestados
            // 
            listBox_LibrosPrestados.FormattingEnabled = true;
            listBox_LibrosPrestados.ItemHeight = 20;
            listBox_LibrosPrestados.Location = new Point(6, 26);
            listBox_LibrosPrestados.Name = "listBox_LibrosPrestados";
            listBox_LibrosPrestados.Size = new Size(471, 444);
            listBox_LibrosPrestados.TabIndex = 7;
            // 
            // groupBox_ListaLibrosPrestados
            // 
            groupBox_ListaLibrosPrestados.Controls.Add(listBox_LibrosPrestados);
            groupBox_ListaLibrosPrestados.Location = new Point(632, 57);
            groupBox_ListaLibrosPrestados.Name = "groupBox_ListaLibrosPrestados";
            groupBox_ListaLibrosPrestados.Size = new Size(482, 476);
            groupBox_ListaLibrosPrestados.TabIndex = 8;
            groupBox_ListaLibrosPrestados.TabStop = false;
            groupBox_ListaLibrosPrestados.Text = "Libros prestados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 621);
            Controls.Add(groupBox_ListaLibrosPrestados);
            Controls.Add(groupBox_AsignarPrestamo);
            Controls.Add(groupBox_BuscarLibro);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Biblioteca";
            Load += Form1_Load;
            groupBox_BuscarLibro.ResumeLayout(false);
            groupBox_BuscarLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LibrosDisponibles).EndInit();
            groupBox_AsignarPrestamo.ResumeLayout(false);
            groupBox_AsignarPrestamo.PerformLayout();
            groupBox_ListaLibrosPrestados.ResumeLayout(false);
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
        private Label label_EstadoEjemplar;
        private RadioButton radioButton_Viejo;
        private RadioButton radioButton_Usado;
        private RadioButton radioButton_Original;
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
        private TextBox textBox_Ubicacion;
        private Label labelUbicacion;
        private Button boton_RegistrarLibro;
        private Label label11;
        private Label label2;
        private Label label15;
        private Label label12;
        private Button boton_RegistrarCliente;
        private RadioButton radioButton_Nuevo;
        private ListBox listBox_LibrosPrestados;
        private GroupBox groupBox_ListaLibrosPrestados;
        private Button boton_EliminarLibro;
        private Button boton_EliminarCliente;
        public DataGridView dataGridView_LibrosDisponibles;
        private DataGridViewTextBoxColumn id_libro;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn año_publicacion;
        private Button button1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
    }
}