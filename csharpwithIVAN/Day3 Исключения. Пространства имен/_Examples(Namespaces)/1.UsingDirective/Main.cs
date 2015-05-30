

using SecondNameSpace;  // дл€ использовани€ класса Second 
                        // подключаем пространство имен

using FourthNameSpace.bNameSpace; // дл€ использовани€ класса FourthB 
                                  // подключаем пространство имен FourthNameSpace
                                 // и указываем вложенное пространство имен bNameSpace

namespace MainNameSpace
{
    public class ClassM
    {
        public static void Main()
        {
            // “ак как не подключено пространство имен,
            // то необходимо писать полный путь
            FirstNameSpace.First objA = new FirstNameSpace.First();
            objA.Print();
            
            // ƒл€ класса Second полное им€ (SecondNameSpace.Second) 
            // писать не нужно т.к. подключено пространство имен SecondNameSpace
            // с ипользование using
            Second objB = new Second();
            objB.Print();

            // ƒл€ класса Third указывать и подключать пространство имен не нужно 
            // класс Third находитс€ в пространстве имен MainNameSpace
            Third objC = new Third();
            objC.Print();

            // ƒл€ использовани€ класс FourthA указываем полный путь к классу
            // FourthNameSpace.aNameSpace, где aNameSpace вложенное пространстов имен
            FourthNameSpace.aNameSpace.FourthA objD1 = new FourthNameSpace.aNameSpace.FourthA();
            objD1.Print();

            // ƒл€ класса FourthB подключено пространство имен 
            // FourthNameSpace.aNameSpace (в том числе и вложенное)
            FourthB objD2 = new FourthB();
            objD2.Print();

           
            // «десь нужно указать полное им€  System.Console
            // так как не подключено пространство имен System
            System.Console.ReadKey();

            
        }
    }
}


