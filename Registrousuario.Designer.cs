
namespace WindowsFormsApp1
{
    partial class Registrousuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrousuario));
            this.TextoClave2 = new System.Windows.Forms.TextBox();
            this.ConfirmClave = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.TextoEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.TextoClave = new System.Windows.Forms.TextBox();
            this.TextoNombres = new System.Windows.Forms.TextBox();
            this.TextoAlias = new System.Windows.Forms.TextBox();
            this.Clave = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.Label();
            this.Alias = new System.Windows.Forms.Label();
            this.Activo = new System.Windows.Forms.CheckBox();
            this.ID = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Fechaactual = new System.Windows.Forms.DateTimePicker();
            this.labFecha = new System.Windows.Forms.Label();
            this.TextID = new System.Windows.Forms.MaskedTextBox();
            this.Errores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).BeginInit();
            this.SuspendLayout();
            // 
            // TextoClave2
            // 
            this.TextoClave2.Location = new System.Drawing.Point(413, 165);
            this.TextoClave2.Name = "TextoClave2";
            this.TextoClave2.Size = new System.Drawing.Size(144, 23);
            this.TextoClave2.TabIndex = 28;
            // 
            // ConfirmClave
            // 
            this.ConfirmClave.AutoSize = true;
            this.ConfirmClave.Location = new System.Drawing.Point(314, 168);
            this.ConfirmClave.Name = "ConfirmClave";
            this.ConfirmClave.Size = new System.Drawing.Size(93, 15);
            this.ConfirmClave.TabIndex = 27;
            this.ConfirmClave.Text = "Confirmar Clave";
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Location = new System.Drawing.Point(371, 94);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(24, 15);
            this.Rol.TabIndex = 26;
            this.Rol.Text = "Rol";
            // 
            // comboRol
            // 
            this.comboRol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "Administrador",
            "Ingeniero en sistemas",
            "Profesor",
            "Desarrollador",
            "Ingeniero Civil",
            "Pintor",
            "Doctor",
            "Bombero",
            "Mecanico",
            "Juez",
            "Abogado"});
            this.comboRol.Location = new System.Drawing.Point(413, 91);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(131, 23);
            this.comboRol.TabIndex = 25;
            // 
            // TextoEmail
            // 
            this.TextoEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TextoEmail.Location = new System.Drawing.Point(413, 128);
            this.TextoEmail.Name = "TextoEmail";
            this.TextoEmail.Size = new System.Drawing.Size(199, 23);
            this.TextoEmail.TabIndex = 24;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(371, 131);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 23;
            this.Email.Text = "Email";
            // 
            // TextoClave
            // 
            this.TextoClave.Location = new System.Drawing.Point(84, 165);
            this.TextoClave.Name = "TextoClave";
            this.TextoClave.Size = new System.Drawing.Size(158, 23);
            this.TextoClave.TabIndex = 22;
            // 
            // TextoNombres
            // 
            this.TextoNombres.Location = new System.Drawing.Point(84, 125);
            this.TextoNombres.Name = "TextoNombres";
            this.TextoNombres.Size = new System.Drawing.Size(278, 23);
            this.TextoNombres.TabIndex = 21;
            // 
            // TextoAlias
            // 
            this.TextoAlias.BackColor = System.Drawing.Color.White;
            this.TextoAlias.Location = new System.Drawing.Point(84, 91);
            this.TextoAlias.Name = "TextoAlias";
            this.TextoAlias.Size = new System.Drawing.Size(217, 23);
            this.TextoAlias.TabIndex = 20;
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(22, 168);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(36, 15);
            this.Clave.TabIndex = 19;
            this.Clave.Text = "Clave";
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.Location = new System.Drawing.Point(22, 128);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(56, 15);
            this.Nombres.TabIndex = 18;
            this.Nombres.Text = "Nombres";
            // 
            // Alias
            // 
            this.Alias.AutoSize = true;
            this.Alias.Location = new System.Drawing.Point(22, 94);
            this.Alias.Name = "Alias";
            this.Alias.Size = new System.Drawing.Size(32, 15);
            this.Alias.TabIndex = 17;
            this.Alias.Text = "Alias";
            // 
            // Activo
            // 
            this.Activo.AutoSize = true;
            this.Activo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Activo.Location = new System.Drawing.Point(413, 24);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(60, 19);
            this.Activo.TabIndex = 31;
            this.Activo.Text = "Activo";
            this.Activo.UseVisualStyleBackColor = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(22, 53);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 15);
            this.ID.TabIndex = 32;
            this.ID.Text = "ID";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(77, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 61);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(218, 230);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 61);
            this.btnEditar.TabIndex = 35;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(359, 230);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 61);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(190, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fechaactual
            // 
            this.Fechaactual.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fechaactual.Location = new System.Drawing.Point(413, 49);
            this.Fechaactual.Name = "Fechaactual";
            this.Fechaactual.Size = new System.Drawing.Size(131, 23);
            this.Fechaactual.TabIndex = 39;
            this.Fechaactual.Value = new System.DateTime(2021, 1, 30, 0, 0, 0, 0);
            this.Fechaactual.ValueChanged += new System.EventHandler(this.Fechaactual_ValueChanged);
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Location = new System.Drawing.Point(369, 54);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(38, 15);
            this.labFecha.TabIndex = 40;
            this.labFecha.Text = "Fecha";
            // 
            // TextID
            // 
            this.TextID.Location = new System.Drawing.Point(84, 50);
            this.TextID.Mask = "99999";
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(100, 23);
            this.TextID.TabIndex = 41;
            this.TextID.ValidatingType = typeof(int);
            // 
            // Errores
            // 
            this.Errores.ContainerControl = this;
            // 
            // Registrousuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 340);
            this.Controls.Add(this.TextID);
            this.Controls.Add(this.labFecha);
            this.Controls.Add(this.Fechaactual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Activo);
            this.Controls.Add(this.TextoClave2);
            this.Controls.Add(this.ConfirmClave);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.TextoEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.TextoClave);
            this.Controls.Add(this.TextoNombres);
            this.Controls.Add(this.TextoAlias);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.Alias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrousuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.Registrousuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Errores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextoClave2;
        private System.Windows.Forms.Label ConfirmClave;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.TextBox TextoEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox TextoClave;
        private System.Windows.Forms.TextBox TextoNombres;
        private System.Windows.Forms.TextBox TextoAlias;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.Label Alias;
        private System.Windows.Forms.CheckBox Activo;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Fechaactual;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.MaskedTextBox TextID;
        private System.Windows.Forms.ErrorProvider Errores;
    }
}

