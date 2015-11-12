#include "fib.h"

int fib(int peremennaya)
{
int x = 0, y = 1;
for (int i = 1; i <= peremennaya; i++)
{
int r = x + y;
x = y;
y = r;

}
return 0;
}
