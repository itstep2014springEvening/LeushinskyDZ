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
    double dot(Vector b, double sumOfCoordinates);
    Vector vect(Vector b);
private:
    double x;
    double y;
    double z;
};

int main()
{
    cout << "Hello world!" << endl;
    double sumOfCoordinates=0.0;
    Vector a(3.5,5,7);
    Vector b(8.7,2.1,3);
    cout << "a"; a.output();
    cout << "b"; b.output();
    cout << "Sum"; (a.sum(b)).output();
    cout << "Res"; (a.res(b)).output();
    cout << "Dot" << "{" <<a.dot(b, sumOfCoordinates)<< "}" <<endl;
    cout << "Vect"; (a.vect(b)).output();
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

Vector Vector::sum(Vector b)
{
    Vector result(0,0,0);
    result.x=this->x+b.x;
    result.y=this->y+b.y;
    result.z=this->z+b.z;
    return result;
}

Vector Vector::res(Vector b)
{
    Vector result(0,0,0);
    result.x=this->x-b.x;
    result.y=this->y-b.y;
    result.z=this->z-b.z;
    return result;
}

double Vector::dot(Vector b, double sumOfCoordinates)
{
    Vector result(0,0,0);
    result.x=this->x*b.x;
    result.y=this->y*b.y;
    result.z=this->z*b.z;
    sumOfCoordinates=result.x+result.y+result.z;
    return sumOfCoordinates;
}

Vector Vector::vect(Vector b)
{
    Vector result(0,0,0);
    result.x=this->y*b.z-this->z*b.y;
    result.y=this->z*b.x-this->x*b.z;
    result.z=this->x*b.y-this->y*b.x;
    return result;
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

