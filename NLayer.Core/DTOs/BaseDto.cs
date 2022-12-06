using NLayer.Core.Enums;

namespace NLayer.Core.DTOs
{
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
