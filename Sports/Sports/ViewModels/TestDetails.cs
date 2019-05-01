using System;
using System.Collections.Generic;

namespace Sports.ViewModels
{
    public class TestDetails
    {
        public int TestID { get; set; }
        public List<TestSubscriptionVM> testSubscriptions { get; set; }
    }
    public class TestSubscriptionVM
    {
        public int TestID { get; set; }
        public int TestSubscriptionID { get; set; }
        public string Ranking { get; set; }
        public int AtheleteId { get; set; }
        public string Distance { get; set; }
        public DateTime? date { get; set; }
    }
}
