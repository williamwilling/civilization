using Lisa.Civilization.Models;
using Microsoft.AspNet.SignalR;

namespace Lisa.Civilization.Hubs
{
    public class LessonHub : Hub
    {
        public void UpdateQuestion(string lessonId, string question)
        {
            var lesson = db.Lessons.Find(lessonId);
            lesson.Question = question;
            db.SaveChanges();
        }

        private CivilizationDb db = new CivilizationDb();
    }
}