int NODmaker(int stringI, int columnJ)
{
    int a,b,c,NOD;
    a=stringI+0;
    b=columnJ+0;
    while(a%b!=0)
    {
        c=a%b;
        a=b;
        b=c;
    }
    NOD=b;
    return b;
}
