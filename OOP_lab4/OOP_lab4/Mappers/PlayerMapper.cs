using System.Collections.Generic;
using System.Linq;
using StarWarsGame.DTO;
using StarWarsGame.Entities;

namespace StarWarsGame.Mappers
{
    // Маппер для конвертації PlayerEntity → PlayerDto
    public static class PlayerMapper
    {
        public static PlayerDto ToDto(this PlayerEntity entity, List<AccountTypeEntity> accountTypes)
        {
            // Знаходимо тип акаунта за Id
            var type = accountTypes.FirstOrDefault(t => t.Id == entity.AccountTypeId);

            return new PlayerDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Rating = entity.Rating,
                AccountType = type?.TypeName ?? "Unknown"
            };
        }
    }
}