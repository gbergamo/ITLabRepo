using System;

namespace ITLabTest.AppService.ViewModel
{
    public class PersonViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }
        public int Sex { get; set; }
        public string SexDescription { get; set; }
    }
}
