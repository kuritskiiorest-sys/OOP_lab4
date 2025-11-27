using System.Collections.Generic;
using StarWarsGame.Entities;

namespace StarWarsGame.Database
{
    // Симуляція бази даних — зберігає дані в колекціях у пам'яті.
    public class StarWarsDbContext
    {
        // "Таблиця" гравців
        public List<PlayerEntity> Players { get; set; }

        // "Таблиця" типів акаунтів
        public List<AccountTypeEntity> AccountTypes { get; set; }

        // "Таблиця" ігор/місій
        public List<GameEntity> Games { get; set; }

        // "Таблиця" змін рейтингу
        public List<RatingEntity> Ratings { get; set; }

        // "Таблиця" предметів
        public List<EquipmentEntity> Equipment { get; set; }

        // "Таблиця" здібностей
        public List<AbilityEntity> Abilities { get; set; }

        // "Таблиця" планет
        public List<PlanetEntity> Planets { get; set; }

        // Конструктор ініціалізує колекції та заповнює їх тестовими даними
        public StarWarsDbContext()
        {
            Players = new List<PlayerEntity>();
            AccountTypes = new List<AccountTypeEntity>();
            Games = new List<GameEntity>();
            Ratings = new List<RatingEntity>();
            Equipment = new List<EquipmentEntity>();
            Abilities = new List<AbilityEntity>();
            Planets = new List<PlanetEntity>();

            Seed();
        }

        // Початкове наповнення бази даних
        private void Seed()
        {
            // Типи акаунтів
            AccountTypes.Add(new AccountTypeEntity { Id = 1, TypeName = "JediOrder" });
            AccountTypes.Add(new AccountTypeEntity { Id = 2, TypeName = "GalacticEmpire" });
            AccountTypes.Add(new AccountTypeEntity { Id = 3, TypeName = "RebelAlliance" });

            // Гравці
            Players.Add(new PlayerEntity { Id = 1, Name = "Люк Скайвокер", AccountTypeId = 1, Rating = 1500 });
            Players.Add(new PlayerEntity { Id = 2, Name = "Дарт Вейдер", AccountTypeId = 2, Rating = 2000 });
            Players.Add(new PlayerEntity { Id = 3, Name = "Хан Соло", AccountTypeId = 3, Rating = 1400 });

            // Ігри / місії
            Games.Add(new GameEntity { Id = 1, GameName = "Битва при Явіні" });
            Games.Add(new GameEntity { Id = 2, GameName = "Тренування на Дагобі" });

            // Історія рейтингу
            Ratings.Add(new RatingEntity { Id = 1, PlayerId = 1, RatingChange = +150, Reason = "Перемога в битві при Явіні" });
            Ratings.Add(new RatingEntity { Id = 2, PlayerId = 2, RatingChange = -50, Reason = "Поразка в дуелі" });

            // Предмети
            Equipment.Add(new EquipmentEntity { Id = 1, Name = "Світловий меч", Type = "Weapon" });
            Equipment.Add(new EquipmentEntity { Id = 2, Name = "Бластер", Type = "Weapon" });

            // Здібності
            Abilities.Add(new AbilityEntity { Id = 1, Name = "Force Push", Description = "Відштовхує суперника Силою" });
            Abilities.Add(new AbilityEntity { Id = 2, Name = "Force Choke", Description = "Душіння Силою" });

            // Планети
            Planets.Add(new PlanetEntity { Id = 1, Name = "Татуїн", Region = "Outer Rim" });
            Planets.Add(new PlanetEntity { Id = 2, Name = "Корусант", Region = "Core Worlds" });
        }
    }
}
