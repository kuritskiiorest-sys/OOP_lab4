using System;

namespace StarWarsGame.Commands
{
    // Базовий інтерфейс для всіх команд.
    // Гарантує наявність:
    //  - Назви команди (Name)
    //  - Опису (Description)
    //  - Методу виконання (Execute)
    public interface ICommand
    {
        string Name { get; }         // Наприклад: "show-players"
        string Description { get; }  // Людський опис команди

        void Execute();              // Логіка виконання команди
    }
}