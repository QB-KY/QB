#include<stdio.h>
#include<math.h>
int main()
{
    int i;
    int j;
    int k;
    
    for( i=-3; i<=3; i++ )
    {
        for( j=1; j<=abs(i); j++)
            printf(" ");
          
        for( k=abs(i)-3; k<=3-abs(i); k++)
            printf("%c",64+abs(j)+abs(k));
        printf("\n");
    }
    
}
