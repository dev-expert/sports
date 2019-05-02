using System;
using System.ComponentModel;
using Sports.Models;

namespace Sports.ViewModels
{
    public class TestsList
    {
        public int TestId { get; set; }

        public DateTime Date { get; set; }

        [DisplayName("No of Participants")]
        public int NumberOfParticipants { get; set; }

        [DisplayName("Test Type")]
        public TestTypes TestType { get; set; }
    }
}
