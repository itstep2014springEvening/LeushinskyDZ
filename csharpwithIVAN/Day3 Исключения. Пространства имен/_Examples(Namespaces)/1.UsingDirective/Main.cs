

using SecondNameSpace;  // ��� ������������� ������ Second 
                        // ���������� ������������ ����

using FourthNameSpace.bNameSpace; // ��� ������������� ������ FourthB 
                                  // ���������� ������������ ���� FourthNameSpace
                                 // � ��������� ��������� ������������ ���� bNameSpace

namespace MainNameSpace
{
    public class ClassM
    {
        public static void Main()
        {
            // ��� ��� �� ���������� ������������ ����,
            // �� ���������� ������ ������ ����
            FirstNameSpace.First objA = new FirstNameSpace.First();
            objA.Print();
            
            // ��� ������ Second ������ ��� (SecondNameSpace.Second) 
            // ������ �� ����� �.�. ���������� ������������ ���� SecondNameSpace
            // � ������������ using
            Second objB = new Second();
            objB.Print();

            // ��� ������ Third ��������� � ���������� ������������ ���� �� ����� 
            // ����� Third ��������� � ������������ ���� MainNameSpace
            Third objC = new Third();
            objC.Print();

            // ��� ������������� ����� FourthA ��������� ������ ���� � ������
            // FourthNameSpace.aNameSpace, ��� aNameSpace ��������� ������������ ����
            FourthNameSpace.aNameSpace.FourthA objD1 = new FourthNameSpace.aNameSpace.FourthA();
            objD1.Print();

            // ��� ������ FourthB ���������� ������������ ���� 
            // FourthNameSpace.aNameSpace (� ��� ����� � ���������)
            FourthB objD2 = new FourthB();
            objD2.Print();

           
            // ����� ����� ������� ������ ���  System.Console
            // ��� ��� �� ���������� ������������ ���� System
            System.Console.ReadKey();

            
        }
    }
}


