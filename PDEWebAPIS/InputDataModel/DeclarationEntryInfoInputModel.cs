namespace PDEWebAPIS.InputDataModel
{
    public class DeclarationEntryInfoInputModel
    {
        public string? applicationid {  get; set; }
        public int userid { get; set; }
        public UserDetailsForDeclarationEntry? userDetails {  get; set; }
        public GhoshanaPatraDetails? ghoshnaPatraDetails {  get; set; }
    }

    public class UserDetailsForDeclarationEntry
    {
        public string? userType {  get; set; }
        public string? userTypeLabel { get; set; }
    }
    public class GhoshanaPatraDetails
    {
        public string? approvingAuthorityOther {  get; set; }
        public string? mapApprovalOrderNo {  get; set; }
        public string? mapApprovalOrderDate { get; set; }
        public string? constructionStartCertNo { get; set; }
        public string? constructionStartCertDate { get; set; }
        public OccupancyCertInfo? occupancyCertNo {  get; set; }
        public string? occupancyCertDate {  get; set; }
    }
    public class OccupancyCertInfo
    {
        public string? name {  get; set; }
        public string? src { get; set; }
    }
}
