using System.Collections.Generic;
using System.Linq;
using StarWarsGame.Database;
using StarWarsGame.DTO;
using StarWarsGame.Entities;
using StarWarsGame.Mappers;
using StarWarsGame.Repository.Base;
using StarWarsGame.Service.Base;

namespace StarWarsGame.Service.Impl
{
    // Сервіс гравців — містить бізнес-логіку роботи з гравцями.
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly StarWarsDbContext _db;

        public PlayerService(IPlayerRepository playerRepository, StarWarsDbContext db)
        {
            _playerRepository = playerRepository;
            _db = db;
        }

        // Отримати всіх гравців та перетворити в DTO
        public IEnumerable<PlayerDto> GetAllPlayers()
        {
            var players = _playerRepository.GetAll();
            var types = _db.AccountTypes;

            // Використовуємо маппер для перетворення Entity → DTO
            return players.Select(p => p.ToDto(types)).ToList();
        }

        // Додати нового гравця (логіка: дефолтний рейтинг, перевірка типу акаунту тощо)
        public void AddPlayer(string name, int accountTypeId)
        {
            // Можна додати перевірку: чи існує такий тип акаунта
            var accountType = _db.AccountTypes.FirstOrDefault(t => t.Id == accountTypeId);
            if (accountType == null)
            {
                // Якщо тип не знайдено — можна кинути помилку або задати тип за замовчуванням
                accountTypeId = 1;
            }

            var player = new PlayerEntity
            {
                Name = name,
                AccountTypeId = accountTypeId,
                Rating = 1000 // стартовий рейтинг
            };

            _playerRepository.Add(player);
        }

        public void RunEpicBattleScenario()
        {
            throw new NotImplementedException();
        }
    }
}