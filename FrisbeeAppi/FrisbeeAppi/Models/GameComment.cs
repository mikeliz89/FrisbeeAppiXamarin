
namespace FrisbeeAppi.Models
{
    public class GameComment
    {
        /// <summary>
        /// Peli johon kommentti on lisätty
        /// </summary>
        public Game Game { get; set; }
        /// <summary>
        /// Pelaaja joka kommentin on laittanut
        /// </summary>
        public Player Player { get; set; }
        public string CommentText { get; set; }
    }
}
