

namespace NLayer.Core.DTOs
{
    public class AppUserLanguageDto :BaseDto
    {
        public int LanguageID { get; set; }
        public int AppUserID { get; set; }
        public string GivenBy { get; set; }
    }
}
