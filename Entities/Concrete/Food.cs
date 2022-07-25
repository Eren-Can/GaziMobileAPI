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
        public string Name { get; set; }
        public int Calorie { get; set; }
        public DateTime Date { get; set; }   
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
    }
}
