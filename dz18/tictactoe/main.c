#include <stdio.h>
#include <stdlib.h>
void fieldOutput (int ourMatrix[][5], int m, int n);
int main()
{
    printf("!TIC TAC TOE!\n");
    printf("Choose your position: ");
    scanf()
    int m=5,n=5,pointer=1;
    int ourMatrix [m][n];
    //fieldOutput(ourMatrix,m,n);
    fieldOutput(ourMatrix,m,n);
    printf("%d", pointer);

    return 0;
}

void fieldOutput (int ourMatrix[][5], int m, int n)
{
    for(int i=0; i<m; ++i)
    {
        for(int j=0; j<n; ++j)
        {
            if(i==1 || i==3 || j==1 || j==3)
                printf("#");
            else
            {
                printf(" ");
            }
        }
        printf("\n");
    }
}
