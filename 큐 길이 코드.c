#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#pragma warning (disable : 4996)

int WriteCount = 0;
int ReadCount = 0;
char chip[2];

long long int readqueue[9] = { 0 };
int SameCheck = 0;

int bongbong = 0;		//동일한 위치의 읽기가 10회 이내에서 실행되는 횟수를 카운트하는 변수
int count = 0;

int QueueCount = 0;

char commend[8];
char sector_number[20];
char size[30];

char time1[40];
char time2[40];

long long int LSN = 0;
long long int LPN = 0;
long long int LBN = 0;

char Reding[100];

void main(FILE* trace, FILE* COUNT) {

	int spar;
	int C_Check, SIZE, S_SIZE;

	fopen_s(&trace, "2016021612-LUN1_4096.txt", "r");            //사용자이진파일 오픈. 만약 파일이 없을경우 신규 생성1
	if (trace == NULL) {                           //파일 생성 혹은 열기에 실패한 경우 
		puts("입력을 위한 파일을 열 수 없습니다.\n");         //에러메세지 출력
		exit(1);                                    //프로그램 종료
	}

	fopen_s(&COUNT, "2016021612-LUN1_4096_큐10_LSN.txt", "ab+");
	if (COUNT == NULL) {
		puts("입력을 위한 파일을 열 수 없습니다.\n");
		exit(1);
	}

	fseek(trace, 0, SEEK_SET);

	while (!feof(trace)) {
		while (fgets(Reding, sizeof(Reding), trace)) {
			strcpy(commend, strtok(Reding, ","));
			strcpy(size, strtok(NULL, ","));
			strcpy(sector_number, strtok(NULL, ","));
			strcpy(time1, strtok(NULL, ","));

			LSN = atoll(sector_number);
			LPN = LSN / 16;
			LBN = LPN / 64;

			//if (strcmp(commend, "R") == 0) {
				for (int i = 0; i < 10; i++) {
					if (LSN == readqueue[i]) {
						SameCheck = 1;
						//printf("%s\n", commend);
						//printf("%d번째 큐 : %lld // 현재 LSN : %lld\n", i, readqueue[i],LSN);
					}
				}
				if (SameCheck == 1) {
					count++;
					SameCheck = 0;

					fputs(commend, COUNT);
					fputs(",", COUNT);
					fputs(sector_number, COUNT);
					fputs("\r\n", COUNT);
				}

				if (QueueCount == 10) {
					QueueCount = 0;
				}
				readqueue[QueueCount] = LSN;
				QueueCount++;
			//}

		}
	}

	printf("%d 회 ", count);

	fclose(trace);
}