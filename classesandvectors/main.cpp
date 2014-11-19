#include <iostream>

using namespace std;

class Vector
{
public:
    Vector(double x, double y, double z);
    Vector();
    //Vector input(Vector variable);
    void output();
    Vector sum(Vector b);
    Vector res(Vector b);
    Vector dot(Vector b);
    Vector vect(Vector b);
private:
    double x;
    double y;
    double z;

};

int main()
{
    cout << "Hello world!" << endl;
    Vector a(3,5,7);
    Vector b(1,2,3);
    //Vector input();
    cout << "a"; a.output();
    cout << "b"; b.output();
    return 0;
}

Vector::Vector(double x, double y, double z)
{
    this->x=x;
    this->y=y;
    this->z=z;
}

void Vector::output()
{
    cout <<"{" << this->x << "," << this->y << "," << this->z << "}" << endl;
}

/*Vector Vector::input(Vector variable)
{
    cout << "Entering vector" << endl;
    cout << "Enter vector x coordinate: " << endl;
    cin >> variable.x;
    cout << "Enter vector y coordinate: " << endl;
    cin >> variable.y;
    cout << "Enter vector z coordinate: " << endl;
    cin >> variable.z;
    return variable;
}*/


