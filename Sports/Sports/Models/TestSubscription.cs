using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sports.Models
{
    public class TestSubscription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestSubscriptionID { get; set; }
        public string Distance { get; set; }
        [ForeignKey(nameof(Tests))]
        public int TestID { get; set; }
        [ForeignKey(nameof(Athletes))]
        public int AthleteId { get; set; }
        public Athletes Athletes { get; set; }
        public Tests Tests { get; set; }
    }
}
