#include <stdio.h>
#include <stdlib.h>

int main()
{
    int rhombusSize, a, counter1, counter2;
    printf("Hello user, it's rhombus time!\n");
    printf("Be careful, rhombus work's only with odd numbers!\n");
    printf("Please, enter rhombus size: ");
    scanf("%d",&rhombusSize);
    if(rhombusSize%2==0)
    {
        printf("Sorry, it's not odd number.\nTry again later.");
    }
    else
    {
        rhombusSize=rhombusSize/2;
        for(counter1=0; counter1<=rhombusSize*2; counter1++)
        {
            for(counter2=0; counter2<=rhombusSize*2; counter2++)
            {
                printf("%c",abs( counter1 - rhombusSize ) + abs( counter2 - rhombusSize ) <= rhombusSize ? '#' : ' ' );
            }
            printf("\n");
        }
    }
    return 0;
}
