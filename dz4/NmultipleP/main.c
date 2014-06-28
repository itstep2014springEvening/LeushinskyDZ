#include <stdio.h>
#include <stdlib.h>

int main()
{
    int nNumbers, numberToMultiple, nMultipleOfNumbers=1, counter1;
    printf("Hello user!\n");
    printf("How much numbers do you want, to multiple?: ");
    scanf("%d", &nNumbers);
    for(counter1=0;counter1<+nNumbers;++counter1)
    {
        printf("Please enter %d number: ", counter1+1);
        scanf("%d", &numberToMultiple);
        nMultipleOfNumbers=nMultipleOfNumbers*numberToMultiple;
    }
    printf("Your result = %d", nMultipleOfNumbers);
    return 0;
}
