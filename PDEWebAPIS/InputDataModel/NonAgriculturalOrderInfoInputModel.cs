using PDEWebAPIS.Repository;

namespace PDEWebAPIS.InputDataModel
{
    public class NonAgriculturalOrderInfoInputModel
    {
        public string? applicationId { get; set; }
        public int userid { get; set; }
        public string? authority { get; set; }
        public string? office {  get; set; }
        public string? orderNo {  get; set; }
        public string? orderDate {  get; set; }
        public string? recordBook { get; set; }
        public string? recordBookNo { get; set; }
        public string? recordBookDate { get; set; }
    }
    public class FetchNonAgriculturalOrderInfo
    {
        public int nonagriculturalid { get; set; }
        public string? applicationId { get; set; }
        public int userid { get; set; }
        public string? authority { get; set; }
        public string? office { get; set; }
        public string? orderNo { get; set; }
        public string? orderDate { get; set; }
        public string? recordBook { get; set; }
        public string? recordBookNo { get; set; }
        public string? recordBookDate { get; set; }
    }

    public class FetcNonAgriculturalInfo
    {
        public int nonagriculturalid { get; set; }
        public string? applicationid { get; set; }
        public int userid { get; set; }
        public string? competentauthority { get; set; }
        public string? office_name { get; set; }
        public string? orderno { get; set; }
        public string? orderdate { get; set; }
        public string? approved_drawing_plan { get; set; }
        public string? approved_drawing_no { get; set; }
        public string? approved_drawing_date { get; set; }
        public string? receipt_no_for_non_agricultural_assessment { get; set; }
        public string? receipt_date_for_non_agricultural_assessment { get; set; }
        public string? amount_of_non_agricultural_assessment { get; set; }
        public string? area_as_per_the_latest_report { get; set; }
        public string? area_as_per_non_agricultural_assessment { get; set; }
        public string? plot_no { get; set; }
        public string? non_agricultural_flag { get; set; }
    }
}
