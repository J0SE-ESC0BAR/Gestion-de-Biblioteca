namespace Biblioteca
{
    partial class Usuario
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
            txtId = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            groupBox2 = new GroupBox();
            radEliminar = new RadioButton();
            radModificar = new RadioButton();
            radAgregar = new RadioButton();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 76);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(25, 80);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(273, 173);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del cliente";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(98, 18);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(144, 23);
            txtId.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(98, 145);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(144, 23);
            txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 20);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 6;
            label6.Text = "Id:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(98, 120);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(144, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(98, 95);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(144, 23);
            txtDireccion.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(98, 70);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(144, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 46);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(144, 23);
            txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 150);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 125);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 100);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Direccion:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(214, 257);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(84, 48);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Aplicar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(20, 257);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 46);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radEliminar);
            groupBox2.Controls.Add(radModificar);
            groupBox2.Controls.Add(radAgregar);
            groupBox2.Location = new Point(20, 9);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(285, 56);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // radEliminar
            // 
            radEliminar.AutoSize = true;
            radEliminar.Location = new Point(201, 17);
            radEliminar.Margin = new Padding(3, 2, 3, 2);
            radEliminar.Name = "radEliminar";
            radEliminar.Size = new Size(68, 34);
            radEliminar.TabIndex = 2;
            radEliminar.Text = "Eliminar\r\nUsuario";
            radEliminar.UseVisualStyleBackColor = true;
            radEliminar.CheckedChanged += radEliminar_CheckedChanged;
            // 
            // radModificar
            // 
            radModificar.AutoSize = true;
            radModificar.Location = new Point(106, 17);
            radModificar.Margin = new Padding(3, 2, 3, 2);
            radModificar.Name = "radModificar";
            radModificar.Size = new Size(76, 34);
            radModificar.TabIndex = 1;
            radModificar.Text = "Modificar\r\nUsuario";
            radModificar.UseVisualStyleBackColor = true;
            radModificar.CheckedChanged += radModificar_CheckedChanged;
            // 
            // radAgregar
            // 
            radAgregar.AutoSize = true;
            radAgregar.Checked = true;
            radAgregar.Location = new Point(5, 17);
            radAgregar.Margin = new Padding(3, 2, 3, 2);
            radAgregar.Name = "radAgregar";
            radAgregar.Size = new Size(67, 34);
            radAgregar.TabIndex = 0;
            radAgregar.TabStop = true;
            radAgregar.Text = "Agregar\r\nUsuario";
            radAgregar.UseVisualStyleBackColor = true;
            radAgregar.CheckedChanged += radAgregar_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(122, 257);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(84, 48);
            button1.TabIndex = 6;
            button1.Text = "Mostrar\r\nusuarios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 314);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Usuario";
            Text = "Registro del Usuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnRegistrar;
        private Button btnCancelar;
        private TextBox txtId;
        private Label label6;
        private GroupBox groupBox2;
        private RadioButton radEliminar;
        private RadioButton radModificar;
        private RadioButton radAgregar;
        private Button button1;
    }
}