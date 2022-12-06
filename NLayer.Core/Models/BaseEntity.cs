using NLayer.Core.Enums;
using NLayer.Core.ModelInterfaces;

namespace NLayer.Core.Models
{
    public abstract class BaseEntity: IEntity
    {
        public BaseEntity()
        {
            Status = DataStatus.Inserted;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }



    }
}