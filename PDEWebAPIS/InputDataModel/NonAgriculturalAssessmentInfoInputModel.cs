namespace PDEWebAPIS.InputDataModel
{
    public class NonAgriculturalAssessmentInfoInputModel
    {
        public string? applicationId {  get; set; }
        public int userid { get; set; }
        public string? competentAuthority { get; set; }
        public string? collectingOfficeName {  get; set; }
        public string? receiptNo { get; set; }
        public string? receiptDate { get; set; }
        public string? assessmentAmount {  get; set; }
        public string? akhivArea { get; set; }
        public string? gairKrushiArea { get; set; }
        public string? bhukhandNo {  get; set; }
    }
    public class FetchNonAgriculturalAssessmentInfo
    {
        public int nonagriculturalid { get; set; }
        public string? applicationId { get; set; }
        public int userid { get; set; }
        public string? competentAuthority { get; set; }
        public string? collectingOfficeName { get; set; }
        public string? receiptNo { get; set; }
        public string? receiptDate { get; set; }
        public string? assessmentAmount { get; set; }
        public string? akhivArea { get; set; }
        public string? gairKrushiArea { get; set; }
        public string? bhukhandNo { get; set; }
    }
}
