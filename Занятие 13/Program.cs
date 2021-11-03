using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_13
{
    class Program
    // наследование класса Building
    {
        static void Main(string[] args)
        {
            Building building = new Building(); //экземпляр класса Building
            Console.WriteLine("Задайте адрес: ");
            building.Address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Задайте длину здания : ");
            building.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Задайте ширину здания: ");
            building.Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Задайтe высоту здания: ");
            building.Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Задайте этажность");
            MultiBuilding multiBuilding = new MultiBuilding (building.Address, building.Length, building.Width, building.Height, Convert.ToByte(Console.ReadLine()));
            building.Print();
            multiBuilding.Print();

            Console.ReadKey();
        }
    }
    class Building
    {
        //Описание класса
        string address;
        double length;
        double width;
        double height;

        public void building(string address, double length, double width, double height) // конструктор с 4 параметрами
        {
            this.address = address;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public double Length
        {
            set
            {
                if (value > 0) //длина может быть только положительной
                {
                    this.length = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение длины");
                }
            }
            get
            {
                return length;
            }
        }
        public double Width
        {
            set
            {
                if (value > 0) // ширина может быть только положительной
                {
                    this.width = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение ширины");
                }
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {
                if (value > 0) // высота может быть только положительной
                {
                    this.height = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение высоты");
                }
            }
            get
            {
                return height;
            }
        }
        public void Print()
        {
            Console.WriteLine("Информация о здании по адресу {0}, длина {1}, ширина {2}, высота {3}", address, length, width, height);
        }
    }
    sealed class MultiBuilding : Building // дочерний класс

    {
        byte floor;
        public MultiBuilding(string address, double length, double width, double height, byte floor)
        {
            this.floor = floor;
            base.Address = address;
            base.Length = length;
            base.Width = width;
            base.Height = height;

        }
        public byte Floor
        {
            set
            {
                if (value > 0) // высота может быть только положительной
                {
                    this.floor = value;
                }
                else
                {
                    Console.WriteLine("Некорректное значение этажности");
                }
            }
            get
            {
                return floor;
            }
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Информация о здании по адресу {0}, длина {1}, ширина {2}, высота {3}, этажность здания {4}", Address, Length, Width, Height, floor);
            Console.ReadKey();
        }
    }
}



      





