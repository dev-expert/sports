using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sports.Models
{
    public class TestTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestTypeId { get; set; }

        [DisplayName("Test Name")]
        public string TestName { get; set; }
    }
}
