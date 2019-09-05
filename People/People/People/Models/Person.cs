using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace People.Models
{
    [Table("T_People")]

    public class Person
    {
        //Miembro  Properties
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50),]
        public String name { get; set; }
    }
}
