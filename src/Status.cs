using System.Collections.Generic;
using System.Linq;

namespace EfCoreSmartEnum
{
    public class Status
    {
        public string Name { get; init; }
        public string Description { get; init; }

        private Status() { }

        public static Status Active => new Status { Name = "Active", Description = "Currently actively driving F1 cars." };
        public static Status Retired => new Status { Name = "Retired", Description = "No longer driving F1 cars." };
        public static Status Upcoming => new Status { Name = "Upcoming", Description = "Soon to be driving F1 cars." };
        public static Status Unknown => new Status { Name = "Unknown", Description = "We don't know what happened here..."  };

        private static readonly Status[] _List = { Active , Retired, Upcoming };

        public static IEnumerable<Status> List => _List;

        public static Status Find(string name) => _List.FirstOrDefault(status => status.Name == name) ?? Unknown;
    }
}