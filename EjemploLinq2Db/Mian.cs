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
    public partial class Mian : Form
    {
        private Alumno alumno;
        private Curso curso;

        public Mian()
        {
            InitializeComponent();
            grdSetup(ref grdAlumnos);
            grdSetup(ref grdCursos);
            ObtenerDatosAlumnos();
        }

        private void grdSetup(ref DataGridView grd)
        {
            grd.RowHeadersVisible = false;
            grd.EditMode = DataGridViewEditMode.EditProgrammatically;
            grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd.AllowUserToResizeColumns = false;
            grd.AllowUserToResizeRows = false;
        }

        //Eventos para el grupo "Alumnos"

        private void ObtenerDatosAlumnos()
        {
            List<Alumno> Personas;
            using (var db = new DataBase())
            {
                var query =
                    from t in db.Alumnos
                    where t.name.Contains(txtName.Text)
                    where t.lastName.Contains(txtLastName.Text)
                    select t;
                Personas = query.ToList();
            }

            grdAlumnos.DataSource = Personas;
            grdAlumnos.Columns[0].Visible = false;
            grdAlumnos.Columns[1].HeaderText = "Nombre";
            grdAlumnos.Columns[2].HeaderText = "Apellido";
        }

        private bool ComprobarCamposAlumnos()
        {
            if (txtName.Text == "") return false;
            if (txtLastName.Text == "") return false;

            return true;
        }

        private void LimpiarAlumnos()
        {
            alumno = new Alumno();
            txtName.Text = "";
            txtLastName.Text = "";

            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;

            GpCursos.Enabled = false;
            LimpiarCursos();
        }

        private void grdAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdAlumnos.Rows.Count == 0 || e.RowIndex == -1) return;

            txtName.Text = alumno.name;
            txtLastName.Text = alumno.lastName;

            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
        }

        private void grdAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdAlumnos.Rows.Count == 0 || e.RowIndex == -1) return;

            alumno = new Alumno();
            alumno.id = int.Parse(grdAlumnos.Rows[e.RowIndex].Cells[0].Value.ToString());
            alumno.name = grdAlumnos.Rows[e.RowIndex].Cells[1].Value.ToString();
            alumno.lastName = grdAlumnos.Rows[e.RowIndex].Cells[2].Value.ToString();

            GpCursos.Enabled = true;
            btnCursoModificar.Enabled = false;
            btnCursoBorrar.Enabled = false;
            txtCurso.Text = "";

            ObtenerDatosCursos();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ComprobarCamposAlumnos())
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            alumno = new Alumno();
            alumno.name = txtName.Text;
            alumno.lastName = txtLastName.Text;

            using (var db = new DataBase())
            {
                db.Insert(alumno);
            }

            LimpiarAlumnos();
            ObtenerDatosAlumnos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ComprobarCamposAlumnos())
            {
                MessageBox.Show("Complete todos los campos");
            }

            alumno.name = txtName.Text;
            alumno.lastName = txtLastName.Text;

            using (var db = new DataBase())
            {
                db.Update(alumno);
            }

            LimpiarAlumnos();
            ObtenerDatosAlumnos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            using (var db = new DataBase())
            {
                db.Alumnos
                    .Where(p => p.id == alumno.id)
                    .Delete();
            }

            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;

            LimpiarAlumnos();
            ObtenerDatosAlumnos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ObtenerDatosAlumnos();
        }

        //Eventos para el grupo "Cursos"

        private void ObtenerDatosCursos()
        {
            List<Curso> Cursos;
            using (var db = new DataBase())
            {
                var query =
                    from t in db.Cursos
                    where t.name.Contains(txtCurso.Text)
                    where t.alumno_id.Equals(alumno.id)
                    select t;
                Cursos = query.ToList();
            }

            grdCursos.DataSource = Cursos;
            grdCursos.Columns[1].HeaderText = "Nombre Curso";
            grdCursos.Columns[1].Width = 200;

            grdCursos.Columns[0].Visible = false;
            grdCursos.Columns[2].Visible = false;
        }

        private bool ComprobarCamposCursos()
        {
            if (txtCurso.Text == "") return false;

            return true;
        }

        private void LimpiarCursos()
        {
            curso = new Curso();
            txtCurso.Text = "";

            btnCursoModificar.Enabled = false;
            btnCursoBorrar.Enabled = false;
        }

        private void grdCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCursos.Rows.Count == 0 || e.RowIndex == -1) return;

            txtCurso.Text = curso.name;

            btnCursoModificar.Enabled = true;
            btnCursoBorrar.Enabled = true;
        }

        private void grdCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCursos.Rows.Count == 0 || e.RowIndex == -1) return;

            curso = new Curso();
            curso.id = int.Parse(grdCursos.Rows[e.RowIndex].Cells[0].Value.ToString());
            curso.name = grdCursos.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnCursoCreate_Click(object sender, EventArgs e)
        {
            if (!ComprobarCamposCursos())
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            curso = new Curso();
            curso.name = txtCurso.Text;
            curso.alumno_id = alumno.id;

            using (var db = new DataBase())
            {
                db.Insert(curso);
            }

            LimpiarCursos();
            ObtenerDatosCursos();
        }

        private void btnCursoModificar_Click(object sender, EventArgs e)
        {
            if (!ComprobarCamposCursos())
            {
                MessageBox.Show("Complete todos los campos");
            }

            curso.name = txtCurso.Text;

            using (var db = new DataBase())
            {
                db.Update(curso);
            }

            LimpiarCursos();
            ObtenerDatosCursos();
        }

        private void btnCursoBorrar_Click(object sender, EventArgs e)
        {
            using (var db = new DataBase())
            {
                db.Cursos
                    .Where(c => c.id == curso.id)
                    .Delete();
            }

            LimpiarCursos();
            ObtenerDatosCursos();
        }

        private void btnCursoBuscar_Click(object sender, EventArgs e)
        {
            ObtenerDatosCursos();
        }

    }
}
