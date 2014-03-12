using System.Data.Entity;

namespace Lisa.Civilization.Models
{
    public class CivilizationDb : DbContext
    {
        public virtual DbSet<Lesson> Lessons
        {
            get;
            set;
        }
    }
}