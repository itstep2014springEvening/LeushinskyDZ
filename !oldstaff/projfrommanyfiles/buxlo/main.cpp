#include <iostream>

using namespace std;

int main()
{
	setlocale(0, "");
	cout << "����� ���������, ������� ����� �� �������� �� �����" << endl;
	cout << "������� ���� ���: ";
	int l;
	cin >> l;
	cout << "\n ������� � ���� �����������? ";
    int b;
	cin >> b;
	const int s = 0;
	int c;
	c = (l - s)*b*365;
	cout<<"\n �� �������� ��������: "<<c<<endl;
	return 0;
}
