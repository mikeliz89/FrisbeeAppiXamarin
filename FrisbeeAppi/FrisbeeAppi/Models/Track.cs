using SQLite;
using System;
using System.Collections.Generic;

namespace FrisbeeAppi.Models
{
    public class Track
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        /// <summary>
        /// Radan väylien määrä
        /// </summary>
        public int HolesCount { get; set; }
        [Ignore]
        /// <summary>
        /// Rataan kuuluvat väylät
        /// </summary>
        public List<Hole> Holes { get; set; }
        /// <summary>
        /// Radan nimi
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Radan luontiaika
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// Radan kuvaus
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Lista radan tyypeistä
        /// </summary>
        [Ignore]
        public List<TrackType> TrackTypes { get; set; }
    }
}
