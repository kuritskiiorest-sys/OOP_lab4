using System.Collections.Generic;
using StarWarsGame.Entities;

namespace StarWarsGame.Repository.Base
{
    // Інтерфейс репозиторію гравців — інкапсулює доступ до даних Players.
    public interface IPlayerRepository
    {
        // Отримати гравця за Id
        PlayerEntity GetById(int id);

        // Отримати всіх гравців
        IEnumerable<PlayerEntity> GetAll();

        // Додати нового гравця
        PlayerEntity Add(PlayerEntity player);

        // Оновити існуючого гравця
        void Update(PlayerEntity player);
    }
}