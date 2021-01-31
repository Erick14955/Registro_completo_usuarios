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

        private void Registrousuario_Load(object sender, EventArgs e)
        {

        }

        private void Fechaactual_ValueChanged(object sender, EventArgs e)
        {
            Fechaactual.CustomFormat = "dd / MM / yyyy";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            bool paso = false;
            if (!Validar())
                return;
            usuario = Llenarinfo();

            if (!UsuariosBLL.Existe(Convert.ToInt32(TextID.Text))){
                if (!ExisteEnLaBaseDeDatos())
                    paso = UsuariosBLL.Guardar(usuario);
                else
                {
                    MessageBox.Show("Este usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (paso)
            {
                Borrarcampos();
                MessageBox.Show("Usuario guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar, usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuarios = UsuariosBLL.Buscar(Convert.ToInt32(TextID.Text));

            return (usuarios != null);
        }

        private void Borrarcampos()
        {
            TextID.Clear();
            TextoAlias.Clear();
            TextoNombres.Clear();
            TextoEmail.Clear();
            TextoClave.Clear();
            TextoClave2.Clear();
            Fechaactual.CustomFormat = "";
            Activo.Checked = false;
            comboRol.Text = "";
        }

        private void mostrarinfo(Usuarios usuarios)
        {
            TextID.Text = Convert.ToString(usuarios.UsuarioID);
            TextoNombres.Text = usuarios.Nombres;
            TextoEmail.Text = usuarios.Email;
            TextoAlias.Text = usuarios.Alias;
            comboRol.Text = usuarios.RolID;
            TextoClave.Text = usuarios.Clave;
            Fechaactual.Value = usuarios.FechaIngreso;
            Activo.Checked = usuarios.Activo;
        }

        private Usuarios Llenarinfo()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioID = Convert.ToInt32(TextID.Text);
            usuarios.Clave = TextoClave.Text;
            usuarios.Email = TextoEmail.Text;
            usuarios.Nombres = TextoNombres.Text;
            usuarios.FechaIngreso = Fechaactual.Value;
            usuarios.Alias = TextoAlias.Text;
            usuarios.RolID = comboRol.Text;
            usuarios.Activo = Activo.Checked;

            return usuarios;
        }

        private bool Validar()
        {
            bool paso = true;

            if (TextoNombres.Text == string.Empty)
            {
                Errores.SetError(TextoNombres, "El campo nombre no puede estar vacio");
                TextoNombres.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(comboRol.Text))
            {
                Errores.SetError(comboRol, "Debe agregar un rol especifico");
                comboRol.Focus();
                paso = false;
            }

            if(TextoAlias.Text == string.Empty)
            {
                Errores.SetError(TextoAlias, "El campo de alias no puede estar vacio");
                TextoAlias.Focus();
                paso = false;
            }

            if(TextoClave.Text == string.Empty)
            {
                Errores.SetError(TextoClave, "El campo de clave no puede estar vacio");
                TextoClave.Focus();
                paso = false;
            }

            if(TextoClave2.Text == string.Empty)
            {
                Errores.SetError(TextoClave2, "El campo de confirmar clave no puede estar vacio");
                TextoClave2.Focus();
                paso = false;
            }

            if(TextoEmail.Text == string.Empty)
            {
                Errores.SetError(TextoEmail, "El campo de email no puede estar vacio");
                TextoEmail.Focus();
                paso = false;
            }

            return paso;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();
            int.TryParse(TextID.Text, out id);

            Borrarcampos();

            usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("Persona Encotrada");
                mostrarinfo(usuario);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            bool paso = false;
            if (!Validar())
            {
                return;
            }
            usuario = Llenarinfo();

            if (!UsuariosBLL.Existe(Convert.ToInt32(TextID.Text)))
            {
                MessageBox.Show("Error al intentar modificar usuario, id no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No es posible realizar la modificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = UsuariosBLL.Modificar(usuario);
            }

            if (paso)
            {
                Borrarcampos();
                MessageBox.Show("Usuario modificado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No es posible realizar la modificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Errores.Clear();
            int id;
            int.TryParse(TextID.Text, out id);
            Borrarcampos();
            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Usuario eliminado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                Errores.SetError(TextID, "ID no existente");
        }
    }
}
