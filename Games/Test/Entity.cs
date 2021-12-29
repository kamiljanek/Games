using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Entity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class DayEntity 
        {
        public DayEntity(int id, string code, string name)
        {
            Id = id;
            Code = code;
            Name = name;
        }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    
    public class TypeEntity : Entity
    {

    }
    public class HourEntity : Entity
    {

    }
    public class WeatherArchives
    {
        public static void Main()
        {
            List<DayEntity> dayEntity = new List<DayEntity>();
            dayEntity.Add(new DayEntity(1, "mniam", "Today"));



        }
    }
   
}
