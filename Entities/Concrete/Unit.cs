using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Unit : IEntity
    {
        public int Id { get; set; }
        public int UnitCode { get; set; }
        public string UnitName { get; set; }
        public AcademicCalender AcademicCalender { get; set; }
        public Report Report { get; set; }
        public Message Message { get; set; }
        public Contact Contact { get; set; }
        public Event Event { get; set; }
        public Announcement Announcement { get; set; }
        public Food Food { get; set; }

    }
}
