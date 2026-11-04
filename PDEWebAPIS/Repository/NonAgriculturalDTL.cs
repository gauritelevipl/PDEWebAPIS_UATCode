using DocumentFormat.OpenXml.Bibliography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDEWebAPIS.Repository
{
    [Table("non_agricultural_info")]
    public class NonAgriculturalDTL
    {
        [Key, Required]
        public int nonagriculturalid { get; set; }
        public UserMaster? userMaster { get; set; }
        public ApplicationDTL? applicationDTL { get; set; }
        public string? competentauthority { get; set; }
        public string? office_name {  get; set; }
        public string? orderno {  get; set; }
        public string? orderdate {  get; set; }
        public string? approved_drawing_plan{  get; set; }
        public string? approved_drawing_no {  get; set; }
        public string? approved_drawing_date {  get; set; }
        public string? receipt_no_for_non_agricultural_assessment {  get; set; }
        public string? receipt_date_for_non_agricultural_assessment { get; set; }
        public string? amount_of_non_agricultural_assessment { get; set; }
        public string? area_as_per_the_latest_report {  get; set; }
        public string? area_as_per_non_agricultural_assessment { get; set; }
        public string? plot_no {  get; set; }
        public string? non_agricultural_flag {  get; set; }
        public DateTime createddatetime { get; set; }
        public bool isdeleted { set; get; }
        public DateOnly deleteddate { set; get; }
    }
}
