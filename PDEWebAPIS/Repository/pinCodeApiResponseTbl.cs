using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PDEWebAPIS.Repository
{
    [Index(nameof(Pincode), nameof(Name), IsUnique = true)]
    //prevent duplicate entries of the same Pincode & Name combination.
    [Table("pinCodeApiResponseTbl")]
    public class pinCodeApiResponseTbl
    {
        [Key]
        public int pId { get; set; }

        public string? Name { get; set; }
   
        public string? Description { get; set; }

        public string? BranchType { get; set; }

        public string? DeliveryStatus { get; set; }

        public string? Circle { get; set; }

        public string? District { get; set; }

        public string? Division { get; set; }

        public string? Region { get; set; }

        public string? Block { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

        public string? Pincode { get; set; }
        public string? createdDateTime { get; set; }
    }
}
