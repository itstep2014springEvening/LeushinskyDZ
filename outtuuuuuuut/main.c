#include <stdio.h>
int main(void)
{
register int i;
FILE *fp;
float balance[100];

/* �������� �� ������ */
if((fp=fopen("balance.txt", "a+t"))==NULL) {
printf("Cannot open file.");
return 1;
}
for(i=0; i<100; i++) balance[i] = (float) i;

/* ���������� �� ��� ����� ������� balance */
fwrite(balance, sizeof balance, 1, fp) ;
fclose(fp);

/* ��������� ������� */
for(i=0; i<100; i++) balance[i] = 0.0;

/* �������� ��� ������ */
if((fp=fopen("balance","rb"))==NULL) {
printf("cannot open file");
return 1;
}

/* ������ �� ��� ����� ������� balance */
fread(balance, sizeof balance, 1, fp);

/* ����� ����������� ������� */
for(i=0; i<100; i++) printf("%f  ", balance [i]);
fclose(fp);
return 0;
}
