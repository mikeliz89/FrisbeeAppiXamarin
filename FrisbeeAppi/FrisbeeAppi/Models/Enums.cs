namespace FrisbeeAppi.Models
{
    /// <summary>
    /// Radan tyyppi
    /// </summary>
    public enum TrackType
    { 
        /// <summary>
        /// Ei tiedossa
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Puistorata
        /// </summary>
        Park = 1,
        /// <summary>
        /// Metsärata
        /// </summary>
        Forest = 2,
        /// <summary>
        /// Peltorata
        /// </summary>
        Field = 3,
        /// <summary>
        /// Mäkirata
        /// </summary>
        Hill = 4,
        /// <summary>
        /// Sekalainen
        /// </summary>
        Miscellaneous = 5
    }

    /// <summary>
    /// Pelin tilanne
    /// </summary>
    public enum GameStatus
    {
        /// <summary>
        /// Ei tiedossa
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Aloittamaton kierros
        /// </summary>
        NotStarted = 1,
        /// <summary>
        /// Aloitettu / käynnissä oleva kierros
        /// </summary>
        Started = 2,
        /// <summary>
        /// Kierros valmis
        /// </summary>
        Finished = 3,
        /// <summary>
        /// Keskeneräiseksi merkitty
        /// </summary>
        MarkedUnfinished = 4
    }
   
    /// <summary>
    /// Kiekon tilanne
    /// </summary>
    public enum DiscStatus {
        /// <summary>
        /// Ei tiedossa
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Reservissä / ei käytössä
        /// </summary>
        InReserve = 1,
        /// <summary>
        /// Laukussa / käytössä
        /// </summary>
        InTheBag = 2,
        /// <summary>
        /// Lainassa
        /// </summary>
        Loaned = 3,
        /// <summary>
        /// Hukassa
        /// </summary>
        Lost = 4
	  }

    /// <summary>
    /// Pelimoodi
    /// </summary>
    public enum GameMode {
      /// <summary>
      /// Normaali
      /// </summary>
      Normal = 0,
      /// <summary>
      /// Parikisa
      /// </summary>
      PairMatch = 1,
      /// <summary>
      /// Joukkuekisa
      /// </summary>
      TeamMatch = 2,
      /// <summary>
      /// Randomoitu heittotyyli
      /// </summary>
      Randomizer = 3,
      /// <summary>
      /// Puttikisa
      /// </summary>
      PuttingMatch = 4
	  }
}
