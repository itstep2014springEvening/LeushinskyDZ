#include <stdio.h>
#include <stdlib.h>

typedef struct _Mountain
{
    char mountainName [256];
    char mountainLocation [256];
    int mountainHeight;
    int mountainSlopeAngle;
    char mountainHasAGlacier [256];
} Mountain;

int main()
{
    printf("Hello, user. It's mountains DB. What do you want?\n\n");
    printf("1. Create new DB.\n");
    printf("2. Add a new record.\n");
    printf("3. Delete record.\n");
    printf("4. Sort fields.\n");
    printf("5. Exit.\n");
    return 0;
}
