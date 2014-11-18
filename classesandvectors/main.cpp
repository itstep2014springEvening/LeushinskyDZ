#include <iostream>

using namespace std;

class Vector
{
public:
    Vector(double x, double y, double z);
    Vector();
    Vector input(Vector var);
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
    return 0;
}

Vector::Vector(double x, double y, double z)
{
    this->x=x;
    this->y=y;
    this->z=z;
}

Vector Vector::input(Vector var)
{
    cout << "Entering vector" << endl;
    cout << "Enter vector x coordinate: " << endl;
    cin >> var.x;
    cout << "Enter vector y coordinate: " << endl;
    cin >> var.y;
    cout << "Enter vector z coordinate: " << endl;
    cin >> var.z;
    return var;
}

