using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDEWebAPIS.Repository
{
    [Table("blacklisttokenforgrievance")]
    public class BlacklistTokenForGrievance
    {
        [Key, Required]
        public int blacklistId { get; set; }

        public string? Token { get; set; }

        public DateTime ExpirationTime { get; set; }


        public DateTime createdDateTime { get; set; }
    }
}