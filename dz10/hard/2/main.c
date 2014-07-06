#include <stdio.h>
#include <stdlib.h>

int main()
{
    int enteringNumber, Sum, counter1, howManyNumbers;
    printf("Hello user, how many numbers do you want to enter?\n");
    scanf("%d", &howManyNumbers);
    for(counter1=0; counter1<howManyNumbers; ++counter1)
    {
        printf("Please, enter %d number: ", counter1+1);
        scanf("%d", &enteringNumber);
        Sum=Sum+enteringNumber;
    }
    if(Sum>100)
    {
        printf("Your sum>100");
    }
    else
    {
        printf("Your sum<100");
    }
    return 0;
}
