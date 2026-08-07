using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDEWebAPIS.Repository
{
    [Table("labelmaster")]
    public class LabelMaster
    {
        [Key, Required]
        public int labelid { get; set; }
        public ScreenMaster? screenMaster { get; set; }
        public MutationTypeMaster? mutationTypeMaster { get; set; }
        //public string? mutationtype { set; get; }
        //public string? mutationname { set; get; }
        public string? englishname { set; get; }
        public string? marathiname { set; get; }
        public string? createdby { set; get; }

        public DateTime createddatetime { set; get; }

        public DateTime updateddatetime { set; get; }
    }
}
