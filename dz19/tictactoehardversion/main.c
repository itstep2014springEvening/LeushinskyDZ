#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Hello user! Let's go.");
    int i=4, x=4, y=4;
    int field[4][4][4]= {0};
    outputField (field, i, x, y);
    return 0;
}

int inputField (int field[][4][4], int who)
{
    int f=1, l=1, c=1, command;
    if (who%2==0)
    {
        printf ("First player, enter coordinates!\n");
        command=1;
    }
    else
    {
        printf ("Second player, enter coordinates!\n");
        command=2;
    }
    do
    {
        printf ("Number of field (1-4): ");
        scanf ("%d", &f);
    }
    while (f<1 || f>4);
    do
    {
        printf ("Number of line (1-4): ");
        scanf ("%d", &l);
    }
    while (l<1 || l>4);
    do
    {
        printf ("Number of column (1-4): ");
        scanf ("%d", &c);
    }
    while (c<1 || c>4);
    if (field[f-1][l-1][c-1]!=0)
        inputField (field, who);
    field[f-1][l-1][c-1]=command;
    return command;
}

int check (int field[][4][4])
{
    int result=0, f=0, l=0, c=0;
    if (field[f][l][c]==field[f+1][l+1][c+1] && field[f][l][c]==field[f+2][l+2][c+2] && field[f][l][c]==field[f+3][l+3][c+3] && field[f][l][c]!=0)
        return field[f][l][c];
    if (field[f][l+3][c+3]==field[f+1][l+2][c+2] && field[f][l+3][c+3]==field[f+2][l+1][c+1] && field[f][l+3][c+3]==field[f+3][l][c] && field[f][l+3][c+3]!=0)
        return field[f][l+3][c+3];
    if (field[f][l][c+3]==field[f+1][l+1][c+2] && field[f][l][c+3]==field[f+2][l+2][c+1] && field[f][l][c+3]==field[f+3][l+3][c] && field[f][l][c+3]!=0)
        return field[f][l][c+3];
    if (field[f][l+3][c]==field[f+1][l+2][c+1] && field[f][l+3][c]==field[f+2][l+1][c+2] && field[f][l+3][c]==field[f+3][l][c+3] && field[f][l+3][c]!=0)
        return field[f][l+3][c];
    for (f=0; f<4; ++f)
    {
        if (field[f][l][c]==field[f][l+1][c+1] && field[f][l][c]==field[f][l+2][c+2] && field[f][l][c]==field[f][l+3][c+3] && field[f][l][c]!=0)
            return field[f][l][c];
        if (field[f][l][c+3]==field[f][l+1][c+2] && field[f][l][c+3]==field[f][l+2][c+1] && field[f][l][c+3]==field[f][l+3][c] && field[f][l][c+3]!=0)
            return field[f][l][c+3];
        for (l=0; l<4; ++l)
            for (c=0; c<4; ++c)
                if (field[f][l][c]==field[f+1][l][c] && field[f][l][c]==field[f+2][l][c] && field[f][l][c]==field[f+3][l][c] && field[f][l][c]!=0)
                    return field[f][l][c];
        for (l=0; l<4; ++l)
        {
            if (field[f][l][c]==field[f][l][c+1] && field[f][l][c]==field[f][l][c+2] && field[f][l][c]==field[f][l][c+3] && field[f][l][c]!=0)
                return field[f][l][c];
            if (field[f][l][c]==field[f+1][l][c+1] && field[f][l][c]==field[f+2][l][c+2] && field[f][l][c]==field[f+3][l][c+3] && field[f][l][c]!=0)
                return field[f][l][c];
            if (field[f][l][c+3]==field[f+1][l][c+2] && field[f][l][c+3]==field[f+2][l][c+1] && field[f][l][c+3]==field[f+3][l][c] && field[f][l][c+3]!=0)
                return field[f][l][c+3];
        }
        l=0;
        for (c=0; c<4; ++c)
        {
            if (field[f][l][c]==field[f][l+1][c] && field[f][l][c]==field[f][l+2][c] && field[f][l][c]==field[f][l+3][c] && field[f][l][c]!=0)
                return field[f][l][c];
            if (field[f][l][c]==field[f+1][l+1][c] && field[f][l][c]==field[f+2][l+2][c] && field[f][l][c]==field[f+3][l+3][c] && field[f][l][c]!=0)
                return field[f][l][c];
            if (field[f][l+3][c]==field[f+1][l+2][c] && field[f][l+3][c]==field[f+2][l+1][c] && field[f][l+3][c]==field[f+3][l][c] && field[f][l+3][c]!=0)
                return field[f][l+3][c];
        }
        c=0;
    }
    return result;
}

void outputField (int field[][4][4], int i, int x, int y)
{
    int result=0, who=2;
    do
    {
        for (int store=0; store<i; ++store)
        {
            for (int line=0; line<x; ++line)
            {
                printf ("#########\n");
                for (int column=0; column<y; ++column)
                {
                    if (column==0)
                        printf ("#");
                    switch (field[store][line][column])
                    {
                    case 1:
                        printf ("O#");
                        break;
                    case 2:
                        printf ("X#");
                        break;
                    default:
                        printf (" #");
                        break;
                    }
                }
                printf ("\n");
            }
            printf ("#########\n\n");
        }
        inputField (field, who);
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
