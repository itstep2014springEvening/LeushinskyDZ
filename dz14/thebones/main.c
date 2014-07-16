#include <stdio.h>
#include <stdlib.h>

int main()
{
    int humanTurn1, humanTurn2, PCTurn1, PCTurn2, humanWin=0, PCWin=0;
    for(int turnNumber=1; turnNumber<=5; ++turnNumber)
    {
        int likeABoolean=1;
        srand(time(NULL));
        humanTurn1=rand()%5+2;
        PCTurn1=rand()%5+2;
        humanTurn2=rand()%6+1;
        PCTurn2=rand()%6+1;
        printf("YOUR BONES=%d\n", humanTurn1+humanTurn2);
        throw(humanTurn1);
        throw(humanTurn2);
        printf("COMPUTER BONES=%d\n", PCTurn1+PCTurn2);
        throw(PCTurn1);
        throw(PCTurn2);
        humanTurn1+humanTurn2>PCTurn1+PCTurn2?likeABoolean--:likeABoolean++;
        switch(likeABoolean)
        {
        case 0:
            printf("YOU WIN THIS ROUND\n");
            ++humanWin;
            break;
        case 2:
            printf("PC WIN THIS ROUND\n");
            ++PCWin;
            break;
        default:
            printf("DRAW!\n");
            break;
        }
        if(turnNumber<5)
        {
            printf("Ready to next turn?");
            getchar();
            system("cls");
        }
        else
        {
            if(humanWin==PCWin)
            {
                printf("DRAW!");
                return 0;
            }
            humanWin>PCWin?printf("\nYOU WIN!"):printf("\nPC WIN!");
            return 0;
        }
    }
}

int throw(int turn)
{
    switch(turn)
    {
    case 1:
        printf(" -----\n"
               "|     |\n"
               "|  *  |\n"
               "|     |\n"
               " -----\n");
        break;
    case 2:
        printf(" -----\n"
               "|*    |\n"
               "|     |\n"
               "|    *|\n"
               " -----\n");
        break;
    case 3:
        printf(" -----\n"
               "|*    |\n"
               "|  *  |\n"
               "|    *|\n"
               " -----\n");
        break;
    case 4:
        printf(" -----\n"
               "|*   *|\n"
               "|     |\n"
               "|*   *|\n"
               " -----\n");
        break;
    case 5:
        printf(" -----\n"
               "|*   *|\n"
               "|  *  |\n"
               "|*   *|\n"
               " -----\n");
        break;
    case 6:
        printf(" -----\n"
               "|*   *|\n"
               "|*   *|\n"
               "|*   *|\n"
               " -----\n");
        break;
    }
}



