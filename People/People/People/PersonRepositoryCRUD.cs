using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using People.Models;

namespace People
{
    class PersonRepositoryCRUD
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public PersonRepositoryCRUD(string dbPath)
        {
            // Creamos la conexion 
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();
        }
    }
}
