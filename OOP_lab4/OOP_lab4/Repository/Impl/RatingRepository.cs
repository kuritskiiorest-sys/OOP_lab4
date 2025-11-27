using System.Collections.Generic;
using System.Linq;
using StarWarsGame.Database;
using StarWarsGame.Entities;
using StarWarsGame.Repository.Base;

namespace StarWarsGame.Repository.Impl
{
    // Репозиторій для історії рейтингу
    public class RatingRepository : IRatingRepository
    {
        private readonly StarWarsDbContext _db;

        public RatingRepository(StarWarsDbContext db)
        {
            _db = db;
        }

        // Отримати всі записи
        public IEnumerable<RatingEntity> GetAll()
        {
            return _db.Ratings;
        }

        // Додати новий запис зміни рейтингу
        public RatingEntity Add(RatingEntity rating)
        {
            int newId = _db.Ratings.Count > 0 ? _db.Ratings.Max(r => r.Id) + 1 : 1;
            rating.Id = newId;

            _db.Ratings.Add(rating);
            return rating;
        }
    }
}