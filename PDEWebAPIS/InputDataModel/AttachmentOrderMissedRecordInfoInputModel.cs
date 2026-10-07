namespace PDEWebAPIS.InputDataModel
{
    public class AttachmentOrderMissedRecordInfoInputModel
    {
        public string? applicationid { get; set; }
        public int userid { get; set; }
        public string? nondichaTapshil { get; set; }
    }
    public class FetchAttachmentOrderMissedRecordInfo
    {
        public int attachmentorderid { get; set; }
        public string? applicationid { get; set; }
        public int userid { get; set; }
        public string? nondichaTapshil { get; set; }
    }
}
