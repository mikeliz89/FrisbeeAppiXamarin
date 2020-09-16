using System;
using System.Collections.Generic;
using System.Text;

namespace FrisbeeAppi.Models
{
    public class Game
    {
        /// <summary>
        /// Tiedostonimi
        /// </summary>
        public string Filename { get; set; }
        public string Text { get; set; }
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
        /// <summary>
        /// Pelattava rata
        /// </summary>
        public Track Track { get; set; }
        /// <summary>
        /// Pelin kuvaus
        /// </summary>
        public string Description { get; set; }
    }
}
