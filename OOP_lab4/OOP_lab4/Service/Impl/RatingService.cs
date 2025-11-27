using System;
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
    // Сервіс рейтингу — відповідає за зміну та історію рейтингу
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly StarWarsDbContext _db;

        public RatingService(
            IRatingRepository ratingRepository,
            IPlayerRepository playerRepository,
            StarWarsDbContext db)
        {
            _ratingRepository = ratingRepository;
            _playerRepository = playerRepository;
            _db = db;
        }

        // Отримати всі записи змін рейтингу у вигляді DTO
        public IEnumerable<RatingDto> GetAllRatings()
        {
            var ratings = _ratingRepository.GetAll();
            var players = _db.Players.ToDictionary(p => p.Id, p => p);

            var result = new List<RatingDto>();

            foreach (var rating in ratings)
            {
                players.TryGetValue(rating.PlayerId, out var player);
                result.Add(rating.ToDto(player));
            }

            return result;
        }

        // Додати запис зміни рейтингу + оновити поточний рейтинг гравця
        public void AddRating(int playerId, int ratingChange, string reason)
        {
            var player = _playerRepository.GetById(playerId);
            if (player == null)
            {
                Console.WriteLine("Гравця з таким Id не знайдено.");
                return;
            }

            // Оновлюємо рейтинг гравця
            player.Rating += ratingChange;
            _playerRepository.Update(player);

            // Додаємо запис в історію
            var ratingEntity = new RatingEntity
            {
                PlayerId = playerId,
                RatingChange = ratingChange,
                Reason = reason
            };

            _ratingRepository.Add(ratingEntity);
        }

        // Складна бізнес-логіка (приклад):
        // "Епічна битва": джедаї отримують +100, імперія -50.
        public void RunEpicBattleScenario()
        {
            Console.WriteLine("✅ Запускаю епічну подію: Битва за Галактику!");

            foreach (var player in _db.Players)
            {
                var accountType = _db.AccountTypes.FirstOrDefault(t => t.Id == player.AccountTypeId);
                if (accountType == null) continue;

                if (accountType.TypeName == "JediOrder")
                {
                    AddRating(player.Id, +100, "Перемога для Джедаїв у епічній битві");
                }
                else if (accountType.TypeName == "GalacticEmpire")
                {
                    AddRating(player.Id, -50, "Поразка Імперії у епічній битві");
                }
                else
                {
                    // Інші фракції отримують невеликі бонуси
                    AddRating(player.Id, +20, "Участь у битві за Галактику");
                }
            }

            Console.WriteLine("⚔️ Епічна битва завершена. Рейтинг гравців оновлено.");
        }
    }
}
