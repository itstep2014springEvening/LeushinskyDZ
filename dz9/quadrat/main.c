#include <stdio.h>
#include <stdlib.h>

int main()
{
    int width, height, heightCounter, counter, square;
    printf("Hello user!\n");
    printf("Please, enter width: ");
    scanf("%d", &height);
    printf("Please, enter height: ");
    scanf("%d", &width);
    square=width*height;
    heightCounter=height;
    for(counter=1; counter<=square; ++counter)
    {
        printf("*");
        if(counter==heightCounter)
        {
            printf("\n");
            heightCounter=heightCounter+height;
        }
    }
    return 0;
}
