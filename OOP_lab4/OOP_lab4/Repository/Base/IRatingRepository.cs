using System.Collections.Generic;
using StarWarsGame.Entities;

namespace StarWarsGame.Repository.Base
{
    // Інтерфейс репозиторію змін рейтингу
    public interface IRatingRepository
    {
        // Отримати всі записи зміни рейтингу
        IEnumerable<RatingEntity> GetAll();

        // Додати новий запис зміни рейтингу
        RatingEntity Add(RatingEntity rating);
    }
}