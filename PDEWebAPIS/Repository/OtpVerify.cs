using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDEWebAPIS.Repository
{
    [Table("otp_verify")]
    public class OtpVerify
    {

        public string mobileno { get; set; } = string.Empty;
        [Required, MaxLength(6)]
        public Int64 otp { get; set; }
        public DateTime createddatetime { set; get; }
    }
}
