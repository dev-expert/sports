using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sports.Models
{
    public class Athletes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AthleteId { get; set; }
        public string AthleteName { get; set; }
        public string Password { get; set; }
        [ForeignKey(nameof(Roles))]
        public int RoleId { get; set; }
        public Roles Roles { get; set; }
    }
}
