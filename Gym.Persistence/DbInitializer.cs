using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Persistence
{
    //запускается при старте и проверяет создана ли бд. Если нет, то создается по контексту
    public class DbInitializer
    {
        public static void Initialize(GymDbContext context) 
        {
            context.Database.EnsureCreated();        
        }
    }
}
