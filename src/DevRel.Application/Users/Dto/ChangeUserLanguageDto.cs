using System.ComponentModel.DataAnnotations;

namespace DevRel.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}