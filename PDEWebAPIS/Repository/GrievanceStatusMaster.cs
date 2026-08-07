using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDEWebAPIS.Repository
{
    [Table("grievanceStatusMaster")]
    public class GrievanceStatusMaster
    {
        [Required,Key]
        public int statusId { get; set; }   


        public string? status { get; set; }

        public int statusCode { get; set; }
    }
}
