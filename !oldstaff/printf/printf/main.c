#include <stdio.h>
#include <stdlib.h>
#include <stdarg.h>

int main()
{
    myprintf("Ad",5);

    return 0;
}

void myprintf(char *format, ...)
{
    va_list argumentPointer;
    char *p;
    int ivalue;
    double dvalue;

    va_start(argumentPointer, format);

    for (p = format; *p; ++p)
    {
        if (*p!='%')
        {
            putchar(*p);
        }
        switch(++*p)
        {
        case 'd':
            ivalue = va_arg(argumentPointer, int);
            break;
        case 'f' :
            dvalue = va_arg(argumentPointer, double);
            break;
        default:
            putchar(*p);
            break;
        }
    }
    va_end(argumentPointer);
}
