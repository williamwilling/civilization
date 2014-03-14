using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lisa.Civilization.ViewModels;
using Lisa.Civilization.Models;

namespace Lisa.Civilization.Controllers
{
    public class LessonController : Controller
    {
        public ActionResult Create()
        {
            var lesson = new Lesson();
            db.Lessons.Add(lesson);
            db.SaveChanges();

            return RedirectToAction("Cast", new { id = lesson.Id });
        }

        public ActionResult Cast(string id)
        {
            var lesson = db.Lessons.Find(id);
            return View(lesson);
        }

        public ActionResult Join()
        {
            return View(new JoinLessonViewModel());
        }

        [HttpPost]
        public ActionResult Join(JoinLessonViewModel form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            return RedirectToAction("Follow", new { lessonId = form.LessonId });
        }

        public ActionResult Follow(string id)
        {
            var lesson = db.Lessons.Find(id);
            return View(lesson);
        }

        private CivilizationDb db = new CivilizationDb();
    }
}