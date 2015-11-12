#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Hello user, it's CONE POWER v1.00!\n");
    printf("Be careful, this program understand only -int- types of numbers.!\n");
    int radius = 0;
    int height = 0;
    int volume = 0;
    int area = 0;
    printf("Please, enter r(radius)");
    scanf("%d", &radius);
    printf("Please, enter h(height)");
    scanf("%d", &height);
    volume = (0.33*3.14)*radius*radius*height;
    area = 3.14*radius*(radius+sqrt(radius*radius+height*height));
    printf("Cone volume(V) = %dcm^3\nCone area(S) = %dcm^2", volume, area);
    return 0;
}
