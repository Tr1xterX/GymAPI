using AutoMapper;

namespace Gym.Application.Common.Mappings
{
    public class IMapWith<T>
    {
        void Mapping(Profile profile) =>
            profile.CreateMap(typeof(T),GetType());
    }
}
