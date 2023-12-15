using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Gym.Domain;
using Gym.Application.Interfaces;

//Обработчик создания команд
namespace Gym.Application.Exercises.Commands.CreateExercises
{
    //Что необходимо для создания упр и логику создания
    public class CreateExercisesCommandHandler
        : IRequestHandler<CreateExercisesComands, Guid> //тип запроса и ответа
    {
        //внедрение зависимости на контекст базы данных в класс через конструктоp
        private readonly IGymDbContext _dbContext;

        public CreateExercisesCommandHandler(IGymDbContext dbContext)=>
            _dbContext = dbContext;
       public async Task<Guid> Hendle(CreateExercisesComands request,
           CancellationToken cancellationToken)
        {
            //формируем упражнеие из нашего запроса и возвращаем ID упр
            var exercise = new Exercices
            {
                Id = request.Id,
                Title = request.Title,
                MainMuscle = request.MainMuscle,
                SecondaryMuscle = request.SecondaryMuscle,
                Subtitle = request.Subtitle,
                Difficulty = 0,
                Intensity = 0,
                ImageLink = null

            };
            //добавление созданного упр в контект, а затем в бд
            await _dbContext.Exercices.AddAsync(exercise, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return exercise.Id;
        }
    }
}
