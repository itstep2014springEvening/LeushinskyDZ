#include <stdio.h>
#include <stdlib.h>

int check (int field[][3])
{
    int result=0, j=0, i=0, check;
    for (i=0; i<3; ++i)
    {
        if (field[i][j]==field[i][j+1] && field[i][j+2]==field[i][j+1] && field[i][j]!=0)
            result=field[i][j];
    }
    i=0;
    for (j=0; j<3; ++j)
    {
        if (field[i][j]==field[i+1][j] && field[i+2][j]==field[i+1][j] && field[i][j]!=0)
            result=field[i][j];
    }
    j=0, i=0;
    if (field[i][j]==field[i+1][j+1] && field[i+2][j+2]==field[i+1][j+1] && field[i][j]!=0)
        result=field[i][j];
    j=0, i=0;
    if (field[i][j+2]==field[i+1][j+1] && field[i+2][j]==field[i][j+2] && field[i][j+2]!=0)
        result=field[i][j+2];
    return result;
}

void inputField (int field[][3], int x, int y)
{
    int m=3, n=3, result=0, who=2;
    do
    {
        for (int a=0; a<x; ++a)
        {
            printf ("#######\n");
            for (int b=0; b<y; ++b)
            {
                if (b==0)
                    printf ("#");
                if (field[a][b]==1)
                    printf ("O#");
                if (field[a][b]==2)
                    printf ("X#");
                if (field[a][b]==0)
                    printf (" #");
            }
            printf ("\n");
        }
        printf ("#######\n");
        int i=1, j=1, command;
        if (who%2==0)
        {
            printf ("First player, enter coordinates:\n");
            command=1;
        }
        else
        {
            printf ("Second player, enter coordinates:\n");
            command=2;
        }
        do
        {
            scanf ("%d", &i);
            scanf ("%d", &j);
        }
        while (j>3 || j<1 || i>3 || i<1);
        field[i-1][j-1]=command;
        system ("cls");
        ++who;
        result=check(field);
    }
    while (result==0);
    if (result==1)
        printf ("The first player is winner!");
    else
        printf ("The second player is winner!");
}

int main()
{
    int x=3, y=3;
    int field[3][3]= {0};
    printf ("Let's play!\n");
    inputField (field, x, y);
    return 0;
}
