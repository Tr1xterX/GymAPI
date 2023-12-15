using System;
using MediatR;

namespace Gym.Application.Exercises.Commands.CreateExercises
{
    //помечает результат выполнения данной команды и возвращает рез опр типа
    public class CreateExercisesComands : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string MainMuscle { get; set; }
        public string SecondaryMuscle { get; set; }

    }
}
