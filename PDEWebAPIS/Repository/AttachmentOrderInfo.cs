using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.InkML;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using System.Reflection;

namespace PDEWebAPIS.Repository
{
    [Table("attachment_order_info")]
    public class AttachmentOrderInfo
    {
        [Key, Required]
        public int attachmentorderid { get; set; }
        public UserMaster? userMaster { get; set; }
        public ApplicationDTL? applicationDTL { get; set; }
        public string? nabhu_no {  get; set; }
        public string? mutation_srno {  get; set; }
        public string? owner_number { get; set; }
        public string? owner_name { get; set; }
        public string? area {  get; set; }
        public string? agencies_issuing_attachment_orders {  get; set; }
        public string? name_of_the_agency_issuing_the_attachment_order {  get; set; }
        public string? address_of_the_agency_issuing_the_attachment_order { get; set; }
        public string? attachment_order_number {  get; set; }
        public string? date_of_the_attachment_order { get; set; }
        public string? is_the_attachment_order_issued_by_a_credit_society_or_a_bank {  get; set; }
        public string? recovery_cert_under_section_101_issued_by_the_cooperative_officer {  get; set; }
        public string? recovery_cert_issued_by_the_cooperative_officer_in_91 { get; set; }
        public string? recovery_cert_for_105_issued_by_the_liquidator {  get; set; }
        public string? orbiter_order_no {  get; set; }
        public string? orbiter_order_date { get; set; }
        public string? by_order_recording_entries_that_were_missed_during_computerization {  get; set; }
        public DateTime createddatetime { get; set; }
        public bool isDeleted { set; get; }
        public DateOnly deleteddate { set; get; }

    }
}
