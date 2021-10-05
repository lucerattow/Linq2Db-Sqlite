using LinqToDB.Mapping;

namespace EjemploLinq2Db.Data
{
    [Table(Name = "Alumnos")]
    public class Alumno
    {
        [PrimaryKey, Identity]
        public int id { get; set; }

        [Column, NotNull]
        public string name { get; set; }

        [Column, NotNull]
        public string lastName { get; set; }
    }
}
