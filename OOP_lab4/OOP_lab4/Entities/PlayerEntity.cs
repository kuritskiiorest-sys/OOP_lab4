namespace StarWarsGame.Entities
{
    // Сутність "Гравець" — відображає таблицю Players в БД.
    public class PlayerEntity
    {
        // Унікальний ідентифікатор гравця (Primary Key)
        public int Id { get; set; }

        // Ім'я гравця — наприклад, "Люк Скайвокер"
        public string Name { get; set; }

        // Посилання на тип акаунту (JediOrder, GalacticEmpire тощо)
        public int AccountTypeId { get; set; }

        // Поточний рейтинг гравця
        public int Rating { get; set; } = 1000;
    }
}