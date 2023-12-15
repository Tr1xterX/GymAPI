using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 
using Gym.Domain;

//Интерфейс - часть приложения. Реализация во вне
namespace Gym.Application.Interfaces
{
    public interface IGymDbContext
    {
        DbSet<Exercices> Exercices { get; set; }//коллекция всех сущностей в контексте и может запрашиваться из бд
        Task<int> SaveChangesAsync(CancellationToken cancellationToken); // сохраняет изменение контекста в бд
    }
}
