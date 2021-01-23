using ProyectoRegistro.BLL;
using ProyectoRegistro.DAL;
using ProyectoRegistro.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRegistro
{
    public partial class Modificar : Form
    {
        public int Id { get; set; }
 
        public Modificar()
        {
            InitializeComponent();
        }
        public void LlenarCampos(int id)
        {
            this.Id = id;
            Personas personas = new Personas();
            personas = PersonasBll.Buscar(id);
            IdNumericUpDown1.Value = personas.PersonaID;
            textNombre.Text = personas.Nombre;
            textCedula.Text = personas.Cedula;
            textDireccion.Text = personas.Direccion;
            textTelefono.Text = personas.Telefono;
        }
        private Personas LlenaClase()
        {
            Personas personas = new Personas();
            personas.Nombre = textNombre.Text;
            personas.Cedula = textCedula.Text;
            personas.Direccion = textDireccion.Text;
            personas.Telefono = textTelefono.Text;

            return personas;
        }
        private void Limpiar()
        {
           // IdNumericUpDown1.Value = 0;
            textNombre.Text = string.Empty;
            textCedula.Text = string.Empty;
            textDireccion.Text = string.Empty;
            textTelefono.Text = string.Empty;
           // errorProvider1.Clear();
        }
        private bool Validar()
        {
            bool paso = true;

            if (textNombre.Text == string.Empty)
            {
                errorProvider1.SetError(textNombre, "El campo nombre no puede estar vacio");
                textNombre.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(textDireccion.Text))
            {
                errorProvider1.SetError(textDireccion, "El campo direccion no puede estar vacio");
                textDireccion.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(textCedula.Text.Replace("-", "")))
            {
                errorProvider1.SetError(textCedula, "El campo cedula no puede estar vacio");
                textCedula.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(textCedula.Text.Replace("-", "")))
            {
                errorProvider1.SetError(textTelefono, "El campo Telefono no puede estar vacio");
                textTelefono.Focus();
                paso = false;
            }
            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Personas personas = PersonasBll.Buscar(Id);

            return (personas != null);
        }
        public static bool Modificar2(Personas personas)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(personas).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                //throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            Personas personas = new Personas();
            bool paso = false;

            if (!Validar())
                return;
            personas = LlenaClase();

            if (IdNumericUpDown1.Value == 0)
                paso = false;
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = Modificar2(personas);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
