﻿
namespace FrisbeeAppi.Models
{
    /// <summary>
    /// Radan väylä
    /// </summary>
    public class Hole
    {
        /// <summary>
        /// Väylän järjestysnumero
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Par-lukema
        /// </summary>
        public int Par { get; set; }
        /// <summary>
        /// Väylän pituus (kokonaisia metrejä)
        /// </summary>
        public int Length { get; set; }
    }
}
