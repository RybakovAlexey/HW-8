using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace task_4
{
    internal class Program4
    {
        static void Main(string[] args)
        {

            
            XDocument xdoc = new XDocument();

            // создаем элемент employee
            XElement employee = new XElement("Person");
            Console.WriteLine("Введите ФИО сотрудника");
            // создаем атрибут name
            XAttribute nameAttr = new XAttribute("name", Console.ReadLine());

            XElement employeeAdress = new XElement("Adress");
            Console.WriteLine("Введите улицу");
            // создаем элементы для адреса
            XElement street = new XElement("Street", Console.ReadLine());
            Console.WriteLine("Введите номер дома");
            XElement house = new XElement("HouseNamber", Console.ReadLine());
            Console.WriteLine("Введите номер квартиры");
            XElement flat = new XElement("FlatNumber", Console.ReadLine());
            //запихиваем в адресс улицу,дом,квартиру
            employeeAdress.Add(street);
            employeeAdress.Add(house);
            employeeAdress.Add(flat);

            XElement employeePhones = new XElement("Phones");
            Console.WriteLine("Введите номер мобильного");
            XElement mobilePhone = new XElement("MobilePhone", Console.ReadLine());
            Console.WriteLine("Введите номер домашнего телефона");
            XElement flatPhone = new XElement("FlatPhone", Console.ReadLine());
            employeePhones.Add(mobilePhone);
            employeePhones.Add(flatPhone);

            // добавляем атрибут и элементы в первый элемент employee
            employee.Add(nameAttr);
            employee.Add(employeeAdress);
            employee.Add(employeePhones);


            // добавляем корневой элемент в документ
            xdoc.Add(employee);
            //сохраняем документ
            xdoc.Save("people.xml");

            Console.WriteLine("Data saved");
            Console.Read();
        }
    }
}
