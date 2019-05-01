using System;
using Sports.Models;

namespace Sports.ViewModels
{
    public class TestsList
    {
        public int TestId { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfParticipants { get; set; }
        public TestTypes TestType { get; set; }
    }
}
