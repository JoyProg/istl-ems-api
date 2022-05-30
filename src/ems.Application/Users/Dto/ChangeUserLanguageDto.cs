using System.ComponentModel.DataAnnotations;

namespace ems.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}