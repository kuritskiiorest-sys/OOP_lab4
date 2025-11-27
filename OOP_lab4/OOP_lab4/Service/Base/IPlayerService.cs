using System.Collections.Generic;
using StarWarsGame.DTO;

namespace StarWarsGame.Service.Base
{
    // Інтерфейс сервісу гравців — бізнес-логіка, не залежна від деталей БД.
    public interface IPlayerService
    {
        // Отримати всіх гравців у вигляді DTO (для відображення)
        IEnumerable<PlayerDto> GetAllPlayers();

        // Додати нового гравця
        void AddPlayer(string name, int accountTypeId);
    }
}