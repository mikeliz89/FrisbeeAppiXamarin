using System;
using System.Collections.Generic;
using System.Text;

namespace FrisbeeAppi.Models
{
    /// <summary>
    /// Radan väylä
    /// </summary>
    public class Hole
    {
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
