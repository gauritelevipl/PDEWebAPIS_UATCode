using System.ComponentModel.DataAnnotations;

namespace PDEWebAPIS.Model
{
    public class pinCodeApiResponseModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? BranchType { get; set; }
        public string? DeliveryStatus { get; set; }
        public string? Circle { get; set; }
        public string? District { get; set; }
        public string? Division { get; set; }
        public string? Region { get; set; }
        public string? Block { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Pincode { get; set; }
    }
}
