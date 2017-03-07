//-----------------------------------------------------------
//	Robert F. Ludwick
//	CS 370 Section 1
//	Project 4a
//
//	Purpose: To simulate a professor's office hours using
//				threads and semaphores.
//-----------------------------------------------------------

//-----------------------------------------------------------
//	Definitions
//-----------------------------------------------------------

#define MAX_STUDENTS 512

//-----------------------------------------------------------
//	Includes
//-----------------------------------------------------------

#include <errno.h>
#include <pthread.h>
#include <semaphore.h>
#include <signal.h>
#include <stdlib.h>
#include <stdio.h>

//-----------------------------------------------------------
//	Global Variables
//-----------------------------------------------------------

int Office_Open = 1;
int Num_Students = 0;
int Num_Students_Waiting = 0;
pthread_t Student_Threads[MAX_STUDENTS];
sem_t Semaphore;

//-----------------------------------------------------------
//	External Variables
//-----------------------------------------------------------

extern int errno;

//-----------------------------------------------------------
//	Function Prototypes
//-----------------------------------------------------------

void sig_ctlc_handler(int);
void sig_ctlz_handler(int);
void IdleProf();
void ArrivingStudent();
void bubble_up();

//-----------------------------------------------------------
//	Function:	main
//
//	Output:		The usage of the shell will be output.
//
//	Purpose:		To provide the main shell loop
//-----------------------------------------------------------

int main()
{
	// Initialize the semaphore
	sem_init(&Semaphore, 0, 1);

	// Signal handling
	signal(SIGINT, sig_ctlc_handler);
	signal(SIGTSTP, sig_ctlz_handler);

	// Seed random number generator
	srand(time(NULL));

	// Handle professor
	IdleProf();

	// Exit shell
	exit(EXIT_SUCCESS);
}

//-----------------------------------------------------------
//	Function:	sig_ctlc_handler
//
//	Input:		Integer representing signal.
//	Output:		
//
//	Purpose:		
//-----------------------------------------------------------

void sig_ctlc_handler(int Signal)
{
	// Check to see if office hours are still open
	if(Office_Open == 1)
	{
		// Set office hours closed
		Office_Open = 0;

		// Display message that office closed
		write(0, "\nOffice hours have ended.\n", 26);
		write(0, "New students will not be seen.\n\n", 32);
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	sig_ctlz_handler
//
//	Input:		Integer representing signal.
//	Output:		
//
//	Purpose:		
//-----------------------------------------------------------

void sig_ctlz_handler(int Signal)
{
	// Variables
	int Error;

	// Check to see if office hours are still open
	if(Office_Open == 1)
	{
		// Increment students
		Num_Students_Waiting++;
		Num_Students++;

		// Create student thread
		Error = pthread_create(&Student_Threads[Num_Students_Waiting - 1], NULL, (void*)ArrivingStudent, (void*)"");

		// Check for thread creation error
		if(Error != 0)
		{
			printf("Error: Student thread creation failed.\0");
			exit(0);
		}
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	IdleProf
//
//	Input:		
//	Output:		
//
//	Purpose:		
//-----------------------------------------------------------

void IdleProf()
{
	// Variables
	int Sleep_Clock = 0;
	void* Thread_Result;

	// Output professor going to sleep
	printf("Professor will sleep\n\0");

	// Loop while no students waiting and office hours open
	while((Office_Open == 1) || (Num_Students_Waiting > 0))
	{
		// Check to see if the professor should see a student
		if(Num_Students_Waiting == 0)
		{
			// Output sleeping professor
			printf("sleeping ... %d seconds\n\0", Sleep_Clock);

			// Increment sleep clock
			Sleep_Clock++;

			// Sleep
			sleep(1);
		}
		else
		{
			// Wait for student thread
			pthread_join(Student_Threads[0], &Thread_Result);

			// Decrement waiting students
			Num_Students_Waiting--;

			// Reset sleep clock
			Sleep_Clock = 0;
		}
	}

	// Print professor leaving
	printf("The professor has left the building.\n\0");

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	ArrivingStudent
//
//	Input:		
//	Output:		
//
//	Purpose:		
//-----------------------------------------------------------

void ArrivingStudent()
{
	// Variables
	int Student_Number  = Num_Students;

	// Display student arrival
	printf("Student %d has arrived\n\0", Student_Number);

	// Wait for semaphore
	sem_wait(&Semaphore);

	// Print student arrival
	printf("Student %d is entering the office\n\0", Student_Number);
	printf("Professor is seeing student %d\n\0", Student_Number);

	// Generate random meeting length
	sleep((rand() % 4) + 1);

	// Print student leaving
	printf("Professor is done seeing student %d\n\0", Student_Number);

	// Bubble up student threads
	bubble_up();

	// Post semaphore
	sem_post(&Semaphore);

	// Exit thread
	pthread_exit("");
}

//-----------------------------------------------------------
//	Function:	bubble_up
//
//	Input:		
//	Output:		
//
//	Purpose:		
//-----------------------------------------------------------

void bubble_up()
{
	// Variables
	int Counter;

	// Bubbling loop
	for(Counter = 0; Counter < (MAX_STUDENTS - 1); Counter++)
	{
		// Move student thread up one
		Student_Threads[Counter] = Student_Threads[Counter + 1];
	}

	// Return
	return;
}

