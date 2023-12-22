using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr_2.Models
{
    internal class StudentVerificationHandler : IExamHandler
    {
        //друга ланка у ланцюгу: перевірка чи допущений студент до здачі. Якщо так -> то відбувається передача наступній ланці. Якщо ні -> відмова.
        private IExamHandler _nextHandler;

        public void SetNextHandler(IExamHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleRequest(Student student)
        {
            if (AllowedStudents.Contains(student.LastName, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Student {student.LastName} verification passed.");
                _nextHandler?.HandleRequest(student);
            }
            else
            {
                Console.WriteLine($"Access denied. Student {student.LastName} not allowed.");
            }
        }

        private static readonly string[] AllowedStudents = { "Andrusyk", "Koval", "Novikova", "Fitas", "Vohar", "Balko", "Romochivska" };
    }
}
