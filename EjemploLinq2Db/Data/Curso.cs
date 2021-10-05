using LinqToDB.Mapping;

namespace EjemploLinq2Db.Data
{
    [Table(Name = "Cursos")]
    public class Curso
    {
        [PrimaryKey, Identity]
        public int id { get; set; }

        [Column, NotNull]
        public string name { get; set; }

        [Column, NotNull]
        public int alumno_id { get; set; }
    }
}
