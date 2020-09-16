using SQLite;
using System;

namespace FrisbeeAppi.Models
{
    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        /// <summary>
        /// Pelaajan nimi
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Pelaajan luontipvm + klo
        /// </summary>
        public DateTime Created { get; set; }
    }
}
