#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arrayMaxSize=256;
    char ourArray[arrayMaxSize];
    int top=0;
    char head;
    do
    {
        scanf("%c", &head);
        switch (head)
        {
        case '+':
            ++ourArray[top];
            break;
        case '-':
            --ourArray[top];
            break;
        case '>':
            ++top;
            break;
        case '<':
            --top;
            break;
        case '.':
            printf("%c", ourArray[top],top);
            break;
        case ';':
            break;
        }
    }
    while(head!=';');

    return 0;
}
