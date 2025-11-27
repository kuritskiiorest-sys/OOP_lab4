namespace StarWarsGame.Entities
{
    // Сутність "Тип акаунту" — наприклад, орден джедаїв, імперія тощо.
    public class AccountTypeEntity
    {
        // Ідентифікатор типу акаунту
        public int Id { get; set; }

        // Назва типу: "JediOrder", "GalacticEmpire", "RebelAlliance"
        public string TypeName { get; set; }
    }
}