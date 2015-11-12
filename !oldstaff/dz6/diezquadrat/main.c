int main()
{
    printf("Hello user, it's # time\n");
    int h,w,sw,frame;
    char c;
    printf("Please, enter height: ",w);
    scanf("%d",&w);
    printf("Please, enter width: ",h);
    scanf("%d",&h);
    for(int n=1; n<=w; n++)
    {
        for (int j=1; j<=h; j++)
        {
            if(n==1 || j==1 || j==h || n==w)
            {
                printf("#");
            }
            else
                printf(" ");
        }
        printf("\n");
    }
}
