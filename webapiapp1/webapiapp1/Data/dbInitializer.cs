using System.Collections.Generic;
using webapiapp1.Models;

namespace webapiapp1.Data
{
    public class dbInitializer
    {
        public static void Initialize()
        {
            IList<Student> stud = new[]
            {   new Student() { Id = 1, FirstName = "Bbbb",LastName = "CCCC"},
                new Student() { Id = 2, FirstName = "Ssss",LastName = "Dddd"},
                new Student() { Id = 3, FirstName = "Rrrr",LastName = "VVVV"},
                new Student() { Id = 4, FirstName = "LLLl",LastName = "Mmmm"}
             };

        }
    }
}
