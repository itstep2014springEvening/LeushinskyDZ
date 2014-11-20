#include <stdio.h>
#include <stdlib.h>
#include <exception>

struct Process
{
	int id, needTime, workedTime, waitedTime;
	enum Status {WAIT, ACTIVE} status;
} ;

struct Node
{
	Process process ;
	Node *next, *previous;
};

void push(Node *&head, Process process);

void pop(Node *&head);

Process onHead(Node *head);

void roundRobin(Node *&head);

bool applyOnHead(Node *head, bool (*functor)(Process &));

void applyOnRest(Node *head, bool (*functor)(Process &));

bool work(Process &process);

bool wait(Process &process);

int main()
{
	int *startTime = nullptr;
	Process *array = nullptr;
	int n;
	scanf("%d", &n);
	startTime = new int [n];
	array = new Process[n];

	for(int i = 0; i < n; ++i)
	{
		scanf("%d", &startTime[i]);
		scanf("%d", &array[i].needTime);
        array[i].id=i;
        array[i].workedTime=0;
        array[i].waitedTime=0;
        array[i].status=Process::Status::WAIT;
	}

    delete [] array;
    delete [] startTime;
	return 0;
}

bool work(Process &process)
{
	process.status = Process::ACTIVE;
	++process.workedTime;
	return process.needTime == process.workedTime;
}

bool wait(Process &process)
{
	process.status = Process::WAIT;
	++process.waitedTime;
	return false;
}

void push(Node *&head, Process process)
{
	Node *p = nullptr;
	p = new Node;
	p->process = process;

	if(head == nullptr)
	{
		p->next = p;
		p->previous = p;
		head = p;
	}
	else
	{
		p->next = head;
		p->previous = head->previous;
		head->previous->next = p;
		head->previous = p;
		/*
		Node *tail=head->previous;
		p->next=head;
		p->previous=tail;
		tail->next=p;
		head->previous=p;
		*/
	}
}

void pop(Node *&head)
{
	if(head == nullptr)
		return;

	if(head->next == head)
	{
		delete head;
		head = nullptr;
	}
	else
	{
		Node *p = head;
		head = head->next;
		p->previous->next = head;
		head->previous = p->previous;
		delete p;
		p = nullptr;
	}
}

Process onHead(Node *head)
{
	if(head == nullptr)
		throw std::exception();

	return head->process;
}

void roundRobin(Node *&head)
{
	if(head == nullptr)
		return;

	head = head->next;
}

bool applyOnHead(Node *head, bool (*functor)(Process &))
{
	if(head == nullptr)
		throw std::exception();

	return functor(head->process);
}

void applyOnRest(Node *head, bool (*functor)(Process &))
{
	if(head != nullptr)
	{
		Node *p = head->next;

		while(p != head)
		{
			functor(p->process);
			p = p->next;
		}
	}
}
