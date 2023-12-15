using Microsoft.EntityFrameworkCore; //разделяет конфигурации для типа сущности на отдельный класс, чтобы потом использовать в DB контексте 
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Gym.Domain;
//Создержит конфигурации сущностей для быстрого масштабирования

namespace Gym.Persistence.EntityTypeConfigurations
{
    public class GymConfiguration : IEntityTypeConfiguration <Exercices>
    {
        //реализация конфиг для типа сущности
        public void Configure(EntityTypeBuilder<Exercices> builder)
        {
            builder.HasKey(exersise => exersise.Id); //id - наш ключ и он уникален
            builder.HasIndex(note => note.Id).IsUnique();
            builder.Property(note=>note.Title).HasMaxLength(50);
            //ДОДЕЛАТЬ: возможно другие ограничение полей
        }
    }
}
