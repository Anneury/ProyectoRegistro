using ProyectoRegistro.DAL;
using ProyectoRegistro.BLL;
using ProyectoRegistro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRegistro
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Limpiar()
        {
            IdNumericUpDown1.Value = 0;
            textNombre.Text = string.Empty;
            textCedula.Text = string.Empty;
            textDireccion.Text = string.Empty;
            textTelefono.Text = string.Empty;
            errorProvider1.Clear();
            dateTimePicker1.CustomFormat = " ";
            RolesComboBox1.Text = string.Empty;
        }

        private void LlenaCampo(Personas personas)
        {
            IdNumericUpDown1.Value = personas.PersonaID;
            textTelefono.Text = personas.Telefono;
            textCedula.Text = personas.Cedula;
            textNombre.Text = personas.Nombre;
            textDireccion.Text = personas.Direccion;
            dateTimePicker1.Value = personas.FechaNacimiento;
            RolesComboBox1.Text = personas.Rol;
        }

        private Personas LlenaClase()
        {
            Personas personas = new Personas();
            personas.PersonaID = Convert.ToInt32(IdNumericUpDown1.Value);
            personas.Nombre = textNombre.Text;
            personas.Cedula = textCedula.Text;
            personas.Direccion = textDireccion.Text;
            personas.Telefono = textTelefono.Text;
            personas.FechaNacimiento = dateTimePicker1.Value;
            personas.Rol = RolesComboBox1.Text;

            return personas;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Personas personas = PersonasBll.Buscar((int)IdNumericUpDown1.Value);

            return (personas != null);
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            Personas personas = new Personas();
            bool paso = false;

            if (!Validar())
                return;
            personas = LlenaClase();

            if (IdNumericUpDown1.Value == 0)
                paso = PersonasBll.Guardar(personas);
            else
            {
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea guardar los cambios?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        
                    }
                    else if (result == DialogResult.No)
                    {
                        Limpiar();
                        
                        return;
                    }
                }
                paso = PersonasBll.Modificar(personas);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Validar()
        {
            bool paso = true;

            if(textNombre.Text == string.Empty)
            {
                errorProvider1.SetError(textNombre, "El campo nombre no puede estar vacio");
                textNombre.Focus();
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(textDireccion.Text))
            {
                errorProvider1.SetError(textDireccion, "El campo direccion no puede estar vacio");
                textDireccion.Focus();
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(textCedula.Text.Replace("-","")))
            {
                errorProvider1.SetError(textCedula, "El campo cedula no puede estar vacio");
                textCedula.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(textTelefono.Text.Replace("-", "")))
            {
                errorProvider1.SetError(textTelefono, "El campo Telefono no puede estar vacio");
                textTelefono.Focus();
                paso = false;
            }
            if(string.IsNullOrWhiteSpace(RolesComboBox1.Text))
            {
                errorProvider1.SetError(RolesComboBox1, "Debe agregar un rol especifico");
                RolesComboBox1.Focus();
                paso = false;
            }
                return paso;
        }
        private void Listar_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            dataGridView1.DataSource = contexto.Personas.ToList();
            contexto.Dispose();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            int id;
            Personas personas = new Personas();
            int.TryParse(IdNumericUpDown1.Text, out id);

            Limpiar();

            personas = PersonasBll.Buscar(id);

            if(personas != null)
            {
                MessageBox.Show("Persona Encotrada");
                LlenaCampo(personas);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada");
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            int id;
            int.TryParse(IdNumericUpDown1.Text, out id);

            Limpiar();

            if (PersonasBll.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider1.SetError(IdNumericUpDown1, "No se puede eliminar una persona que no existe");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd / MM / yyyy";
        }

        private void RolesComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
