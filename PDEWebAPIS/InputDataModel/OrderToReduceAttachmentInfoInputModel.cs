namespace PDEWebAPIS.InputDataModel
{
    public class OrderToReduceAttachmentInfoInputModel
    {
        public string? applicationid { get; set; }
        public int userid { get; set; }
        public string? nabhu { get; set; }
        public List<OwnerDTLForOrderToReduceAttachment>? selectedOwners { get; set; }
        public string? institution { get; set; }
        public string? institutionName { get; set; }
        public string? institutionAddress { get; set; }
        public string? orderNo { get; set; }
        public string? orderDate { get; set; }
    }
    public class OwnerDTLForOrderToReduceAttachment
    {
        public string? mutation_srno { get; set; }
        public string? owner_number { get; set; }
        public string? owner_name { get; set; }
        public string? area { get; set; }
    }

    public class FetchOrderToReduceAttachmentInfo
    {
        public int attachmentorderid { get; set; }
        public string? applicationid { get; set; }
        public int userid { get; set; }
        public string? nabhu { get; set; }
        public OwnerDTLForOrderToReduceAttachment? selectedOwners { get; set; }
        public string? institution { get; set; }
        public string? institutionName { get; set; }
        public string? institutionAddress { get; set; }
        public string? orderNo { get; set; }
        public string? orderDate { get; set; }
    }
}
