using System.ComponentModel.DataAnnotations;

namespace Lisa.Civilization.ViewModels
{
    public class JoinLessonViewModel
    {
        [Required]
        [Display(Name = "Gebruikersnaam")]
        public string UserName
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "Les")]
        [CustomValidation(typeof(JoinLessonViewModel),  "LessonExists")]
        public string LessonId
        {
            get;
            set;
        }
    }
}