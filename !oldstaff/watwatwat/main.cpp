#include <iostream>
#include <cstring>
#include <cstdio>

int main()
{
    char str[256];
    char cocopy[256];
    gets(str);
    for(int i=0;i<256;++i)
    {
        cocopy[i]=str[i];
    }
    for(int i=0;i<256;++i)
    {
        if(str[i]=='a')
        {
            cocopy[i]='b';
            cocopy[i+1]='b';
            for(int i=0;i<256;++i)
            {
                cocopy[i]=cocopy[i+1];
            }


        }
    }
    printf("%s", cocopy);

    return 0;
}
