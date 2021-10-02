using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;

namespace EjemploLinq2Db.Data
{
    public class DataBase : LinqToDB.Data.DataConnection
    {
        /// <summary>
        /// Esta clase se encarga de realizar la conexion a la base de datos. Aqui se definen las tablas que tiene la base de datos.
        /// </summary>
        public DataBase() : base("MyDatabase")
        {
            CheckTable();
        }

        public ITable<Persona> Personas => GetTable<Persona>();

        /// <summary>
        /// Esta funcion comprueba si la tabla "Persona" existe, de no existir la crea en base al modelo "Persona".
        /// </summary>
        public void CheckTable()
        {
            var sp = this.DataProvider.GetSchemaProvider();
            var dbSchema = sp.GetSchema(this);

            if (!dbSchema.Tables.Any(t => t.TableName == "Personas")) //Si la tabla no existe
            {
                this.CreateTable<Persona>();
            }
        }
    }

    //La conexion a la base de datos se define en el app.config / web.config
    
	//<connectionStrings>
	//	<add name = "MyDatabase"
    //	connectionString="Data Source=database.db"
    //	providerName="SQLite" />
	//</connectionStrings>

    //Si la base de datos no existe, el archivo se crea automaticamente.
}
