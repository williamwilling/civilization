using System;

namespace Lisa.Civilization.Models
{
    public class IdGenerator
    {
        public string CreateId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}