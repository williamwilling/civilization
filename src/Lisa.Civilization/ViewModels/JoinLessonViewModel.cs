using System.ComponentModel.DataAnnotations;
using Lisa.Civilization.Models;

namespace Lisa.Civilization.ViewModels
{
    public class JoinLessonViewModel
    {
        [Required]
        [Display]
        public string UserName
        {
            get;
            set;
        }

        [Required]
        [Display]
        [CustomValidation(typeof(JoinLessonViewModel),  "LessonExists")]
        public string LessonId
        {
            get;
            set;
        }

        public static ValidationResult LessonExists(string lessonId)
        {
            var db = new CivilizationDb();
            var lesson = db.Lessons.Find(lessonId);

            if (lesson == null)
            {
                return new ValidationResult("De les bestaat niet.");
            }

            return ValidationResult.Success;
        }
    }
}