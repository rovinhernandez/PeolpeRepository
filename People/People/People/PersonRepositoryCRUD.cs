using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using People.Models;

namespace People
{
    public class  PersonRepositoryCRUD
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public PersonRepositoryCRUD(string dbPath)
        {
            // Creamos la conexion 
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();

            /* PersonRepositoryCRUD Repo =
             new PersonReposirotyCRUD("C:\dev\datos");*/
        }

        public void CreatePerson(Person newPerson)
        {
            int result = 0;
            result = conn.Insert(newPerson); 
            if (result == 1)
            {
                StatusMessage =
                    $"{result} registros agregados [Nombre: " +
                    $"{newPerson.name}, ID {newPerson.Id}]";
                //"1 registro agregado [nombre: Juan, ID:1]
            }
            else
            {
                StatusMessage =
                    $"Registro no Insertado!";
            }
        }
    }
}
