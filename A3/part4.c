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
#define BR 0x0000

int main(int argc, char *argv[]) {
// int main() {
	if(argc == 3){
		long counter;
		FILE *f;
		char *line;
		int i;
		line = (char *)calloc(256,1);
		f = fopen(argv[1], "r");
		while (fscanf(f, "%x", &i)!=EOF){
			int temp = i & 0xF000;
			if (temp == ADD){
				counter++;
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
				counter++;
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
				counter++;
				printf("jmp ");
				int BaseR = i & 0x1C0;
				BaseR = BaseR >> 6;
				printf("r%d\n", BaseR);
			} else if (temp == BR){
				counter++;
				printf("br");
				int brn = i & 0x800;
				int brz = i & 0x400;
				int brp = i & 0x200;
				if (brn == 0x800){
					printf("n");
				}
				if (brz == 0x400){
					printf("z");
				}
				if (brp == 0x200){
					printf("p");
				}
				printf(" ");
				long pccounter;
				int pcoffset = i & 0x1FF; 
				char *ptr;
				pccounter = strtol(argv[2], &ptr, 16);
				int pcoffsetbits = i & 0x00FF;
				int sign = pcoffset & 0x100;
				int offset;
				if (sign == 0x100){
					pcoffsetbits = pcoffsetbits - 0x100;
					offset = pccounter + pcoffsetbits;
				} else {
					offset = pccounter + pcoffsetbits;
				}
				int offsetfinal = offset + counter;
				printf("0x%x\n", offsetfinal);
			}
		}
		memset(line, 0 ,256);
		rewind(f); //rewind to the beginning of the file.
		printf("\n");
	} else {
		printf("Please provide a single file name.\n");
	}
}
