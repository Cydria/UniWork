/*
Name: Jeremy Eng Yeow Ong
UPI : 5421357
ID  : JOng180
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

#define ADD 0x1000
#define AND 0x5000
#define JMP 0xC000

int main(int argc, char *argv[]) {
// int main() {
	if(argc == 2){
		FILE *f;
		char *line;
		int i;
		line = (char *)calloc(256,1);
		f = fopen(argv[1], "r");
		while (fscanf(f, "%x", &i)!=EOF){
			// printf("%x\n", i);
			int temp = i & 0xF000;
			if (temp == ADD){
				printf("add ");
				int DR = i & 0xE00;
				DR = DR >> 9;
				printf("r%d,", DR);
				int SR1 = i & 0x1C0;
				SR1 = SR1 >> 6;
				printf("r%d,", SR1);
				int immediate = i & 0x20;
				if (immediate == 0x20){
					int positivepart = i & 0xF;
					// int twocomp = ~i + 0x1;
					int sign = i & 0x10;
					if (sign == 0x10){
						int immvalue = i & 0xF;
						printf("%d\n", immvalue - 16);
					} else if (sign == 0x0){
						int immvalue = i & 0xF;
						printf("%d\n", immvalue);
					}
				} else if (immediate == 0x0){
					int SR2 = i & 0x7;
					printf("r%d\n", SR2);
				}
			} else if (temp == AND){
				printf("and ");
				int DR = i & 0xE00;
				DR = DR >> 9;
				printf("r%d,", DR);
				int SR1 = i & 0x1C0;
				SR1 = SR1 >> 6;
				printf("r%d,", SR1);
				int immediate = i & 0x20;
				if (immediate == 0x20){
					int positivepart = i & 0xF;
					// int twocomp = ~i + 0x1;
					int sign = i & 0x10;
					if (sign == 0x10){
						int immvalue = i & 0xF;
						printf("%d\n", immvalue - 16);
					} else if (sign == 0x0){
						int immvalue = i & 0xF;
						printf("%d\n", immvalue);
					}
				} else if (immediate == 0x0){
				int SR2 = i & 0x7;
				printf("r%d\n", SR2);
				}
			} else if (temp == JMP){
				printf("jmp ");
				int BaseR = i & 0x1C0;
				BaseR = BaseR >> 6;
				printf("r%d\n", BaseR);
			}
		}
		memset(line, 0 ,256);
		rewind(f); //rewind to the beginning of the file.
		printf("\n");
	} else {
		printf("Please provide a single file name.\n");
	}
}
