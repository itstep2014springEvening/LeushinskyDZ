#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
<<<<<<< HEAD
    double exponentour, exponentmath, x=1.0, counter1;
    printf("Hello user!\n");
    exponentmath=exp(x);
    for(counter1=-2.0;counter1<=2.0;counter1=+0.1)
        exponentour=exponentour;


    printf("x    exp(our)    exp(math)    exp(m-o)\n");
    printf("%d       %f            %f            %f", x, exponentour, exponentmath,exponentmath-exponentour);
=======
    double x, exponent=1.0, factorial=1.0, epsilon=0.001;
    printf("Hello user!\n");
    for(x=-2.0;x<2.0;x=x+0.1)
    {
        while(exponent>epsilon)
        {
            exponent=exponent pow(factorial)+x/factorial;
            factorial++;
        }
       printf("%d\n", x);

    }
>>>>>>> d6d1545fbf43b3f7a39086a5b7938c99a4318a14
    return 0;
}
