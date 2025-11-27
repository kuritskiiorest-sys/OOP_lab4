namespace StarWarsGame.DTO
{
    // DTO для історії рейтингу
    public class RatingDto
    {
        public string PlayerName { get; set; }  // Ім'я гравця
        public int RatingChange { get; set; }   // Зміна рейтингу (+/-)
        public string Reason { get; set; }      // Причина
    }
}