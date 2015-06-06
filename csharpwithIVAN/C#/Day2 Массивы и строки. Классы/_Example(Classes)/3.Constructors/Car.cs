using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructors
{
    class Car
    {
        private string driverName;		// Имя водителя
        private int currSpeed;			// Текущая скорость

        // Конструктор без параметров
        public Car() : this("Нет водителя")
        {
        }
        // Конструктор с одним параметром
        public Car(string driverName) : this(driverName, 0) 
        { 
        }
        // Конструктор с параметрами
        public Car(string driverName, int speed) 
        {
            this.driverName = driverName;
            currSpeed = speed;
        }
       
        public void PrintState()		// Вывод текущих данных
        {
            Console.WriteLine("{0} едет со скоростью {1} км/ч.", driverName, currSpeed);
        }
        public void SpeedUp(int delta)	// Увеличение скорости
        {
            currSpeed += delta;
        }



    }

}
