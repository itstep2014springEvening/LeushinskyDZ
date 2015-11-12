#include <iostream>

using namespace std;

int main()
{
	setlocale(0, "");
	cout << "Давай посчитаем, сколько бабла ты пробухал за жизнь" << endl;
	cout << "Сколько тебе лет: ";
	int l;
	cin >> l;
	cout << "\n Сколько в день пробухиваем? ";
    int b;
	cin >> b;
	const int s = 0;
	int c;
	c = (l - s)*b*365;
	cout<<"\n Ты пробухал примерно: "<<c<<endl;
	return 0;
}
