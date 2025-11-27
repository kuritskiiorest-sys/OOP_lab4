namespace StarWarsGame.Entities
{
    // Сутність "Ігровий предмет" — для демонстрації додаткового домену.
    public class EquipmentEntity
    {
        public int Id { get; set; }          // Ідентифікатор предмету
        public string Name { get; set; }     // Назва (наприклад, "Світловий меч")
        public string Type { get; set; }     // Тип (weapon, armor, gadget)
    }
}