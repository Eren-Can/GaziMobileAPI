using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Food : IEntity
    {
        public int Id { get; set; }
        public string Soup { get; set; }
        public int SoupCalorie { get; set; }
        public string FirstMainCourse { get; set; }
        public int FirstMainCalorie { get; set; }
        public string SecondMainCourse { get; set; }
        public int SecondMainCalorie { get; set; }
        public string VegetableCourse { get; set; }
        public int VegetableCalorie { get; set; }
        public string Other { get; set; }
        public int OtherCalorie { get; set; }
        public int TotalCalorie { get; set; }
        public DateTime Date { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
    }
}
