namespace Lisa.Civilization.Models
{
    public class Lesson
    {
        public Lesson()
        {
            var generator = new IdGenerator();
            Id = generator.CreateId();
        }

        public string Id
        {
            get;
            set;
        }

        public string Question
        {
            get;
            set;
        }
    }
}