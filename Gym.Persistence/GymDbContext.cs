using Microsoft.EntityFrameworkCore;
using Gym.Application.Interfaces;
using Gym.Domain;
using Gym.Persistence.EntityTypeConfigurations;

//реализация интерфейса IGymDbContext, унаслед от EntDBContext
namespace Gym.Persistence
{
    public class GymDbContext : DbContext, IGymDbContext
    {
        public DbSet<Exercices> Exercices { get; set; }

        public GymDbContext(DbContextOptions<GymDbContext> options)
            : base(options) { }

        //переопределяем метод, чтобы сообщить фреймворку информацию о сущностях
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new GymConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
