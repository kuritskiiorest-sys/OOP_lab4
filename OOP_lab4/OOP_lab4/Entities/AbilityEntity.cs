namespace StarWarsGame.Entities
{
    // Сутність "Навичка / Здібність"
    public class AbilityEntity
    {
        public int Id { get; set; }               // Ідентифікатор
        public string Name { get; set; }          // Назва (наприклад, "Force Push")
        public string Description { get; set; }   // Опис здібності
    }
}