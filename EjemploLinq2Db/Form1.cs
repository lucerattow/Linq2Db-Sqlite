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
        public Form1()
        {
            InitializeComponent();
            
            dataGridView.DataSource = All();
        }

        /// <summary>
        /// Este metodo retorna todos los registros de la tabla Persona
        /// </summary>
        /// <returns></returns>
        public static List<Persona> All()
        {
            using (var db = new DataBase())
            {
                var query = 
                    from p in db.Personas
                    select p;
                return query.ToList();
            }
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

            dataGridView.DataSource = All();
        }

        private bool ComprobarCampos()
        {
            if (txtName.Text == "") return false;
            if (txtLastName.Text == "") return false;
            if (txtDNI.Text == "") return false;

            return true;
        }
    }
}
