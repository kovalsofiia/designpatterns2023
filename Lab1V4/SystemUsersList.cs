using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1V4
{
    internal class SystemUsersList
    {
        //списку всіх користувачів системи(ID, Ім'я, аватар) з файлів в форматі JSON та XML.
        public string ID;
        public string Name;
        public string Avatar;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
