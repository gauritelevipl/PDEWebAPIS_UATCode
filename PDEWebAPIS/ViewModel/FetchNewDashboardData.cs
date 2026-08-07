using PDEWebAPIS.Model;

namespace PDEWebAPIS.ViewModel
{
    public class FetchDashboardDataForDivision
    {
        public int regionCode {  get; set; }
        public string? regionNameInMarathi { get; set; }
        public string? regionNameInEnglish { get; set; }
        public int createdApplicationCount {  get; set; }
        public int generatedInwardNoCount {  get; set; }
        public int totalApplicationCount {  get; set; }
    }
    public class FetchDashboardDataForDistrict
    {
        public int districtCode { get; set; }
        public string? districtNameInMarathi { get; set; }
        public string? districtNameInEnglish { get; set; }
        public int createdApplicationCount { get; set; }
        public int generatedInwardNoCount { get; set; }
        public int totalApplicationCount { get; set; }
    }
    public class FetchDashboardDataForOffice
    {
        public string? officeCode { get; set; }
        public string? officeNameInMarathi { get; set; }
        public string? officeNameInEnglish { get; set; }
        public int createdApplicationCount { get; set; }
        public int generatedInwardNoCount { get; set; }
        public int totalApplicationCount { get; set; }
    }
    public class NewDashboardOfficeData
    {
        public string? regionCode { get; set; }
        public string? districtCode { get; set; }
    }
    public class FetchEPCISgetDashboardMetrics
    {
        public string? state_name { get; set; }
        public string? divisioncode { get; set; }
        public string? divisionname { get; set; }
        public string? districtcode { get; set; }
        public string? districtname { get; set; }
        public string? officecode { get; set; }
        public string? officename { get; set; }
        public string? total_inward { get; set; }
        public string? pending_at_ms_inward { get; set; }
        public string? pending_at_ctso_inward { get; set; }
        public string? disposed_inward { get; set; }
        public string? totalCreatedApplicationCount { get; set; }
    }
    public class DashboardMetricsData
    {
        public List<FetchEPCISgetDashboardMetrics>? ePCISgetDashboardMetricsResponse { get; set; }
        //public string? totalCreatedApplicationCount { get; set; }
    }
}
