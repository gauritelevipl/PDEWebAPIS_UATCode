using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static PDEWebAPIS.InputDataModel.INameWithCodeFormatData;

namespace PDEWebAPIS.Repository
{
    [Table("declaration_entry_info")]
    public class DeclarationEntryInfo
    {
        [Key, Required]
        public int declarationid { get; set; }
        public UserMaster? userMaster { get; set; }
        public ApplicationDTL? applicationDTL { get; set; }
        public int type_of_authority_approving_the_construction_plan_code {  get; set; }
        public string? type_of_authority_approving_the_construction_plan { get; set; }
        public string?company_name { get; set; }
        public string? map_approval_order_no {  get; set; }
        public string? map_approval_order_date {  get; set; }
        public string? construction_start_cert_no { get; set; }
        public string? construction_start_cert_date { get; set; }
        public string? occupancy_certificate_file_name {  get; set; }
        public string? occupancy_certificate_file_path {  get; set; }
        public string? occupancy_certificate_date {  get; set; }
        public DateTime createddatetime { get; set; }
        public bool isDeleted { set; get; }
        public DateOnly deleteddate { set; get; }
        // Below fields added on 04 Nov 2026
        public string? occupancy_certificate_number { get; set; }
        public string? is_there_a_development_agreement {  get; set; }
        public string? sub_registrar_office {  get; set; }
        public string? reg_document_no { get; set; }
        public string? document_year {  get; set; }
        public string? document_registration_date {  get; set; }
    }
}
