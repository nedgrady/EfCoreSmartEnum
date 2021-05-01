using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EfCoreSmartEnum
{
    public class Driver
    {
        public static IEnumerable<Driver> TestSeedData => new Driver[]
        {
            new Driver { Name = "Kimi Raikonnen", Status = Status.Active },
            new Driver { Name = "Lewis Hamilton", Status = Status.Active },
            new Driver { Name = "Gus Brooks", Status = Status.Upcoming },
            new Driver { Name = "Nikki Louder", Status = Status.Retired }
        };

        public int DriverId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Status Status { get; set; }
    }
}