using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr_2.Models
{
    internal class ExamNumberGenerationHandler : IExamHandler
    {
        //остання ланка. генерація білету.
        public void SetNextHandler(IExamHandler handler)
        {
        }

        public void HandleRequest(Student student)
        {
            Random random = new Random();
            student.ExamNumber = random.Next(1, 21);

            Console.WriteLine($"Exam number for student {student.LastName} generated: {student.ExamNumber}");
        }
    }
}
