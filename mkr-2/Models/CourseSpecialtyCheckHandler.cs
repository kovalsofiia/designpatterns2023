using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr_2.Models
{
    internal class CourseSpecialtyCheckHandler : IExamHandler
    {
        //перша ланка у ланцюгу: перевірка чи 124 і чи 2 курс. Якщо ні -> відмова у доступі. 
        private IExamHandler _nextHandler;

        public void SetNextHandler(IExamHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleRequest(Student student)
        {
            if (student.Course == 2 && student.Specialty == 124)
            {
                Console.WriteLine($"Course and specialty for student  {student.LastName} check passed.");
                _nextHandler?.HandleRequest(student);
            }
            else
            {
                Console.WriteLine($"Access for student {student.LastName} denied. Invalid course or specialty.");
            }
        }
    }
}
