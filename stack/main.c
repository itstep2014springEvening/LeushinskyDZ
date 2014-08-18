#include <stdio.h>
#include <stdlib.h>

int main()
{
    int stack [256];
    int top=-1,value;
    stack[++top]=value;//push
    value=stack[top--];//pop
    value=stack[top];//onTop
    top<0;//isEmpty
    top=-1;//clear


    return 0;
}
