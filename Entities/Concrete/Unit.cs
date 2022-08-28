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
        public List<AcademicCalender> AcademicCalenders { get; set; }
        public List<Announcement> Announcements { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Event> Events { get; set; }
        public List<Food> Foods { get; set; }
        public List<Message> Messages { get; set; }
        public List<Report> Reports { get; set; }
        public List<Slider> Sliders { get; set; }
    }
}
