#include <stdio.h>
#include <stdlib.h>

int main()
{
    int vadimMoney=10000, zaharMoney=10000, vladMoney;
    printf("Hello user, counting time!\n");
    zaharMoney=zaharMoney+(12*(zaharMoney*0.13));
    printf("Zahar's money at 12 month = %d$\n", zaharMoney);
    vadimMoney=vadimMoney+(7*(vadimMoney*0.13));
    printf("Vadim's money at 7 month = %d$\n", vadimMoney);
    vladMoney=2*0.63*(10000+(5*(10000*0.13)));
    printf("Vlad's money = %d$", vladMoney);
    return 0;
}
