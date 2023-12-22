using mkr_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr_2
{
    internal class Program
    {
        //Я використала шаблон: ланцюг обовязків.
        static void Main(string[] args)
        {
            // визначено ланки-виконавці.
            var courseHandler = new CourseSpecialtyCheckHandler();
            var verificationHandler = new StudentVerificationHandler();
            var examNumberHandler = new ExamNumberGenerationHandler();

            //визначено послідовність обовязків.
            courseHandler.SetNextHandler(verificationHandler);
            verificationHandler.SetNextHandler(examNumberHandler);

            //запит користувача на імя та спеціальність та курс студента
            Console.Write("Students course: ");
            int course = Convert.ToInt32(Console.ReadLine());
            Console.Write("Students speciality: ");
            int speciality = Convert.ToInt32(Console.ReadLine());
            Console.Write("Students Lasname: ");
            string lastname = Console.ReadLine();
            var student = new Student {Course = course, Specialty = speciality, LastName = lastname};
            courseHandler.HandleRequest(student);

            Console.ReadLine();
        }
    }
}
