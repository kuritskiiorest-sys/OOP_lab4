namespace StarWarsGame.Entities
{
    // Сутність "Зміна рейтингу" — запис в історії рейтингу гравців.
    public class RatingEntity
    {
        // Ідентифікатор запису рейтингу
        public int Id { get; set; }

        // Ідентифікатор гравця, якому змінюють рейтинг
        public int PlayerId { get; set; }

        // На скільки змінився рейтинг (+/-)
        public int RatingChange { get; set; }

        // Причина зміни (наприклад, "Перемога в битві при Явіні")
        public string Reason { get; set; }
    }
}