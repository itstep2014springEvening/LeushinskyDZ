#include <stdio.h>
#include <stdlib.h>
typedef struct _Fraction
{
    int numerator;
    int denominator;
} Fraction;

Fraction input();
//Fraction output(int var1ForFr1, int var2ForFr1, char slash);
Fraction multiply(Fraction fractionA, Fraction fractionB);

int main()
{
    Fraction fractionA, fractionB;
    fractionA = input();
    fractionB = input();
    multiply(fractionA, fractionB);
    return 0;
}

Fraction input()
{
    Fraction fraction;
    int var1ForFr1, var2ForFr1;
    scanf("%d", &var1ForFr1);
    fraction.numerator=var1ForFr1;
    scanf("%d", &var2ForFr1);
    fraction.denominator=var2ForFr1;
    return fraction;
}

Fraction multiply(Fraction fractionA, Fraction fractionB)
{
    Fraction result;
    result.numerator=fractionA.numerator*fractionB.numerator;
    result.denominator=fractionA.denominator*fractionB.denominator;
    printf("%d/%d",result.numerator,result.denominator);
    return result;
}




