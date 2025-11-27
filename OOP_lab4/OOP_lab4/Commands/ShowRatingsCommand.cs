using System;
using StarWarsGame.Service.Base;

namespace StarWarsGame.Commands
{
    // Команда для відображення історії рейтингу
    public class ShowRatingsCommand : ICommand
    {
        private readonly IRatingService _ratingService;

        public string Name => "show-ratings";
        public string Description => "Показати історію змін рейтингу";

        public ShowRatingsCommand(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        public void Execute()
        {
            Console.WriteLine("Історія рейтингу");

            var ratings = _ratingService.GetAllRatings();

            foreach (var r in ratings)
            {
                Console.WriteLine($"{r.PlayerName}: {r.RatingChange} ({r.Reason})");
            }
        }
    }
}