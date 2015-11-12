#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a,b;
    printf("Hello user, please enter 2 numbers.\n");
    scanf("%d",&a);
    scanf("%d",&b);
    a>b?printf("%d>%d",a,b):printf("%d>%d",b,a);
    getchar();
    return 0;
}
