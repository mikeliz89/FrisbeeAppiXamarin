using System;
using System.Collections.Generic;
using System.Text;

namespace FrisbeeAppi.Models
{
    public class Track
    {
        /// <summary>
        /// Rataan kuuluvat väylät
        /// </summary>
        public List<Hole> Holes { get; set; }
        /// <summary>
        /// Radan kuvaus
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Lista radan tyypeistä
        /// </summary>
        public List<TrackType> TrackTypes { get; set; }
    }
}
