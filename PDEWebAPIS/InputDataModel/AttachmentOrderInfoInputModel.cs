namespace PDEWebAPIS.InputDataModel
{
    public class AttachmentOrderInfoInputModel
    {
        public string? applicationid {  get; set; }
        public int userid { get; set; }
        public string? nabhu {  get; set; }
        public List<OwnerDTLForAttachmentOrderInfo>? selectedOwners {  get; set; }
        public string? institution {  get; set; }
        public string? institutionName {  get; set; }
        public string? institutionAddress { get; set; }
        public string? orderNo {  get; set; }
        public string? orderDate {  get; set; }
        public string? isRecoveryApplicable { get; set; }
        public string? recovery101 {  get; set; }
        public string? recovery91 { get; set; }
        public string? recovery105 { get; set; }
        public string? arbitratorOrder {  get; set; }
        public string? arbitratorOrderDate { get; set; }
    }

    public class OwnerDTLForAttachmentOrderInfo
    {
        public string? mutation_srno {  get; set; }
        public string? owner_number { get; set; }
        public string? owner_name { get; set; }
        public string? area {  get; set; }
    }

    public class FetchAttachmentOrderInfo
    {
        public int attachmentorderid { get; set; }
        public string? applicationid { get; set; }
        public int userid { get; set; }
        public string? nabhu { get; set; }
        public OwnerDTLForAttachmentOrderInfo? selectedOwners { get; set; }
        public string? institution { get; set; }
        public string? institutionName { get; set; }
        public string? institutionAddress { get; set; }
        public string? orderNo { get; set; }
        public string? orderDate { get; set; }
        public string? isRecoveryApplicable { get; set; }
        public string? recovery101 { get; set; }
        public string? recovery91 { get; set; }
        public string? recovery105 { get; set; }
        public string? arbitratorOrder { get; set; }
        public string? arbitratorOrderDate { get; set; }
    }

}
