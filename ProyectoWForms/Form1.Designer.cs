namespace ProyectoWForms
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
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido1 = new TextBox();
            txtEdad = new TextBox();
            label4 = new Label();
            txtAltura = new TextBox();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            boxImagen = new PictureBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            txtMensaje = new Label();
            btnCrear = new Button();
            btnEliminar = new Button();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            txtDni = new TextBox();
            txtLetra = new TextBox();
            lblLetra = new Label();
            lblDni = new Label();
            label6 = new Label();
            txtRecuento = new TextBox();
            label7 = new Label();
            btnCargar = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)boxImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 89);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 130);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Primer Apellido: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 88);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(170, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido1
            // 
            txtApellido1.Location = new Point(170, 124);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new Size(125, 27);
            txtApellido1.TabIndex = 4;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(448, 82);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 124);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 6;
            label4.Text = "Altura (metros):";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(448, 121);
            txtAltura.Margin = new Padding(3, 4, 3, 4);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 7;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(355, 372);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(86, 31);
            btnAnterior.TabIndex = 8;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(505, 372);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(86, 31);
            btnSiguiente.TabIndex = 9;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // boxImagen
            // 
            boxImagen.Location = new Point(215, 202);
            boxImagen.Name = "boxImagen";
            boxImagen.Size = new Size(194, 74);
            boxImagen.SizeMode = PictureBoxSizeMode.AutoSize;
            boxImagen.TabIndex = 10;
            boxImagen.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(514, 212);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(253, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Es la primera vez que me inscribo";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 179);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 12;
            label5.Text = "Imágen de Usuario";
            // 
            // txtMensaje
            // 
            txtMensaje.AutoSize = true;
            txtMensaje.Location = new Point(495, 239);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(290, 20);
            txtMensaje.TabIndex = 13;
            txtMensaje.Text = "Esperamos que tuvieras buena experiencia";
            txtMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(215, 471);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(141, 29);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Añadir Alumno";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(404, 471);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 29);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar Alumno";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(304, 529);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 17;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(549, 529);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(726, 84);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 19;
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(726, 121);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(125, 27);
            txtLetra.TabIndex = 20;
            // 
            // lblLetra
            // 
            lblLetra.AutoSize = true;
            lblLetra.Location = new Point(606, 124);
            lblLetra.Name = "lblLetra";
            lblLetra.Size = new Size(75, 20);
            lblLetra.TabIndex = 21;
            lblLetra.Text = "Letra DNI:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(606, 87);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(96, 20);
            lblDni.TabIndex = 22;
            lblDni.Text = "Numero DNI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 35);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 23;
            label6.Text = "Datos Alumno";
            // 
            // txtRecuento
            // 
            txtRecuento.Location = new Point(759, 603);
            txtRecuento.Name = "txtRecuento";
            txtRecuento.Size = new Size(125, 27);
            txtRecuento.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(643, 606);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 25;
            label7.Text = "Total alumnos: ";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(171, 372);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(88, 33);
            btnCargar.TabIndex = 26;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(693, 372);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 34);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(597, 471);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 29);
            btnModificar.TabIndex = 28;
            btnModificar.Text = "Modificar Alumno";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(971, 672);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargar);
            Controls.Add(label7);
            Controls.Add(txtRecuento);
            Controls.Add(label6);
            Controls.Add(lblDni);
            Controls.Add(lblLetra);
            Controls.Add(txtLetra);
            Controls.Add(txtDni);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(txtMensaje);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(boxImagen);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(txtAltura);
            Controls.Add(label4);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido1);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)boxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido1;
        private TextBox txtEdad;
        private Label label4;
        private TextBox txtAltura;
        private Button btnAnterior;
        private Button btnSiguiente;
        private PictureBox boxImagen;
        private CheckBox checkBox1;
        private Label label5;
        private Label txtMensaje;
        private Button btnCrear;
        private Button btnEliminar;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtDni;
        private TextBox txtLetra;
        private Label lblLetra;
        private Label lblDni;
        private Label label6;
        private TextBox txtRecuento;
        private Label label7;
        private Button btnCargar;
        private Button btnGuardar;
        private Button btnModificar;
    }
}