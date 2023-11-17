#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>

enum body { HEAD, UBDY, HAND, LEG_, FOOT };
#define NUMOFITEMS 13

int count = 0;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

void dressItem(int part, char *name) {

	static const char *BODY_STRING[] = { "kafa ", "govde", "el   ", "bacak", "ayak " };

	pthread_mutex_lock(&mutex);

	if (count == 0) {
		printf("0. --> Saglik calisanlarina sonsuz tesekkurler!..\n");
		count++;
	}

	int itemNumber = count;

	if (part == HEAD && count > 1)
		itemNumber--;

	printf("%2d. (%s) %s ", itemNumber, BODY_STRING[part], name);

	if (count == NUMOFITEMS) {
		printf("--> Goreve hazirim!\n");
	} else {
		printf("--> Kalan oge sayisi: %d\n", NUMOFITEMS - count);
	}

	count++;

	pthread_mutex_unlock(&mutex);
}

void *funcHEAD(void *p) {
	dressItem(HEAD, "YuzDezenfektani          ");
	dressItem(HEAD, "SaglikMaskesi            ");
	dressItem(HEAD, "Bone                     ");
	dressItem(HEAD, "KoruyucuPlastikYuzMaskesi");
	return NULL;
}

void *funcUBDY(void *p) {
	dressItem(UBDY, "Atlet                    ");
	dressItem(UBDY, "Gomlek                   ");
	dressItem(UBDY, "Tulum                    ");
	return NULL;
}

void *funcHAND(void *p) {
	dressItem(HAND, "ElDezenfektani           ");
	dressItem(HAND, "Eldiven                  ");
	return NULL;
}

void *funcLEG_(void *p) {
	dressItem(LEG_, "Pantolon                 ");
	dressItem(LEG_, "Kemer                    ");
	return NULL;
}

void *funcFOOT(void *p) {
	dressItem(FOOT, "Corap                    ");
	dressItem(FOOT, "Ayakkabi                 ");
	return NULL;
}

int main(int argc, char *argv[]) {
	pthread_t threads[5];

	pthread_create(&threads[0], NULL, funcHEAD, NULL);
	pthread_create(&threads[1], NULL, funcUBDY, NULL);
	pthread_create(&threads[2], NULL, funcHAND, NULL);
	pthread_create(&threads[3], NULL, funcLEG_, NULL);
	pthread_create(&threads[4], NULL, funcFOOT, NULL);

	for (int i = 0; i < 5; i++) {
		pthread_join(threads[i], NULL);
	}

	pthread_mutex_destroy(&mutex);

	return 0;
}