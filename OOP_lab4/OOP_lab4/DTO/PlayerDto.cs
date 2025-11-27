namespace StarWarsGame.DTO
{
    // DTO для гравця — використовується для повернення даних в UI/команди
    public class PlayerDto
    {
        public int Id { get; set; }             // Id гравця
        public string Name { get; set; }        // Ім'я гравця
        public string AccountType { get; set; } // Назва фракції / типу акаунта
        public int Rating { get; set; }         // Поточний рейтинг
    }
}