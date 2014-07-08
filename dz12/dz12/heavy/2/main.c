#include <stdio.h>
#include <stdlib.h>

int main()
{
    int ivanSpeed, vladSpeed, distance, ivanFinished, vladFinished, counter1, ivanDistance, vladDistance;
    printf("Hello user!\n");
    printf("Please, enter Ivan's speed(m/s): ");
    scanf("%d", &ivanSpeed);
    printf("Please, enter Vlad's speed(m/s): ");
    scanf("%d", &vladSpeed);
    printf("Please, enter distance(m): ");
    scanf("%d", &distance);
    ivanDistance==distance;
    vladDistance==distance;
    for(counter1=0; counter1<distance; ++counter1)
    {
        ivanFinished=ivanDistance/ivanSpeed;
        vladFinished=vladDistance/vladSpeed;
        ivanDistance=ivanFinished;
        vladDistance=vladFinished;
    }
    if(ivanFinished==vladFinished)
    {
        printf("Friendship WINS!");
    }
    else
    {
        ivanFinished>vladFinished?printf("Ivan FIRST!=%d", ivanFinished):printf("Vlad FIRST!=%d", vladFinished);
    }
    return 0;
}
