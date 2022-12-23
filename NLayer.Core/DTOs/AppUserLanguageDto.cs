

using NLayer.Core.Enums;

namespace NLayer.Core.DTOs
{
    public class AppUserLanguageDto : IBaseDto
    {
        public int ID { get; set; }
        public DataStatus Status { get; set; }
        public int LanguageID { get; set; }
        public int AppUserID { get; set; }
        public string GivenBy { get; set; }
    }
}
