//-----------------------------------------------------------
//	Robert F. Ludwick
//	CS 370 Section 1
//	Project 3a
//
//	Purpose: To simulate the Linux CPU scheduler.
//
// Notes:	-	I have implemented input in my scheduler
//				according to a user prompt once the program has
//				begun execution.
//				-	I have also implemented a bypass to preempting a
//				process when it is the only runnable process. For
//				example, if there are 3 processes and 2 are in
//				the IO queue, whenever the 1 running process
//				expires its time slice, it will automatically
//				receive a new one and not be preempted if the
//				other two processes are still in IO.
//-----------------------------------------------------------

//-----------------------------------------------------------
//	Definitions
//-----------------------------------------------------------

#define NUM_QUEUES 14
#define MAX_CPU_BURSTS 1024
#define MAX_IO_BURSTS 1023
#define QUEUE_LENGTH 256
#define MAX_PROCESSES 256

//-----------------------------------------------------------
//	Struct:	process
//
//	Purpose:	To provide a base process. Used for file-input
//				processes.
//-----------------------------------------------------------

struct process
{
	// Variables
	int Arrival_Time;
	char Type;
	int Priority_Nice_Value;
	int CPU_Bursts[MAX_CPU_BURSTS];
	int IO_Bursts[MAX_CPU_BURSTS];
	long Total_Burst;
	long Total_Burst_Saved;
};

//-----------------------------------------------------------
//	Struct:	queue_process
//
//	Purpose:	To expand on the base process with additional
//				information for use in the queues.
//-----------------------------------------------------------

struct queue_process
{
	// Variables
	process Base_Process;
	bool Current_Burst; // False = CPU; True = IO
	int Priority;
	int Burst_Remaining; // Current burst's remaining length
	int CPU_Burst_Used; // Tracks the amount of CPU used since last IO
	int IO_Burst_Used; // Tracks total amount of IO used since last time slice given
	int Time_Slice; // Time slice left
	int Old_Time_Slice; // Last time slice length
	int Process_Number;
	int CPU_Array_Index; // Tracks which CPU burst is currently, or pending, execution
	int IO_Array_Index; // Same as CPU_Array_Index
	long Termination_Time;
};

//-----------------------------------------------------------
//	Includes
//-----------------------------------------------------------

#include <iostream>
#include <iomanip> // For float precision
#include <fstream>
#include <stdlib.h>
#include <string>
#include <sstream> // For burst input from file

//-----------------------------------------------------------
//	Global Variables
//-----------------------------------------------------------

bool Bitmaps_1[NUM_QUEUES];
bool Bitmaps_2[NUM_QUEUES];
bool* Bitmaps_Active; // Pointer for bitmaps active array; starts at Bitmaps_1
bool* Bitmaps_Expired; // Same as Bitmaps_Active; starts at Bitmaps_2
int Queues_1_Tails[NUM_QUEUES]; // Tracks the tail for each queue
int Queues_2_Tails[NUM_QUEUES];
int* Queues_Active_Tails; // Pointer for queues active array tails; starts at Queues_1_Tails
int* Queues_Expired_Tails; // Same as Queues_Active_Tails; starts at Queues_2_Tails
int Queue_IO_Tail; // Tracks the tail for the IO queue
int Queue_Terminated_Tail; // Tracks the tail for the Terminated queue
int Active_Queue; // Tracks which queue is currently "executing"
process All_Processes[MAX_PROCESSES]; // Contains all incoming processes
queue_process Queues_1[NUM_QUEUES * QUEUE_LENGTH];
queue_process Queues_2[NUM_QUEUES * QUEUE_LENGTH];
queue_process Queue_IO[QUEUE_LENGTH];
queue_process Queue_Terminated[QUEUE_LENGTH];
queue_process* Queues_Active; // Pointer for queues active array; starts at Queues_1
queue_process* Queues_Expired; // Same as Queues_Active; starts at Queues_2
queue_process Running_Process;
long Clock = 0;
int Num_Arrived_Processes = 0;
int Terminated_Processes = 0;

//-----------------------------------------------------------
//	Function Prototypes
//-----------------------------------------------------------

void initialize_pointers(); // Sets up pointers
void initialize_queue_tails(); // Sets up tails
int get_input(); // Gets all input processes from file
bool get_arriving_processes(long, int); // Checks master list of processes for arrivals
void bubble_up_queue(int, int); // Bubbles a queue up to remove head
int get_initial_priority(process); // Gets initial priority for a process
int get_time_slice(int); // Gets the time slice for a priority
int get_queue_number(int); // Gets the queue number for a priority
void queue_insert(char, int, queue_process); // Inserts a process into the specified queue
int calculate_queue_index(int, int); // Calculates the array index based upon the "array number" and offset
bool schedule(); // Checks to see if preemption is neccessary for arriving and removed-IO processes
void preempt(); // Preempts the running process and gets a new one
void update_running_process(); // Updates stats on the running process
bool update_io_processes(bool); // Updates stats on the IO processes
void remove_io(int); // Removes a process from the IO queue
void swap_queues(); // Swaps the active and expired pointers (Queues, Tails, Bitmaps)
bool has_active(); // Checks if there are any active processes in queues
bool has_expired(); // Checks if there are any expired processes in queues
int get_priority(queue_process); // Gets the priority for a process that has been run
void display_stats(int); // Displays the final program statistics

//-----------------------------------------------------------
//	Namespaces
//-----------------------------------------------------------

using namespace std;

//-----------------------------------------------------------
//	Function:	main
//
//	Output:		The simulation results will be printed to the
//					screen.
//
//	Purpose:		To simulate the Linux CPU scheduler.
//-----------------------------------------------------------

int main()
{
	// Variables
	int Num_Processes;
	bool Process_Arrived, // If a process has arrived
		Swapped, // If there's a new process running
		Sentinel = false, // Loop terminator
		IO, // If the final IO entry must be skipped
		Fresh_IO; // If a process has come off IO

	// Initialize variables
	initialize_pointers();
	initialize_queue_tails();
	Active_Queue = NUM_QUEUES;

	// Get input
	Num_Processes = get_input();

	// Check number of processes
	if(Num_Processes > -1)
	{
		// Simulation loop
		while(Sentinel == false)
		{
			// Set swapped
			Swapped = false;
			IO = false;

			// Get arriving processes
			Process_Arrived = get_arriving_processes(Clock, Num_Processes);

			// Update IO processes information
			Fresh_IO = update_io_processes(IO);

			// Check if a process has arrived or come off IO
			if((Process_Arrived == true) || (Fresh_IO == true))
			{
				Swapped = schedule();
			} // Check if the running process is not a dummy
			else if((Running_Process.Base_Process.Type == 'r') || (Running_Process.Base_Process.Type == 'n'))
			{
				// Check to see if time slice expired
				if((Running_Process.Time_Slice == 0) && (Running_Process.Base_Process.Type == 'n'))
				{
					// Check to see if there's actually a non-IO to switch to
					if((has_active() == true) || (has_expired() == true))
					{
						preempt();

						Swapped = true;
					}
					else // Automatically grant new time slice
					{
						Running_Process.Priority = get_priority(Running_Process);
						Running_Process.Time_Slice = get_time_slice(Running_Process.Priority);
						Running_Process.Old_Time_Slice = Running_Process.Time_Slice;
					}
				} // Check if the running process has swapped to IO
				else if(Running_Process.Current_Burst == true)
				{
					preempt();

					Swapped = true;

					IO = true;
				} // Check if process has terminated
				else if(Running_Process.Base_Process.Total_Burst == 0)
				{
					preempt();

					Swapped = true;
				}
			}

			// Check if we are running a process
			if((Running_Process.Base_Process.Type == 'r') || (Running_Process.Base_Process.Type == 'n'))
			{
				// Output process swap if it happened
				if(Swapped == true)
				{
					cout << "T[" << Clock << "] - Process [" << Running_Process.Process_Number << "] begins execution\n";
				}

				// Update running process information
				update_running_process();
			}

			// Check to see if all inputted processes have terminated
			if(Terminated_Processes == Num_Processes)
			{
				cout << "T[" << Clock << "] - All processes terminated\n\n";

				Sentinel = true;
			}

			// Increment clock
			Clock++;
		}
	}

	// Display final stats
	display_stats(Num_Processes);

	// Exit simulation
	exit(EXIT_SUCCESS);
}

//-----------------------------------------------------------
//	Function:	initialize_pointers
//
//	Output:		All queue, tail and bitmaps pointers updated.
//
//	Purpose:		To initialize the pointers to the active and
//					expired arrays and their tails and bitmaps.
//-----------------------------------------------------------

void initialize_pointers()
{
	// Set pointers
	Bitmaps_Active = &Bitmaps_1[0];
	Bitmaps_Expired = &Bitmaps_2[0];
	Queues_Active_Tails = &Queues_1_Tails[0];
	Queues_Expired_Tails = &Queues_2_Tails[0];
	Queues_Active = &Queues_1[0];
	Queues_Expired = &Queues_2[0];
}

//-----------------------------------------------------------
//	Function:	initialize_queue_tails
//
//	Output:		The full set of queue tails will be updated to
//					0.
//
//	Purpose:		To initialize all queue tails.
//-----------------------------------------------------------

void initialize_queue_tails()
{
	// Loop to initialize
	for(int Counter = 0; Counter < NUM_QUEUES; Counter++)
	{
		// Reset tails to 0
		Queues_Active_Tails[Counter] = 0;
		Queues_Expired_Tails[Counter] = 0;
	}
}

//-----------------------------------------------------------
//	Function:	get_input
//
//	Input:		A text file location is prompted of the user
//					and used for input into the All_Processes
//					array.
//	Output:		The All_Processes array is filled with the
//					processes defined in the input file. An
//					integer representing failure/success will be
//					returned (-1 failure; number processes
//					otherwise;
//
//	Purpose:		To retrieve the input of processes from the
//					user-specified file.
//-----------------------------------------------------------

int get_input()
{
	// Variables
	int Pos = 0,
		Num_Processes = 0,
		Input_Burst,
		Num_CPU_Bursts,
		Num_IO_Bursts;
	string Input_File_Location,
		Input_Line;
	istringstream Input_Line_Stream;
	ifstream Input_File;
	bool Burst_Type;

	// Prompt for input file
	cout << "> Enter input file location: ";
	cin >> Input_File_Location;

	// Open input file
	Input_File.open(Input_File_Location.c_str());

	// Check for valid input file
	if(!Input_File.is_open())
	{
		cout << "* Error: Input file not found.\n";

		// Return failure
		return(-1);
	}
	else
	{
		// Input loop
		while(!Input_File.eof())
		{
			// Reset variables
			Num_CPU_Bursts = 0;
			Num_IO_Bursts = 0;
			Input_Line_Stream.clear();
			Burst_Type = false; // False = CPU; True = IO

			// Retrieve line input
			getline(Input_File, Input_Line);

			// Check for empty last line
			if(Input_Line.length() > 0)
			{
				// Copy line into input string stream
				Input_Line_Stream.str(Input_Line);

				All_Processes[Num_Processes].Total_Burst = 0;

				// Input arrival, type and priority/nice value
				Input_Line_Stream >> All_Processes[Num_Processes].Arrival_Time;
				Input_Line_Stream >> All_Processes[Num_Processes].Type;
				Input_Line_Stream >> All_Processes[Num_Processes].Priority_Nice_Value;

				// Retrieve remainder of bursts
				while(Input_Line_Stream >> Input_Burst)
				{
					All_Processes[Num_Processes].Total_Burst += Input_Burst;

					// Check for the burst type we are encountering
					if(Burst_Type == false)
					{
						All_Processes[Num_Processes].CPU_Bursts[Num_CPU_Bursts] = Input_Burst;

						// Increment number bursts and switch next burst type
						Num_CPU_Bursts++;
						Burst_Type = true;
					}
					else
					{
						All_Processes[Num_Processes].IO_Bursts[Num_IO_Bursts] = Input_Burst;

						// Increment number bursts and switch next burst type
						Num_IO_Bursts++;
						Burst_Type = false;
					}
				}

				// Save total burst for later calculations
				All_Processes[Num_Processes].Total_Burst_Saved = All_Processes[Num_Processes].Total_Burst;

				Num_Processes++;
			}
		}
	}

	// Return number of processes
	return(Num_Processes);
}

//-----------------------------------------------------------
//	Function:	get_arriving_processes
//
//	Input:		Current clock and the number of processes.
//	Output:		Arriving processes entered into their
//					respective queues.
//
//	Purpose:		To get all of the arriving processes from the
//					master array and get them into the execution
//					queues.
//-----------------------------------------------------------

bool get_arriving_processes(long Clock, int Num_Processes)
{
	// Variables
	int Priority,
		Queue_Number;
	queue_process New_Process;
	bool New = false;

	// Loop to check processes
	for(int Counter = 0; Counter < Num_Processes; Counter++)
	{
		// Check if process has just arrived
		if(All_Processes[Counter].Arrival_Time == Clock)
		{
			// Get priority and queue number
			Priority = get_initial_priority(All_Processes[Counter]);
			Queue_Number = get_queue_number(Priority);

			// Create queue process & set priority
			New_Process.Base_Process = All_Processes[Counter];
			New_Process.Priority = Priority;

			// Get time slice if applicable
			if(New_Process.Base_Process.Type == 'n')
			{
				New_Process.Time_Slice = get_time_slice(Priority);
				New_Process.Old_Time_Slice = New_Process.Time_Slice;
			}

			// Set process number
			New_Process.Process_Number = Num_Arrived_Processes;

			// Set current burst
			New_Process.Current_Burst = false;
			New_Process.Burst_Remaining = New_Process.Base_Process.CPU_Bursts[0];

			// Output arriving process
			cout << "T[" << Clock << "] - Process [" << New_Process.Process_Number << "] arrived at active queue [" << Queue_Number << "]: P[" << Priority << "]";
			if(New_Process.Base_Process.Type == 'n')
			{
				cout << " T[" << New_Process.Time_Slice << "]";
			}
			cout << "\n";

			// Increment arrived processes
			Num_Arrived_Processes++;

			// Insert process into queue
			queue_insert('a', Queue_Number, New_Process);

			// Set New boolean
			New = true;
		}
	}

	// Return
	return(New);
}

//-----------------------------------------------------------
//	Function:	bubble_up_queue
//
//	Input:		Index to bubble up from and the queue number
//					to modify.
//	Output:		The queue number specified is bubbled up.
//
//	Purpose:		To remove the head of a queue.
//-----------------------------------------------------------

void bubble_up_queue(int Index, int Queue_Number)
{
	// Variables
	queue_process Dummy;
	int Counter;

	// Bubble loop
	for(Counter = 0; Counter < (Queues_Active_Tails[Queue_Number] - 1); Counter++)
	{
		// Copy up
		Queues_Active[Counter + Index] = Queues_Active[Counter + Index + 1];
	}

	// Make final entry a dummy
	Queues_Active[Counter + Index] = Dummy;

	// Decrement tail
	Queues_Active_Tails[Queue_Number]--;

	// Set bitmap to 0 if neccessary
	if(Queues_Active_Tails[Queue_Number] == 0)
	{
		Bitmaps_Active[Queue_Number] = false;
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	get_initial_priority
//
//	Input:		The arriving process.
//	Output:		The priority for that arriving process.
//
//	Purpose:		To calculate the initial priority for an
//					arriving process.
//-----------------------------------------------------------

int get_initial_priority(process Arriving_Process)
{
	// Variables
	int Priority = 120;

	// Check if process is N-RTP
	if(Arriving_Process.Type == 'n')
	{
		Priority = (120 + Arriving_Process.Priority_Nice_Value);
	}
	else
	{
		Priority = Arriving_Process.Priority_Nice_Value;
	}

	// Return
	return(Priority);
}

//-----------------------------------------------------------
//	Function:	get_priority
//
//	Input:		The process to calculate for.
//	Output:		The priority for that process.
//
//	Purpose:		To calculate the priority for a process that
//					has expired its time slice.
//-----------------------------------------------------------

int get_priority(queue_process Expired_Process)
{
	// Variables
	int Bonus, Penalty, New_Priority;

	// Perform bonus calculation
	Bonus = ((Expired_Process.IO_Burst_Used * 3) / (2 * Expired_Process.Old_Time_Slice));

	// Perform penalty lookup
	if(Expired_Process.CPU_Burst_Used < 201)
	{
		Penalty = 0;
	}
	else if(Expired_Process.CPU_Burst_Used < 301)
	{
		Penalty = 1;
	}
	else if(Expired_Process.CPU_Burst_Used < 401)
	{
		Penalty = 2;
	}
	else if(Expired_Process.CPU_Burst_Used < 501)
	{
		Penalty = 3;
	}
	else if(Expired_Process.CPU_Burst_Used < 601)
	{
		Penalty = 4;
	}
	else
	{
		Penalty = 5;
	}

	// Calculate new priority
	New_Priority = (Expired_Process.Priority - (Bonus - Penalty));
	if(New_Priority > 140)
	{
		New_Priority = 140;
	}
	else if((New_Priority < 100) && (Expired_Process.Base_Process.Type == 'n'))
	{
		New_Priority = 100;
	}

	// Reset processes' old statistics
	Expired_Process.CPU_Burst_Used = 0;
	Expired_Process.IO_Burst_Used = 0;

	// Return calculation
	return(New_Priority);
}

//-----------------------------------------------------------
//	Function:	get_time_slice
//
//	Input:		The priority to calculate the time slice from.
//	Output:		The time slice.
//
//	Purpose:		To calculate the time slice for an expired
//					process.
//-----------------------------------------------------------

int get_time_slice(int Priority)
{
	// Return calculation immediately
	return((int)((-4.75 * (double)Priority) + 675));
}

//-----------------------------------------------------------
//	Function:	get_queue_number
//
//	Input:		The priority to calculate the queue from.
//	Output:		The queue number.
//
//	Purpose:		To calculate the queue number to insert an
//					expired process into.
//-----------------------------------------------------------

int get_queue_number(int Priority)
{
	// Variables
	int Queue_Number = (Priority / 10);

	// Check if queue number too high
	if(Queue_Number == NUM_QUEUES)
	{
		Queue_Number = (NUM_QUEUES - 1);
	}

	// Return
	return(Queue_Number);
}

//-----------------------------------------------------------
//	Function:	queue_insert
//
//	Input:		Queue type, queue number and the process to
//					insert.
//	Output:		The specified queue and if applicable, queue
//					number of that type, will have the process
//					at the foot of the queue.
//
//	Purpose:		To insert a process into a queue.
//-----------------------------------------------------------

void queue_insert(char Type, int Queue_Number, queue_process Inserting_Process)
{
	// Variables
	int Queue_Index;

	// Check active type
	if(Type == 'a')
	{
		// Set insert process, update bitmap and increment tail
		Queues_Active[calculate_queue_index(Queue_Number, Queues_Active_Tails[Queue_Number])] = Inserting_Process;
		Bitmaps_Active[Queue_Number] = true;
		Queues_Active_Tails[Queue_Number]++;
	} // Check expired type
	else if(Type == 'e')
	{
		// Set insert process, update bitmap and increment tail
		Queues_Expired[calculate_queue_index(Queue_Number, Queues_Expired_Tails[Queue_Number])] = Inserting_Process;
		Bitmaps_Expired[Queue_Number] = true;
		Queues_Expired_Tails[Queue_Number]++;
	} // Check terminated type
	else if(Type == 't')
	{
		// Set insert process and increment tail
		Queue_Terminated[Queue_Terminated_Tail] = Inserting_Process;
		Queue_Terminated_Tail++;
	} // IO type
	else
	{
		// Set insert process and increment tail
		Queue_IO[Queue_IO_Tail] = Inserting_Process;
		Queue_IO_Tail++;
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	calculate_queue_index
//
//	Input:		The queue number and index of that queue
//					desired.
//	Output:		The index offset where to find the index
//					desired.
//
//	Purpose:		To translate the queue number and index
//					desired into the singular-array index. A
//					single array is used rather than a
//					multidimensional array because the multi
//					generated errors.
//-----------------------------------------------------------

int calculate_queue_index(int Queue_Number, int Index)
{
	// Return calculation immediately
	return((Queue_Number * QUEUE_LENGTH) + Index);
}

//-----------------------------------------------------------
//	Function:	schedule
//
//	Output:		A boolean representing a swap if it happened.
//
//	Purpose:		To call the preempt function if a process
//					exists in an active queue that has a higher
//					queue number than the running process.
//-----------------------------------------------------------

bool schedule()
{
	// Variables
	bool Swapped = false;

	// Looper to find new process to run
	for(int Counter = 0; Counter < NUM_QUEUES; Counter++)
	{
		// Check if the queue has a process to run and is a higher queue
		if((Bitmaps_Active[Counter] == true) && (Counter < Active_Queue))
		{
			preempt();

			// Set swapped for return to main loop
			Swapped = true;
			break;
		}
	}

	// Return
	return(Swapped);
}

//-----------------------------------------------------------
//	Function:	preempt
//
//	Output:		The active, expired, terminated and IO queues
//					are updated as applicable according to the
//					running process and new process to run. The
//					running process is updated to the new process
//					and the old running process is inserted into
//					the correct queue.
//
//	Purpose:		To swap the running process with the next
//					process to run.
//-----------------------------------------------------------

void preempt()
{
	// Variables
	queue_process Current_Process = Running_Process,
		Dummy;
	int Queue_Number;
	bool Switched = false,
		Add_Active = false;

	// Check for saving of old running process
	if((Current_Process.Base_Process.Type == 'n') || (Current_Process.Base_Process.Type == 'r'))
	{
		// Insert as-is if time slice left
		if(((Current_Process.Time_Slice > 0) || (Current_Process.Base_Process.Type == 'r')) && (Current_Process.Current_Burst == false) && (Current_Process.Base_Process.Total_Burst > 0))
		{
			Add_Active = true;
		}
		else if(((Current_Process.Time_Slice > 0) || (Current_Process.Base_Process.Type == 'r')) && (Current_Process.Current_Burst == true) && (Current_Process.Base_Process.Total_Burst > 0)) // Moved to IO
		{
			Current_Process.CPU_Burst_Used = 0;

			// Output preemption
			cout << "T[" << Clock << "] - Process [" << Current_Process.Process_Number << "] completed its CPU; moved to IO queue: P[" << Current_Process.Priority << "]";
			if(Current_Process.Base_Process.Type == 'n')
			{
				cout << " T[" << Current_Process.Time_Slice << "]";
			}
			cout << "\n";

			queue_insert('i', 0, Current_Process);
		}
		else if(Current_Process.Base_Process.Total_Burst == 0) // Terminated
		{
			// Output termination
			cout << "T[" << Clock << "] - Process [" << Current_Process.Process_Number << "] terminated\n";

			// Set termination time & insert into terminated queue
			Current_Process.Termination_Time = Clock;
			queue_insert('t', 0, Current_Process);

			// Increment termination counter
			Terminated_Processes++;
		}
		else // Expired timeslice
		{
			Current_Process.Priority = get_priority(Current_Process);
			Queue_Number = get_queue_number(Current_Process.Priority);

			// Get time slice if applicable
			if(Current_Process.Base_Process.Type == 'n')
			{
				Current_Process.Time_Slice = get_time_slice(Current_Process.Priority);
				Current_Process.Old_Time_Slice = Current_Process.Time_Slice;
			}

			// Output expiration
			cout << "T[" << Clock << "] - Process [" << Current_Process.Process_Number << "] expired its timeslice; moved to expired queue [" << Queue_Number << "]: P[" << Current_Process.Priority << "] T[" << Current_Process.Time_Slice << "]\n";

			// Insert into queue
			queue_insert('e', Queue_Number, Current_Process);

		}
	}

	// Check for bitmap switch
	if((has_active() == false) && (has_expired() == true))
	{
		swap_queues();
	}

	// Looper to find new process to run
	for(int Counter = 0; Counter < NUM_QUEUES; Counter++)
	{
		if(Bitmaps_Active[Counter] == true)
		{
			// Set running process to the highest priority process
			Running_Process = Queues_Active[calculate_queue_index(Counter, (Queues_Active_Tails[Counter] - 1))];

			// Bubble array up to remove process from queue
			bubble_up_queue(calculate_queue_index(Counter, (Queues_Active_Tails[Counter] - 1)), Counter);

			Switched = true;

			Active_Queue = Counter;
			break;

		}
	}

	// If nothing was swapped, then there's nothing to run
	if(Switched == false)
	{
		// Set to dummy process
		Running_Process = Dummy;

		Active_Queue = NUM_QUEUES;
	}

	// Check for saving of old running process
	if((Current_Process.Base_Process.Type == 'n') || (Current_Process.Base_Process.Type == 'r'))
	{
		if(Add_Active == true)
		{
			Queue_Number = get_queue_number(Current_Process.Priority);

			// Output preemption
			cout << "T[" << Clock << "] - Process [" << Current_Process.Process_Number << "] was preempted to active queue [" << Queue_Number << "]: P[" << Current_Process.Priority << "]";
			if(Current_Process.Base_Process.Type == 'n')
			{
				cout << " T[" << Current_Process.Time_Slice << "]";
			}
			cout << "\n";

			queue_insert('a', Queue_Number, Current_Process);

		}
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	update_running_process
//
//	Output:		The running process is updated.
//
//	Purpose:		To update the running process' statistics and
//					status.
//-----------------------------------------------------------

void update_running_process()
{
	// Update variables
	Running_Process.Burst_Remaining--;
	Running_Process.Base_Process.Total_Burst--;
	Running_Process.CPU_Burst_Used++;
	if(Running_Process.Base_Process.Type == 'n')
	{
		Running_Process.Time_Slice--;
	}

	// Check if we need to swap burst type
	if(Running_Process.Burst_Remaining == 0)
	{
		Running_Process.Current_Burst = true;
		Running_Process.Burst_Remaining = Running_Process.Base_Process.IO_Bursts[Running_Process.IO_Array_Index];
		Running_Process.CPU_Array_Index++;
	}

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	update_io_processes
//
//	Input:		A boolean if we need to skip the last process
//					for proper calculation.
//	Output:		The IO queue is updated and any processes
//					leaving IO are put back into the active
//					queues (Unless they actually expired when they
//					entered IO.
//
//	Purpose:		To update the statistics and state of the IO
//					processes.
//-----------------------------------------------------------

bool update_io_processes(bool Skip_Last)
{
	// Variables
	queue_process Completed_Process;
	int Queue_Number,
		Counter_Limit = Queue_IO_Tail;
	bool Fresh_IO = false;

	if(Skip_Last == true)
	{
		Counter_Limit--;
	}

	// Loop to update them all
	for(int Counter = 0; Counter < Counter_Limit; Counter++)
	{
		Queue_IO[Counter].Burst_Remaining--;
		Queue_IO[Counter].Base_Process.Total_Burst--;
		Queue_IO[Counter].IO_Burst_Used++;

		// Check if we need to move out of IO into a queue
		if(Queue_IO[Counter].Burst_Remaining == 0)
		{
			// Save process locally
			Completed_Process = Queue_IO[Counter];
			Completed_Process.Current_Burst = false;
			Completed_Process.Burst_Remaining = Completed_Process.Base_Process.CPU_Bursts[Completed_Process.CPU_Array_Index];
			Completed_Process.IO_Array_Index++;

			// Update IO array
			remove_io(Counter);

			Fresh_IO = true;

			// Check which type of queue to enter into
			if((Completed_Process.Time_Slice > 0) || (Completed_Process.Base_Process.Type == 'r'))
			{
				Queue_Number = get_queue_number(Completed_Process.Priority);

				// Output move
				cout << "T[" << Clock << "] - Process [" << Completed_Process.Process_Number << "] completed its IO; moved to active queue [" << Queue_Number << "]: P[" << Completed_Process.Priority << "]";
				if(Completed_Process.Base_Process.Type == 'n')
				{
					cout << " T[" << Completed_Process.Time_Slice << "]";
				}
				cout << "\n";

				queue_insert('a', Queue_Number, Completed_Process);

			}
			else // Expired time slice
			{
				Completed_Process.Priority = get_priority(Completed_Process);
				Queue_Number = get_queue_number(Completed_Process.Priority);

				// Get time slice if applicable
				if(Completed_Process.Base_Process.Type == 'n')
				{
					Completed_Process.Time_Slice = get_time_slice(Completed_Process.Priority);
					Completed_Process.Old_Time_Slice = Completed_Process.Time_Slice;
				}

				// Output expiration
				cout << "T[" << Clock << "] - Process [" << Completed_Process.Process_Number << "] compeleted its IO; moved to expired queue [" << Queue_Number << "]: P[" << Completed_Process.Priority << "]";
				if(Completed_Process.Base_Process.Type == 'n')
				{
					cout << " T[" << Completed_Process.Time_Slice << "]";
				}
				cout << "\n";

				// Insert into queue
				queue_insert('e', Queue_Number, Completed_Process);

			}
		}
	}

	// Return
	return(Fresh_IO);
}

//-----------------------------------------------------------
//	Function:	remove_io
//
//	Input:		Index of the process to remove from the IO
//					queue.
//	Output:		The IO queue is updated.
//
//	Purpose:		To remove a process from the IO queue because
//					it left IO.
//-----------------------------------------------------------

void remove_io(int Index)
{
	// Variables
	queue_process Dummy;
	int Counter;

	// Bubble loop
	for(Counter = Index; Counter < Queue_IO_Tail; Counter++)
	{
		// Copy up
		Queue_IO[Counter] = Queue_IO[Counter + 1];
	}

	// Make final entry a dummy
	Queue_IO[Counter + 1] = Dummy;

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	swap_queues
//
//	Output:		The queues, tails and bitmaps pointers will be
//					swapped.
//
//	Purpose:		To perform the O(1) scheduling swap of the
//					bitmaps.
//-----------------------------------------------------------

void swap_queues()
{
	// Variables
	queue_process* Queues_Swapper;
	bool* Bitmaps_Swapper;
	int* Tails_Swapper;

	// Swap queues
	Queues_Swapper = Queues_Active;
	Queues_Active = Queues_Expired;
	Queues_Expired = Queues_Swapper;

	// Swap bitmaps
	Bitmaps_Swapper = Bitmaps_Active;
	Bitmaps_Active = Bitmaps_Expired;
	Bitmaps_Expired = Bitmaps_Swapper;

	// Swap tails
	Tails_Swapper = Queues_Active_Tails;
	Queues_Active_Tails = Queues_Expired_Tails;
	Queues_Expired_Tails = Tails_Swapper;

	// Print bitmaps for active queue
	cout << "T[" << Clock << "] - Queues swapped. Active:";
	for(int Counter = 0; Counter < NUM_QUEUES; Counter++)
	{
		if(Bitmaps_Active[Counter] == true)
		{
			cout << " 1";
		}
		else
		{
			cout << " 0";
		}
	}
	cout << "\n";

	// Return
	return;
}

//-----------------------------------------------------------
//	Function:	has_active
//
//	Output:		Boolean if there are active processes waiting
//					to be executed.
//
//	Purpose:		To determine if there are processes waiting
//					to be executed.
//-----------------------------------------------------------

bool has_active()
{
	// Variables
	bool Has_Active = false;

	// Loop to check bitmaps
	for(int Counter = 0; Counter < NUM_QUEUES; Counter++)
	{
		if(Bitmaps_Active[Counter] == true)
		{
			Has_Active = true;
		}
	}

	// Return
	return(Has_Active);
}

//-----------------------------------------------------------
//	Function:	has_expired
//
//	Output:		Boolean if there are expired processes waiting
//					to become active again.
//
//	Purpose:		To determine if there are processes waiting
//					to become active again.
//-----------------------------------------------------------

bool has_expired()
{
	// Variables
	bool Has_Expired = false;

	// Loop to check bitmaps
	for(int Counter = 0; Counter < NUM_QUEUES; Counter++)
	{
		if(Bitmaps_Expired[Counter] == true)
		{
			Has_Expired = true;
		}
	}

	// Return
	return(Has_Expired);
}
//-----------------------------------------------------------
//	Function:	display_stats
//
//	Input:		The number of processes to display stats for.
//	Output:		Statistics for all processes then global
//					statistics.
//
//	Purpose:		To display scheduler statistics.
//-----------------------------------------------------------

void display_stats(int Num_Processes)
{
	// Variables
	int CPU_Time,
		Next_CPU_Time,
		CPU_Counter,
		IO_Counter,
		Next_IO_Time,
		IO_Time,
		Turnaround_Time,
		Waiting_Time,
		Total_CPU_Time = 0,
		Total_Waiting_Time = 0,
		Total_Turnaround_Time = 0;
	double CPU_Utilization,
		Total_CPU_Utilization,
		Average_Waiting_Time,
		Average_Turnaround_Time,
		Average_CPU_Utilization;

	// Display header
	cout << setiosflags(ios_base::fixed) << "* INDIVIDUAL STATISTICS *\n\n";

	// Processes loop
	for(int Counter = 0; Counter < Num_Processes; Counter++)
	{
		// Reset process statistics
		CPU_Time = 0;
		CPU_Counter = 0;
		IO_Time = 0;
		IO_Counter = 0;
		Turnaround_Time = 0;
		Waiting_Time = 0;

		// Perform turnaround calculation
		Turnaround_Time = (Queue_Terminated[Counter].Termination_Time - Queue_Terminated[Counter].Base_Process.Arrival_Time);

		// Perform CPU time calculation
		Next_CPU_Time = Queue_Terminated[Counter].Base_Process.CPU_Bursts[CPU_Counter];
		while(Next_CPU_Time > 0)
		{
			CPU_Time += Next_CPU_Time;

			CPU_Counter++;
			Next_CPU_Time = Queue_Terminated[Counter].Base_Process.CPU_Bursts[CPU_Counter];
		}

		// Perform IO time calculation
		Next_IO_Time = Queue_Terminated[Counter].Base_Process.IO_Bursts[IO_Counter];
		while(Next_IO_Time > 0)
		{
			IO_Time += Next_IO_Time;

			IO_Counter++;
			Next_IO_Time = Queue_Terminated[Counter].Base_Process.IO_Bursts[IO_Counter];
		}

		// Perform waiting time calculation
		Waiting_Time = (Turnaround_Time - CPU_Time - IO_Time);

		// Perform CPU utilization calculation
		CPU_Utilization = (((double)CPU_Time / Turnaround_Time) * 100);

		// Output stats
		cout << "Process[" << setprecision(0) << Queue_Terminated[Counter].Process_Number << "]\n";
		cout << "  Turnaround Time: " << Turnaround_Time << "\n";
		cout << "  Total CPU Time: " << CPU_Time << "\n";
		cout << "  Waiting Time: " << Waiting_Time << "\n";
		cout << "  CPU Utilization %: " << setprecision(1) << CPU_Utilization << "%\n\n";

		// Add up into totals for global calculations
		Total_CPU_Time += CPU_Time;
		Total_Waiting_Time += Waiting_Time;
		Total_Turnaround_Time += Turnaround_Time;
		Total_CPU_Utilization += CPU_Utilization;
	}

	// Overall statistics calculations
	Average_Waiting_Time = ((double)Total_Waiting_Time / Num_Processes);
	Average_Turnaround_Time = ((double)Total_Turnaround_Time / Num_Processes);
	Average_CPU_Utilization = (Total_CPU_Utilization / Num_Processes);

	// Output global statistics
	cout << setprecision(3) << "* INDIVIDUAL STATISTICS *\n\n";
	cout << "Average Waiting Time: " << Average_Waiting_Time << "\n";
	cout << "Average Turnaround Time: " << Average_Turnaround_Time << "\n";
	cout << "Average CPU Utilization: " << Average_CPU_Utilization << "\n";

	// Return
	return;
}

