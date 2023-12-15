using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;

//для орнаизации конфиг маппинга
//дописать при конфигураци приложения 
namespace Gym.Application.Common.Mappings
{
    public class AssemblyMappingProfile : Profile
    {
        //конструктор, что представляет сброку 
        public AssemblyMappingProfile(Assembly assembly) =>
            ApplyMappingFromAssembly(assembly);
        //для применения маппинга из сборки
        //Скан сборки и поиск типов, которые реализют интерфейс ImapWith
        private void ApplyMappingFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(type => type.GetInterfaces()
                    .Any(i => i.IsGenericType &&
                    i.GetGenericTypeDefinition() == typeof(IMapWith<>)))
                .ToList();

            //вызывает метод Мапинг от насл типа/интерфейса (если без реализации
            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }

        }
    }

}
