using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sports.Models
{
    public class Tests
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestId { get; set; }
        [ForeignKey(nameof(TestTypes))]
        public int TestTypeID { get; set; }
        public DateTime Date { get; set; }
        public TestTypes TestTypes { get; set; }
    }
}
