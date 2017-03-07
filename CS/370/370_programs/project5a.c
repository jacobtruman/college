//-----------------------------------------------------------
//	Robert F. Ludwick
//	CS 370 Section 1
//	Project 4a
//
//	Purpose: To implement the HS Election Algorithm.
//-----------------------------------------------------------

//-----------------------------------------------------------
//	Definitions
//-----------------------------------------------------------

#define MAX_NODES 200

//-----------------------------------------------------------
//	Enum:		bound
//
//	Purpose:	Provide enumeration for the inbound and outbound
//				status of tokens.
//-----------------------------------------------------------

enum bound
{
	outbound = 0,
	inbound = 1
};

//-----------------------------------------------------------
//	Struct:	node
//
//	Purpose:	Provide information for a node.
//-----------------------------------------------------------

struct node
{
	// Variables
	int Phase,
		UID;
};

//-----------------------------------------------------------
//	Struct:	token
//
//	Purpose:	Provide information for a token.
//-----------------------------------------------------------

struct token
{
	// Variables
	int UID,
		Hop_Count,
		Flag;
};

//-----------------------------------------------------------
//	Includes
//-----------------------------------------------------------

#include <errno.h>
#include <pthread.h>
#include <semaphore.h>
#include <stdlib.h>
#include <stdio.h>

//-----------------------------------------------------------
//	Global Variables
//-----------------------------------------------------------

pthread_t Node_Threads[MAX_NODES]; // Threads for all the nodes
sem_t Left_Buffer_Semaphores[MAX_NODES], // Sempahores for the left buffers
	Right_Buffer_Semaphores[MAX_NODES], // Semaphores for the right buffers
	Buffer_Semaphores[MAX_NODES], // Semaphores to signal non-empty buffers
	Init_Semaphore; // Semaphore for initialization of threads
int Left_Buffer_Tails[MAX_NODES], // Tails for the left buffer arrays
	Right_Buffer_Tails[MAX_NODES], // Tails for the right buffer arrays
	Num_Nodes, // Number of nodes input from file
	Counter, // Global counter for loops
	Error, // Global error flag
	Node_Counter = 0, // Counter for thread creation
	Sentinel = 0; // Sentinel for quitting the election
struct node Nodes[MAX_NODES]; // The node data
struct token Left_Buffers[MAX_NODES][MAX_NODES], // Left buffer data
	Right_Buffers[MAX_NODES][MAX_NODES]; // Right buffer data

//-----------------------------------------------------------
//	External Variables
//-----------------------------------------------------------

extern int errno;

//-----------------------------------------------------------
//	Function Prototypes
//-----------------------------------------------------------

void read_nodes();
void create_node_threads();
void join_node_threads();
void run_node();
void insert_token(int, char, struct token);
struct token retrieve_token(int, char);
struct token copy_token(int, char);
int check_tail(int, char);
void post_all_nodes();
int power(int, int);

//-----------------------------------------------------------
//	Function:	main
//
//	Output:		
//
//	Purpose:		
//-----------------------------------------------------------

int main()
{
	// Read nodes
	read_nodes();

	// Create node threads
	create_node_threads();

	// Join node threads
	join_node_threads();

	// Exit shell
	exit(EXIT_SUCCESS);
}

//-----------------------------------------------------------
//	Function:	read_nodes
//-----------------------------------------------------------

void read_nodes()
{
	// Variables
	char Input[12];

	// Read number of nodes
	fgets(Input, 12, stdin);
	Num_Nodes = atoi(Input);

	// Looper to record node data
	for(Counter = 0; Counter < Num_Nodes; Counter++)
	{
		// Read UID of next node
		fgets(Input, 12, stdin);

		// Set node data
		Nodes[Counter].Phase = 0;
		Nodes[Counter].UID = atoi(Input);

		// Init the semaphores
		sem_init(&Left_Buffer_Semaphores[Counter], 0, 1);
		sem_init(&Right_Buffer_Semaphores[Counter], 0, 1);
		sem_init(&Buffer_Semaphores[Counter], 0, 0);

		// Init the buffer tails
		Left_Buffer_Tails[Counter] = 0;
		Right_Buffer_Tails[Counter] = 0;

		// Output node
		printf("Process[%d] - UID[%d]: Created\n", Counter, Nodes[Counter].UID);
	}

	// Print extra line
	printf("\n");

	// Init the initialization semaphpre
	sem_init(&Init_Semaphore, 0, 1);

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	create_node_threads
//-----------------------------------------------------------

void create_node_threads()
{
	// Looper to create the threads
	for(Counter = 0; Counter < Num_Nodes; Counter++)
	{
		// Create node thread
		Error = pthread_create(&Node_Threads[Counter], NULL, (void*)run_node, (void*)"");

		// Check for thread creation error
		if(Error != 0)
		{
			printf("Error: Node thread creation failed.\0");
			exit(0);
		}
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	join_node_threads
//-----------------------------------------------------------

void join_node_threads()
{
	// Variables
	void* Thread_Result;

	// Looper to join the threads
	for(Counter = 0; Counter < Num_Nodes; Counter++)
	{
		// Wait for node thread
		pthread_join(Node_Threads[Counter], &Thread_Result);
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	run_node
//-----------------------------------------------------------

void run_node()
{
	// Variables
	int Node_Number,
		Left_Exist,
		Right_Exist,
		Tail,
		Received_Left = 0,
		Received_Right = 0;
	struct token To_Send,
		From_Buffer,
		From_Other;

	// Use semaphore for Node_Number assignment
	sem_wait(&Init_Semaphore);
	Node_Number = Node_Counter;
	Node_Counter++;
	sem_post(&Init_Semaphore);

	// Variables, con't
	int Left_Neighbor = (Node_Number - 1),
		Right_Neighbor = (Node_Number + 1);

	// Check for neighbors on "other side" of ring
	if(Left_Neighbor == -1)
	{
		Left_Neighbor = (Num_Nodes - 1);
	}
	if(Right_Neighbor == Num_Nodes)
	{
		Right_Neighbor = 0;
	}

	// Create first token
	To_Send.UID = Nodes[Node_Number].UID;
	To_Send.Flag = outbound;
	To_Send.Hop_Count = 1;

	insert_token(Left_Neighbor, 'r', To_Send);
	insert_token(Right_Neighbor, 'l', To_Send);

	// Looper for election process
	while(Sentinel == 0)
	{
		sem_wait(&Buffer_Semaphores[Node_Number]);

		// Check for left buffer entry
		if(check_tail(Node_Number, 'l') > 0)
		{
			From_Buffer = retrieve_token(Node_Number, 'l');

			if(From_Buffer.Flag == outbound)
			{
				if((From_Buffer.UID > Nodes[Node_Number].UID) && (From_Buffer.Hop_Count > 1))
				{
					From_Buffer.Hop_Count--;

					insert_token(Right_Neighbor, 'l', From_Buffer);
				}
				else if((From_Buffer.UID > Nodes[Node_Number].UID) && (From_Buffer.Hop_Count == 1))
				{
					From_Buffer.Flag = inbound;

					insert_token(Left_Neighbor, 'r', From_Buffer);
				}
				else if(From_Buffer.UID == Nodes[Node_Number].UID)
				{
					Sentinel = 1;

					// Output win
					printf("Process[%d] - UID[%d]: Leader\n", Node_Number, Nodes[Node_Number].UID);
					post_all_nodes();

					// Exit thread
					pthread_exit("");
				}
			}
			else
			{
				if(From_Buffer.UID == Nodes[Node_Number].UID)
				{
					Received_Left = 1;
				}

				if((Received_Left == 1) && (Received_Right == 1))
				{
					Nodes[Node_Number].Phase++;

					// Output advance
					printf("Process[%d] - UID[%d]: Phase %d\n", Node_Number, Nodes[Node_Number].UID, Nodes[Node_Number].Phase);

					From_Buffer.Flag = outbound;
					From_Buffer.Hop_Count = power(2, Nodes[Node_Number].Phase);

					insert_token(Left_Neighbor, 'r', From_Buffer);
					insert_token(Right_Neighbor, 'l', From_Buffer);

					Received_Left = 0;
					Received_Right = 0;
				}
				else if(From_Buffer.UID != Nodes[Node_Number].UID)
				{
					insert_token(Right_Neighbor, 'l', From_Buffer);
				}
			}
		}

		// Check for right buffer entry
		if(check_tail(Node_Number, 'r') > 0)
		{
			From_Buffer = retrieve_token(Node_Number, 'r');

			if(From_Buffer.Flag == outbound)
			{
				if((From_Buffer.UID > Nodes[Node_Number].UID) && (From_Buffer.Hop_Count > 1))
				{
					From_Buffer.Hop_Count--;

					insert_token(Left_Neighbor, 'r', From_Buffer);
				}
				else if((From_Buffer.UID > Nodes[Node_Number].UID) && (From_Buffer.Hop_Count == 1))
				{
					From_Buffer.Flag = inbound;

					insert_token(Right_Neighbor, 'l', From_Buffer);
				}
				else if(From_Buffer.UID == Nodes[Node_Number].UID)
				{
					Sentinel = 1;

					// Output win
					printf("Process[%d] - UID[%d]: Leader\n", Node_Number, Nodes[Node_Number].UID);
					post_all_nodes();

					// Exit thread
					pthread_exit("");
				}
			}
			else
			{
				if(From_Buffer.UID == Nodes[Node_Number].UID)
				{
					Received_Right = 1;
				}

				if((Received_Left == 1) && (Received_Right == 1))
				{
					Nodes[Node_Number].Phase++;

					// Output advance
					printf("Process[%d] - UID[%d]: Phase %d\n", Node_Number, Nodes[Node_Number].UID, Nodes[Node_Number].Phase);

					From_Buffer.Flag = outbound;
					From_Buffer.Hop_Count = power(2, Nodes[Node_Number].Phase);

					insert_token(Left_Neighbor, 'r', From_Buffer);
					insert_token(Right_Neighbor, 'l', From_Buffer);

					Received_Left = 0;
					Received_Right = 0;
				}
				else if(From_Buffer.UID != Nodes[Node_Number].UID)
				{
					insert_token(Left_Neighbor, 'r', From_Buffer);
				}
			}
		}
	}

	// Exit thread
	pthread_exit("");
}

//-----------------------------------------------------------
//	Function:	insert_token
//-----------------------------------------------------------

void insert_token(int Node_Number, char Left_Or_Right, struct token To_Insert)
{
	if(Left_Or_Right == 'l')
	{
		sem_wait(&Left_Buffer_Semaphores[Node_Number]);
		Left_Buffers[Node_Number][Left_Buffer_Tails[Node_Number]] = To_Insert;
		Left_Buffer_Tails[Node_Number]++;
		sem_post(&Left_Buffer_Semaphores[Node_Number]);
	}
	else
	{
		sem_wait(&Right_Buffer_Semaphores[Node_Number]);
		Right_Buffers[Node_Number][Right_Buffer_Tails[Node_Number]] = To_Insert;
		Right_Buffer_Tails[Node_Number]++;
		sem_post(&Right_Buffer_Semaphores[Node_Number]);
	}

	sem_post(&Buffer_Semaphores[Node_Number]);

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	retrieve_token
//-----------------------------------------------------------

struct token retrieve_token(int Node_Number, char Left_Or_Right)
{
	// Variables
	int Counter;
	struct token To_Return;

	// Check for left or right buffer
	if(Left_Or_Right == 'l')
	{
		sem_wait(&Left_Buffer_Semaphores[Node_Number]);

		// Get token
		To_Return = Left_Buffers[Node_Number][0];

		// Looper for bubbling up
		for(Counter = 0; Counter < (Left_Buffer_Tails[Node_Number] - 1); Counter++)
		{
			Left_Buffers[Node_Number][Counter] = Left_Buffers[Node_Number][Counter + 1];
		}

		// Decrement tail
		Left_Buffer_Tails[Node_Number]--;

		sem_post(&Left_Buffer_Semaphores[Node_Number]);
	}
	else
	{
		sem_wait(&Right_Buffer_Semaphores[Node_Number]);

		// Get token
		To_Return = Right_Buffers[Node_Number][0];

		// Looper for bubbling up
		for(Counter = 0; Counter < (Right_Buffer_Tails[Node_Number] - 1); Counter++)
		{
			Right_Buffers[Node_Number][Counter] = Right_Buffers[Node_Number][Counter + 1];
		}

		// Decrement tail
		Right_Buffer_Tails[Node_Number]--;

		sem_post(&Right_Buffer_Semaphores[Node_Number]);
	}

	// Return
	return(To_Return);
}

//-----------------------------------------------------------
//	Function:	copy_token
//-----------------------------------------------------------

struct token copy_token(int Node_Number, char Left_Or_Right)
{
	// Variables
	struct token To_Return;

	// Check for left or right buffer
	if(Left_Or_Right == 'l')
	{
		sem_wait(&Left_Buffer_Semaphores[Node_Number]);
		To_Return = Left_Buffers[Node_Number][0];
		sem_post(&Left_Buffer_Semaphores[Node_Number]);
	}
	else
	{
		sem_wait(&Right_Buffer_Semaphores[Node_Number]);
		To_Return = Right_Buffers[Node_Number][0];
		sem_post(&Right_Buffer_Semaphores[Node_Number]);
	}

	// Return
	return(To_Return);
}

//-----------------------------------------------------------
//	Function:	check_tail
//-----------------------------------------------------------

int check_tail(int Node_Number, char Left_Or_Right)
{
	// Variables
	int Tail;

	if(Left_Or_Right == 'l')
	{
		sem_wait(&Left_Buffer_Semaphores[Node_Number]);
		Tail = Left_Buffer_Tails[Node_Number];
		sem_post(&Left_Buffer_Semaphores[Node_Number]);
	}
	else
	{
		sem_wait(&Right_Buffer_Semaphores[Node_Number]);
		Tail = Right_Buffer_Tails[Node_Number];
		sem_post(&Right_Buffer_Semaphores[Node_Number]);
	}

	// Return
	return(Tail);
}

//-----------------------------------------------------------
//	Function:	post_all_nodes
//-----------------------------------------------------------

void post_all_nodes()
{
	// Variables
	int Counter;

	for(Counter = 0; Counter < Num_Nodes; Counter++)
	{
		sem_post(&Buffer_Semaphores[Counter]);
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	power
//-----------------------------------------------------------

int power(int Number, int Exponent)
{
	// Variables
	int Counter,
		Return = Number;

	for(Counter = 1; Counter < Exponent; Counter++)
	{
		Return *= Number;
	}

	// Return
	return(Return);
}

