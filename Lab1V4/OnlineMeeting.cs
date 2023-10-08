using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab1V4
{
    internal class OnlineMeeting
    {
        //Розробити клас підсистеми для завантаження даних про онлайн зустріч(дата, опис, URL, список учасників)
        public DateTime date;
        public string description;
        public string URl;
        public SystemUsersList systemUsersList;

        public override string ToString()
        {
            string result = $"Date: {date}, Description: {description}, URL: {URl}, List of users: {systemUsersList.ToString()}";
            return result;
        }

    }
}
