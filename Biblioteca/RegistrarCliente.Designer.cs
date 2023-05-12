namespace Biblioteca
{
    partial class RegistrarCliente
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
            textBox_Email = new TextBox();
            textBox_Telefono = new TextBox();
            textBox_Direccion = new TextBox();
            textBox_Apellido = new TextBox();
            textBox_Nombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button_Registrar = new Button();
            button_Cancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_Email);
            groupBox1.Controls.Add(textBox_Telefono);
            groupBox1.Controls.Add(textBox_Direccion);
            groupBox1.Controls.Add(textBox_Apellido);
            groupBox1.Controls.Add(textBox_Nombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 187);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del cliente";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(112, 152);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(164, 27);
            textBox_Email.TabIndex = 9;
            // 
            // textBox_Telefono
            // 
            textBox_Telefono.Location = new Point(112, 119);
            textBox_Telefono.Name = "textBox_Telefono";
            textBox_Telefono.Size = new Size(164, 27);
            textBox_Telefono.TabIndex = 8;
            // 
            // textBox_Direccion
            // 
            textBox_Direccion.Location = new Point(112, 86);
            textBox_Direccion.Name = "textBox_Direccion";
            textBox_Direccion.Size = new Size(164, 27);
            textBox_Direccion.TabIndex = 7;
            // 
            // textBox_Apellido
            // 
            textBox_Apellido.Location = new Point(112, 53);
            textBox_Apellido.Name = "textBox_Apellido";
            textBox_Apellido.Size = new Size(164, 27);
            textBox_Apellido.TabIndex = 6;
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(112, 20);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(164, 27);
            textBox_Nombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 159);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 126);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 93);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Direccion:";
            // 
            // button_Registrar
            // 
            button_Registrar.Location = new Point(212, 205);
            button_Registrar.Name = "button_Registrar";
            button_Registrar.Size = new Size(96, 32);
            button_Registrar.TabIndex = 3;
            button_Registrar.Text = "Registrar";
            button_Registrar.UseVisualStyleBackColor = true;
            button_Registrar.Click += button_Registrar_Click;
            // 
            // button_Cancelar
            // 
            button_Cancelar.Location = new Point(49, 205);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(96, 32);
            button_Cancelar.TabIndex = 4;
            button_Cancelar.Text = "Cancelar";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // RegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 249);
            Controls.Add(button_Cancelar);
            Controls.Add(button_Registrar);
            Controls.Add(groupBox1);
            Name = "RegistrarCliente";
            Text = "Registro de cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox_Email;
        private TextBox textBox_Telefono;
        private TextBox textBox_Direccion;
        private TextBox textBox_Apellido;
        private TextBox textBox_Nombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button_Registrar;
        private Button button_Cancelar;
    }
}