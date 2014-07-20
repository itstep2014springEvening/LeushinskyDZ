#include <stdio.h>
#include <stdlib.h>
#include "../../mymodules/mymath.h"

int main()
{
    int stringI, columnJ, n;
    printf("Enter field size: ");
    scanf("%d", &n);
    for(stringI=1; stringI<=n; ++stringI)
    {
        for(columnJ=1; columnJ<=n; ++columnJ)
        {
            printf("%c",NODmaker(stringI, columnJ)==1?'#':' ');
        }
        printf("\n");
    }
    return 0;
}
