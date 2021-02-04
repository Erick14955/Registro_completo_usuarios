using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Registro.BLL;
using Proyecto_Registro.Entidades;

namespace WindowsFormsApp1
{
    public partial class Registrousuario : Form
    {
        public Registrousuario()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuarios = UsuariosBLL.Buscar((int)IdNumericUpDown.Value);

            return (usuarios != null);
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            AliasTextBox.Clear();
            NombreTextBox.Clear();
            EmailTextBox.Clear();
            ClaveTextBox.Clear();
            ConfirmClaveTextBox.Clear();
            FechaDateTimePicker.CustomFormat = "";
            ActivoCheckBox.Checked = false;
            RolComboBox.Text = "";
        }

        private void LlenarCampos(Usuarios usuarios)
        {
            IdNumericUpDown.Value = usuarios.UsuarioID;
            NombreTextBox.Text = usuarios.Nombres;
            EmailTextBox.Text = usuarios.Email;
            AliasTextBox.Text = usuarios.Alias;
            RolComboBox.Text = usuarios.RolID;
            ClaveTextBox.Text = usuarios.Clave;
            FechaDateTimePicker.Value = usuarios.FechaIngreso;
            ActivoCheckBox.Checked = usuarios.Activo;
        }

        private Usuarios LlenarClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioID = (int)IdNumericUpDown.Value;
            usuarios.Clave = ClaveTextBox.Text;
            usuarios.Email = EmailTextBox.Text;
            usuarios.Nombres = NombreTextBox.Text;
            usuarios.FechaIngreso = FechaDateTimePicker.Value;
            usuarios.Alias = AliasTextBox.Text;
            usuarios.RolID = RolComboBox.Text;
            usuarios.Activo = ActivoCheckBox.Checked;

            return usuarios;
        }

        private bool Validar()
        {
            bool paso = true;

            if (NombreTextBox.Text == string.Empty)
            {
                Errores.SetError(NombreTextBox, "El campo nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(RolComboBox.Text))
            {
                Errores.SetError(RolComboBox, "Debe agregar un rol especifico");
                RolComboBox.Focus();
                paso = false;
            }

            if(AliasTextBox.Text == string.Empty)
            {
                Errores.SetError(AliasTextBox, "El campo de alias no puede estar vacio");
                AliasTextBox.Focus();
                paso = false;
            }

            if(ClaveTextBox.Text == string.Empty)
            {
                Errores.SetError(ClaveTextBox, "El campo de clave no puede estar vacio");
                ClaveTextBox.Focus();
                paso = false;
            }

            if(ConfirmClaveTextBox.Text == string.Empty)
            {
                Errores.SetError(ConfirmClaveTextBox, "El campo de confirmar clave no puede estar vacio");
                ConfirmClaveTextBox.Focus();
                paso = false;
            }

            if(EmailTextBox.Text == string.Empty)
            {
                Errores.SetError(EmailTextBox, "El campo de email no puede estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();
            int.TryParse((int)IdNumericUpDown, out id);

            Limpiar();

            usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("Persona Encotrada");
                LlenarCampos(usuario);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada");
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            bool paso = false;
            if (!Validar())
            {
                return;
            }
            usuario = LlenarClase();
            paso = UsuariosBLL.Guardar(usuario);

            if (!ExisteEnLaBaseDeDatos())
            {
                Limpiar();
                MessageBox.Show("Usuario guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Limpiar();
                MessageBox.Show("Usuario modificado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Errores.Clear();
            int id;
            int.TryParse((int)IdNumericUpDown.Value, out id);
            Limpiar();
            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Usuario eliminado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                Errores.SetError(IdNumericUpDown, "ID no existente");
        }
    }
}
