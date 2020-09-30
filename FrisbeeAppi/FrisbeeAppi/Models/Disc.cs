using SQLite;
using System;

namespace FrisbeeAppi.Models
{
    /// <summary>
    /// Kiekko
    /// </summary>
    public class Disc
    {
				[PrimaryKey, AutoIncrement]
        public int ID { get; set; }
				/// <summary>
		    /// Kiekko lisätty kokoelmaan pvm
		    /// </summary>
		    public DateTime Created { get; set; }
        /// <summary>
        /// Kiekon nimi
        /// </summary>
        public string Name { get; set; }
				/// <summary>
		    /// Valmistaja
		    /// </summary>
				public string Manufacturer { get; set; }
		    /// <summary>
		    /// Malli
		    /// </summary>
		    public string Model { get; set; }
				/// <summary>
		    /// Lyhyt kuvaus
		    /// </summary>
		    public string Description { get; set; }
        /// <summary>
		    /// Nopeus
		    /// </summary>
		    public double Speed { get; set; }
				/// <summary>
		    /// Liito
		    /// </summary>
		    public double Glide { get; set; }
				/// <summary>
		    /// Vakaus
		    /// </summary>
		    public double Turn { get; set; }
				/// <summary>
		    /// Loppufeidi
		    /// </summary>
		    public double Fade { get; set; }
		    /// <summary>
				/// Kiekon tilanne
				/// </summary>
			  public DiscStatus DiscStatus { get; set; }
		}
}
