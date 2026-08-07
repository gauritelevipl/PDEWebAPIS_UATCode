namespace PDEWebAPIS.InputDataModel
{
    public class TrutipatraDetailsData
    {
        public int uploaded_doc_id { set; get; }
        public int usermasteruserid { set; get; }
        public string? applicationdtlapplicationid { set; get; }
        public string? document_type_code { set; get; }
        public string? document_type { get; set; }
        public string? city_servey_no { set; get; }
        public string? document_name { set; get; }
        public string? document_path { set; get; }
        public string? createddatetime { set; get; }
        public bool isdeleted { set; get; }
        public string? deleteddate { set; get; }
    }
}
