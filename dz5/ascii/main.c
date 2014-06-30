#include <stdio.h>
#include <stdlib.h>

int main()
{
    char a = 1;
    int nraw = 10;
    printf("Hello user, this is an 128 symbols ASCII table!\n");
    for (int n=0; n<=129; n++)
    {
        if (a==nraw)
        {
            printf("%c \n");
            nraw+=10;
        }
        printf(" %c ", a);
        a++;
    }
    return 0;
}
