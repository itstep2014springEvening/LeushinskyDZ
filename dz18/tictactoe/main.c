#include <stdio.h>
#include <stdlib.h>
void output (int ourMatrix[][3], int m, int n);
int main()
{
    int m=5,n=5;
    int ourMatrix [m][n];
    output(ourMatrix,m,n);

    return 0;
}

void output (int ourMatrix[][3], int m, int n)
{
    for(int i=0; i<m; ++i)
    {
    for(int j=0;j<n;++j)
        {
            (i%2!=0 || j%2!=0)?printf("#"):printf(" ");
        }
        printf("\n");
    }
}

void yourTurn (int ourMatrix[][3], int m, int n)
{
    printf("Your turn, player.\n");
    printf("Enter your position:\n");


}
