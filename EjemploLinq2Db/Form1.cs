using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToDB;
using EjemploLinq2Db.Data;

namespace EjemploLinq2Db
{
    public partial class Form1 : Form
    {
        private int SelectedID;

        public Form1()
        {
            InitializeComponent();
            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            List<Persona> Personas;
            using (var db = new DataBase())
            {
                var query =
                    from p in db.Personas
                    where p.name.Contains(txtName.Text)
                    where p.lastName.Contains(txtLastName.Text)
                    where p.DNI.Contains(txtDNI.Text)
                    select p;
                Personas = query.ToList();
            }

            dataGridView.DataSource = Personas;
            dataGridView.Columns[0].Visible = false;
        }

        private bool ComprobarCampos()
        {
            if (txtName.Text == "") return false;
            if (txtLastName.Text == "") return false;
            if (txtDNI.Text == "") return false;

            return true;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedID = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDNI.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ComprobarCampos())
            {
                MessageBox.Show("Complete todos los campos");
            }

            Persona p = new Persona();
            p.name = txtName.Text;
            p.lastName = txtLastName.Text;
            p.DNI = txtDNI.Text;

            using (var db = new DataBase())
            {
                db.Insert(p);
            }

            ObtenerDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ComprobarCampos())
            {
                MessageBox.Show("Complete todos los campos");
            }

            Persona p = new Persona();
            p.id = SelectedID;
            p.name = txtName.Text;
            p.lastName = txtLastName.Text;
            p.DNI = txtDNI.Text;

            using (var db = new DataBase())
            {
                db.Update(p);
            }

            ObtenerDatos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            using (var db = new DataBase())
            {
                db.Personas
                    .Where(p => p.id == SelectedID)
                    .Delete();
            }

            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;

            ObtenerDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }
    }
}
