#include <stdio.h>
#include <stdarg.h>
#include <stdlib.h>
#include <fcntl.h>
#include <unistd.h>

int main()
{
    printf("Hello world!\n");
    return 0;
}

void ourprintf(char *format, ...)
{
    va_list argumentPointer;
    va_start(argumentPointer, format);

    int number=va_arg(argumentPointer, int);

    va_enal(argumentPointer);

}
