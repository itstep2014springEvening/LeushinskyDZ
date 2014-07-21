#include <stdio.h>
#include <stdlib.h>

int main()
{
    int numberOfFlies, exorcismSpeed, fatigueTime, flyReturnSpeed, exorcismTime;
    printf("Enter exorcism time: ");
    scanf("%d", &exorcismTime);
    printf("Enter number of flies: ");
    scanf("%d", &numberOfFlies);
    printf("Enter exorcism speed: ");
    scanf("%d", &exorcismSpeed);
    printf("Enter fatigue time: ");
    scanf("%d", &fatigueTime);
    printf("Enter fly return speed: ");
    scanf("%d", &flyReturnSpeed);
    for(int counter1=0;counter1<=exorcismTime;++counter1)
    {
        numberOfFlies=(numberOfFlies-exorcismSpeed)+flyReturnSpeed;
        if(counter1==fatigueTime)
        {
            exorcismSpeed*=0.2;
        }
    }
    numberOfFlies<=0?printf("You win! All flies gone."):printf("You lose! Flies beat you.");

    return 0;
}
