using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace EjemploLinq2Db.Data
{
    /// <summary>
    /// Esta clase contiene el modelo de la tabla "Personas"
    /// </summary>
    [Table(Name = "Personas")]
    public class Persona
    {
        [PrimaryKey, Identity]
        public int id { get; set; }

        [Column(Name = "Name"), NotNull]
        public string name { get; set; }

        [Column(Name = "LastName"), NotNull]
        public string lastName { get; set; }

        [Column(Name = "DNI"), NotNull]
        public string DNI { get; set; }
    }
}
