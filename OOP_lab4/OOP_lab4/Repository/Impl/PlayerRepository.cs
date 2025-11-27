using System.Collections.Generic;
using System.Linq;
using StarWarsGame.Database;
using StarWarsGame.Entities;
using StarWarsGame.Repository.Base;

namespace StarWarsGame.Repository.Impl
{
    // Реалізація репозиторію для гравців.
    // Працює безпосередньо з StarWarsDbContext.
    public class PlayerRepository : IPlayerRepository
    {
        private readonly StarWarsDbContext _db;

        public PlayerRepository(StarWarsDbContext db)
        {
            _db = db;
        }

        // Пошук гравця за Id
        public PlayerEntity GetById(int id)
        {
            return _db.Players.FirstOrDefault(p => p.Id == id);
        }

        // Повернути всіх гравців
        public IEnumerable<PlayerEntity> GetAll()
        {
            return _db.Players;
        }

        // Додати нового гравця
        public PlayerEntity Add(PlayerEntity player)
        {
            // Генеруємо новий Id
            int newId = _db.Players.Count > 0 ? _db.Players.Max(p => p.Id) + 1 : 1;
            player.Id = newId;

            _db.Players.Add(player);
            return player;
        }

        // Оновити існуючого гравця
        public void Update(PlayerEntity player)
        {
            var existing = GetById(player.Id);
            if (existing == null) return;

            existing.Name = player.Name;
            existing.AccountTypeId = player.AccountTypeId;
            existing.Rating = player.Rating;
        }
    }
}