using StarWarsGame.DTO;
using StarWarsGame.Entities;

namespace StarWarsGame.Mappers
{
    // Маппер для конвертації RatingEntity → RatingDto
    public static class RatingMapper
    {
        public static RatingDto ToDto(this RatingEntity rating, PlayerEntity player)
        {
            return new RatingDto
            {
                PlayerName = player?.Name ?? "Невідомий гравець",
                RatingChange = rating.RatingChange,
                Reason = rating.Reason
            };
        }
    }
}