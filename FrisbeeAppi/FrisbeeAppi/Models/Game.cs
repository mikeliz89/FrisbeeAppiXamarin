using System;
using System.Collections.Generic;
using SQLite;

namespace FrisbeeAppi.Models
{
    public class Game
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        /// <summary>
        /// Tiedostonimi
        /// </summary>
        public string Filename { get; set; }
        public string Text { get; set; }
        [Ignore]
        /// <summary>
        /// Lista pelin pelaajista
        /// </summary>
        public List<Player> Players { get; set; }
        /// <summary>
        /// Alkuaika pvm + klo
        /// </summary>
        public DateTime StartDateTime { get; set; }
        /// <summary>
        /// Loppuaika pvm + klo
        /// </summary>
        public DateTime EndDateTime { get; set; }
        public int TrackId { get; set; }
        [Ignore]
        /// <summary>
        /// Pelattava rata
        /// </summary>
        public Track Track { get; set; }
        /// <summary>
        /// Pelin kuvaus
        /// </summary>
        public string Description { get; set; }
        [Ignore]
        /// <summary>
        /// Pelin tilanne
        /// </summary>
        public GameStatus GameStatus { get; set; }
    }
}
