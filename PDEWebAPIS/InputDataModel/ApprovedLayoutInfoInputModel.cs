namespace PDEWebAPIS.InputDataModel
{
    public class ApprovedLayoutInfoInputModel
    {
        public string? applicationid { get; set; }
        public int userid { get; set; }
        public string? layoutApprovingAuthority { get; set; }
        public string? layoutOfficeName {  get; set; }
        public string? orderNo { get; set; }
        public string? orderDate {  get; set; }
        public string? approvedLayoutNo {  get; set; }
        public string? approvedLayoutDate {  get; set; }
        public string? measurementRegNo { get; set; }
        public string? measurementDate { get; set; }
        public string? isLayoutAttached { get; set; }
    }
    public class FetchApprovedLayoutInfo
    {
        public int approvedlayoutid { get; set; }
        public string? applicationid { get; set; }
        public int userid { get; set; }
        public string? layoutApprovingAuthority { get; set; }
        public string? layoutOfficeName { get; set; }
        public string? orderNo { get; set; }
        public string? orderDate { get; set; }
        public string? approvedLayoutNo { get; set; }
        public string? approvedLayoutDate { get; set; }
        public string? measurementRegNo { get; set; }
        public string? measurementDate { get; set; }
        public string? isLayoutAttached { get; set; }
    }
}
