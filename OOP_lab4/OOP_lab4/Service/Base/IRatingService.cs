using System.Collections.Generic;
using StarWarsGame.DTO;

namespace StarWarsGame.Service.Base
{
    // Інтерфейс сервісу рейтингу
    public interface IRatingService
    {
        // Отримати всі записи зміни рейтингу
        IEnumerable<RatingDto> GetAllRatings();

        // Додати запис зміни рейтингу
        void AddRating(int playerId, int ratingChange, string reason);

        // Складний бізнес-функціонал:
        // наприклад, "епічна битва", яка змінює рейтинг декільком гравцям
        void RunEpicBattleScenario();
    }
}