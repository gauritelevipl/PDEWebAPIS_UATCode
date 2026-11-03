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
}
