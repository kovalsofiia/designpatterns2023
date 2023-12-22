using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr_2.Models
{
    internal interface IExamHandler
    {
        //базовий інтерфейс який містить методи передати запит наступному в ланцюгу обовязків та виконати запит(якщо виконується умова)
        void SetNextHandler(IExamHandler handler);
        void HandleRequest(Student student);
    }
}
