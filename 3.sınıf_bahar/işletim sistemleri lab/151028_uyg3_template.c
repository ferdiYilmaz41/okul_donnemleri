#include <unistd.h>
#include <stdio.h>
#include <stdlib.h>
#include <sys/wait.h>
#include <time.h> 			//for usleep(); if you need to sleep shorter than 1 sec. //usleep((int)(100000)); for 0.1 sec.s
#include <sys/stat.h>		//for the "last modified time" stat

char *pathRep;
struct stat attr;

void funcprintTimeAndChanges(...) {

	char pathLogFile[250];
	sprintf(pathLogFile, "%s_0-repHist.log", pathRep);

	struct stat chkdattr = attr;

	while(?) {

		if(attr.st_mtime ? chkdattr.st_mtime) {
			printf("Last modified time: %s", ctime(&attr.st_mtime)); //If you need some ctime comparison, use (a.st_mtime == b.st_mtime)
		}

		printf("\r\033[1A%c",  system("date")); // \r: set cursor to the first char of the line; \033[1A: move cursor up 1 line;
		fflush(stdout);	//clear output buffer
		usleep((int)(100000));
	}

	printf("This line should never be executed. Server program must always be running!\n");
}

void *funcChecker(...) {

	while (?) {
		stat(pathSub, &attr);
		sleep(?);
	}

	printf("This line should never be executed. Server program must always be running!\n");
}

int main(...) {

	return 0;
}