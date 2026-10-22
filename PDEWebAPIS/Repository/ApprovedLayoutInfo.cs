using Humanizer;
using NuGet.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDEWebAPIS.Repository
{
    [Table("approved_layout_info")]
    public class ApprovedLayoutInfo
    {
        [Key, Required]
        public int approvedlayoutid { get; set; }
        public UserMaster? userMaster { get; set; }
        public ApplicationDTL? applicationDTL { get; set; }
        public string? competent_authority_approving_the_layout {  get; set; }
        public string? name_of_the_office {  get; set; }
        public string? order_no {  get; set; }
        public string? order_date {  get; set; }
        public string? approved_layout_drawing_no {  get; set; }
        public string? approved_layout_drawing_date { get; set; }
        public string? measurement_no {  get; set; }
        public string? measurement_date { get; set; }
        public string? is_it_attached_to_the_approved_layout_case {  get; set; }
        public DateTime createddatetime { get; set; }
        public bool isdeleted { set; get; }
        public DateOnly deleteddate { set; get; }
    }
}
