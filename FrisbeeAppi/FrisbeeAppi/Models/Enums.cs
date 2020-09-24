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
}
