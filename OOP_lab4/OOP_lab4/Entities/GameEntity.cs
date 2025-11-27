namespace StarWarsGame.Entities
{
    // Сутність "Гра" — подія/битва/місія в світі Зоряних Війн.
    public class GameEntity
    {
        // Ідентифікатор гри
        public int Id { get; set; }

        // Назва гри або місії (наприклад, "Битва при Явіні")
        public string GameName { get; set; }
    }
}