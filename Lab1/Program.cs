using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        //        Прочитати вимоги.
        //        Вказати породжуючий шаблон, який доцільно використати для розв'язування задачі.
        //        Розробити програмний прототип, який імітує діяльність відповідної системи, наприклад, замість надсилання SMS повідомлення вивести текст повідомлення в консоль.
        //        Провести демонстрацію роботи системи


        //Варіант 1. Розробити підсистему для створення класу підключення до інтернету.
        //Кожен об'єкт при створенні повинен мати такі можливості: 
        //1) Вказати протокол передачі даних: HTTP, HTTPS, FTP,  SSH, тощо, якщо не вказано.то за замовчування використати HTTP,.
        //2) Можливість вказати шифрування TLS, SSL, тощо. Якщо не вказано то не використовувати шифрування.
        //3) Можливість вибрати версію IP адреси v4 чи v6.За замовчуванням використати v4.
        //4) Додати необмежену кількість інших властивосте в форматі ключ: значення.
        //Клас повинен містити метод "Підключитись", при виклику якого в консоль виводить повідомлення з усіма параметрами з'єднання. Створити кілька з'єднань з різними конфігураціями.

        //Я використала породжуючий шаблон Білдер. Він дає мені змогу розділити об*єкт на дрібніші частини. 
        // Таким чином усередині класу Підключення до інтернету я створила клас білдер який містить функції, за допомогою яких відбувається присвоєння значень і створення за допомогою конструктора об*єкту типу цього класу.

        
        //опис класу із назвою: Підключення до інтернету
        /// <summary>
        /// Підключення до інтернету
        /// </summary>
        public class ConectionToTheInternet
        {
            //поля класу
            public string Protocol {  get; set; }
            public string Encryption { get; set; }
            public string VersionOfAnIP { get; set; }
            public Dictionary<string, string> AdditionalProperties { get; set; }

            /// <summary>
            /// Конструктор класу: Підключення до Інтернету
            /// </summary>
            /// <param name="userProtocol">Вказати протокол передачі даних: HTTP, HTTPS, FTP,  SSH, тощо</param>
            /// <param name="userEncryption">Можливість вказати шифрування TLS, SSL, тощо.</param>
            /// <param name="userVersionOfAnIP">Можливість вибрати версію IP адреси v4 чи v6.</param>
            /// <param name="userAdditionalProperties"> Додати необмежену кількість інших властивосте в форматі ключ: значення.</param>
            private ConectionToTheInternet(string userProtocol, string userEncryption, string userVersionOfAnIP, Dictionary<string, string> userAdditionalProperties)
            {
                Protocol = userProtocol;
                Encryption = userEncryption;
                VersionOfAnIP = userVersionOfAnIP;
                AdditionalProperties = userAdditionalProperties;
            }

            //опис класу типу Білдер для створення об*єктів
            public class Builder
            {
                //поля класу білдер
                private string builderProtocol = "HTTP";
                private string builderEncryption = null;
                private string builderVersionOfAnIP = "v4";
                private readonly Dictionary<string, string> builderAdditionalProperties = new Dictionary<string, string>();

                //методи
                public Builder SetProtocol(string protocol)
                {
                    this.builderProtocol = protocol;
                    return this;
                }

                public Builder SetEncryption(string encryption)
                {
                    this.builderEncryption = encryption;
                    return this;
                }

                public Builder SetVersionOfAnIP(string versionOfAnIP)
                {
                    this.builderVersionOfAnIP = versionOfAnIP;
                    return this;
                }

                public Builder AddAdditionalProperty(string key, string value)
                {
                    this.builderAdditionalProperties[key] = value;
                    return this;
                }

                public ConectionToTheInternet Build()
                {
                    return new ConectionToTheInternet(builderProtocol, builderEncryption, builderVersionOfAnIP, builderAdditionalProperties);
                }
            }

            //метод Підключитись
            public void ConnectTo()
            {
                Console.WriteLine("???Trying to connect you to the Internet???");
                Console.WriteLine($"Protocol: {Protocol}");
                if (!string.IsNullOrEmpty(Encryption))
                {
                    Console.WriteLine($"Encryption method: {Encryption}");
                }
                Console.WriteLine($"IP v: {VersionOfAnIP}");
                Console.Write("Additional properties are ");
                foreach (var item in AdditionalProperties)
                {
                    Console.WriteLine($"[{item.Key}: {item.Value}],");
                }
                Console.WriteLine("!!!Congratulations you have been connected!!!");
                Console.WriteLine("=======================================================");
            }
        }


        static void Main(string[] args)
        {
            var connectBuilder = new ConectionToTheInternet.Builder();

            var firstConnection = connectBuilder
                .SetProtocol("FTP")
                .SetEncryption("TLS")
                .SetVersionOfAnIP("v6")
                .AddAdditionalProperty("delayed", "1 minute")
                .Build();

            var connectBuilder2 = new ConectionToTheInternet.Builder();
            var secondConnection = connectBuilder2
                .AddAdditionalProperty("user", "username")
                .Build();


            firstConnection.ConnectTo();
            Console.WriteLine();
            secondConnection.ConnectTo();
        }
    }
}
