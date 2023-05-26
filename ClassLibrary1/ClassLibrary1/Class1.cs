using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public interface IPhone
    {
        string Model { get; set; } // Свойство модели телефона 
        bool IsOn { get; set; } // Свойство состояния включения/выключения телефона

        void Call(string phoneNumber); // Метод для совершения звонка
        void SendMessage(string phoneNumber, string message); // Метод для отправки сообщения
    }

    // Абстрактный класс "Мобильный телефон"
    public abstract class MobilePhone : IPhone
    {
        public string Model { get; set; } // Реализация свойства модели из интерфейса
        public bool IsOn { get; set; } = true; // Свойство состояния включения/выключения телефона

        public abstract void ConnectToInternet(); // Абстрактный метод для подключения к интернету

        public void Call(string phoneNumber)
        {
            if (IsOn)
            {
                Console.WriteLine("Calling " + phoneNumber + "...");
            }
            else
            {
                Console.WriteLine("Phone is turned off.");
            }
        }

        public void SendMessage(string phoneNumber, string message)
        {
            if (IsOn)
            {
                Console.WriteLine("Sending message to " + phoneNumber + ": " + message);
            }
            else
            {
                Console.WriteLine("Phone is turned off.");
            }
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Phone turned on.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Phone turned off.");
        }
    }

    // Класс SamsungPhone наследуется от абстрактного класса MobilePhone
    public class SamsungPhone : MobilePhone
    {
        public string UniqueFeature { get; set; } // Дополнительное свойство уникальной особенности

        public override void ConnectToInternet()
        {
            if (IsOn)
            {
                Console.WriteLine("Connected to the internet (Samsung).");
            }
            else
            {
                Console.WriteLine("Phone is turned off.");
            }
        }

        public void UseSPen()
        {
            if (IsOn)
            {
                Console.WriteLine("Using S Pen.");
            }
            else
            {
                Console.WriteLine("Phone is turned off.");
            }
        }
    }

    // Класс SonyPhone наследуется от абстрактного класса MobilePhone
    public class SonyPhone : MobilePhone
    {
        public bool IsWaterproof { get; set; } // Дополнительное свойство - защита от воды

        public override void ConnectToInternet()
        {
            if (IsOn)
            {
                Console.WriteLine("Connected to the internet (Sony).");
            }
            else
            {
                Console.WriteLine("Phone is turned off.");
            }
        }

        public void PlayMusic()
        {
            if (IsOn)
            {
                Console.WriteLine("Playing music.");
            }
            else
            {
                Console.WriteLine("Phone is turned off.");
            }
        }
    }

    // Класс ApplePhone наследуется от абстрактного класса MobilePhone
    public class ApplePhone : MobilePhone
    {
        public bool FaceID { get; set; } // Дополнительное свойство - идентификация лица

        public override void ConnectToInternet()
        {
            if (IsOn)
            {
                Console.WriteLine("Connected to the internet (Apple).");
            }
            else
            {
                Console.WriteLine("Phone is turned off.");
            }
        }

        public void UseFaceID()
        {
            if (IsOn && FaceID)
            {
                Console.WriteLine("Using Face ID.");
            }
            else
            {
                Console.WriteLine("Phone is turned off.");
            }
        }
    }

}
