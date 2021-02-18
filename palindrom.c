#include <stdio.h>

int main(){
    int i,x;
    int palindrom = 1;
    char A[100];

    scanf("%d",&x);
    
    if(3<=x && x<=100){
        scanf("%s",&A);
        for(i=0;i<=x;i++){
            if(A[i] != A[x-i-1]){
                palindrom = 0;
            }
        }
        if (palindrom == 1){
            printf("YA");
        }
        else if (palindrom == 0){
            printf("TIDAK");
        }
    }
    return 0;
}