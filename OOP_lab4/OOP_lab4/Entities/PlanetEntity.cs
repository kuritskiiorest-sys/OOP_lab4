namespace StarWarsGame.Entities
{
    // Сутність "Планета / Локація"
    public class PlanetEntity
    {
        public int Id { get; set; }          // Ідентифікатор планети
        public string Name { get; set; }     // Назва (наприклад, "Татуїн")
        public string Region { get; set; }   // Регіон / сектор галактики
    }
}