using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//описание сущностей в проекте

namespace Gym.Domain
{
    public class Exercices
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ImageLink { get; set; }
        public string MainMuscle { get; set; }
        public string SecondaryMuscle { get; set; }
        public int Difficulty { get; set; }
        public int Intensity { get; set; }
    }
    public class Routine
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Deeplink { get; set; }
        public string ImageLink { get; set; }
        public string Gender { get; set; }
        public int Difficulty { get; set; }
        //public List <Exercises> Exercises { get; set; }
    }
}
