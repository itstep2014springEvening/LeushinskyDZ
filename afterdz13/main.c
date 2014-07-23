#include <stdio.h>
#include <stdlib.h>
void infinity(int n);
int main()
{
    int choice;
    printf("1-cycle\n2-function\n?");
    scanf("%d", &choice);
    switch(choice)
    {
    case 1:
        while(1) {}
        break;
    case 2:
        infinity(0);
        break;
    }
    return 0;
}
 void infinity(int n)
 {
     //int mas[10];
     printf("%d\n", n);
     infinity(n+1);
 }
