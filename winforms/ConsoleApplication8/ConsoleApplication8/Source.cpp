#include <iostream>
using namespace std;


struct  Book
{
	char *name;
	int year;

	Book * left = NULL;
	Book * right = NULL;
};



//добавление справа
void addR(Book* &first, Book * newBook){
	if (first == NULL){
		first = newBook;
		return;
	}
	Book *temp = first;
	while (temp->right)
		temp = temp->right;
	newBook->left = temp;
	temp->right = newBook;
	
}

//функция отображения
//получает левую книгу и выводит все книги на экран
void display(Book *first){
	while (first != NULL){
		cout << first->name << ' ';
		first = first->right;
	}
	cout << endl;
}


int size(Book *first){
	int n = 0;
	while (first != NULL){
		n++;
		first = first->right;
	}
	return n;
}

//добавление слева
void addL(Book* &first, Book * newBook){
	if (first == NULL){
		first = newBook;
		return;
	}
	first->left = newBook;
	newBook->right = first;
	first = newBook;
}

//добавление с позиции n
void addNumber(Book* &first, Book * newBook, int n){
	if (n == 1){
		addL(first, newBook);
	}
	
	Book *temp = first;
	n--;
	while (n > 1){
		temp = temp->right;
		n--;
	}
	newBook->right = temp->right;
	newBook->left = temp;
	temp->right = newBook;
}

//удаление по номеру
void delNumber(Book* &first, int n){
	Book *temp = first;
	while (n > 1){
		temp = temp->right;
		n--;
	}
	temp->left->right = temp->right;
	temp->right->left = temp->left;
}



//принимает два числа и меняет их местами
void swap(Book* &first, int a, int b){
	Book *temp = first;
	Book *x = NULL;
	Book *y = NULL;
	int n = 1;
	while (temp != NULL){
		if (n == a)
			x = temp;
		if (n == b)
			y = temp;
		n++;
		temp = temp->right;
	}
	Book q = *x;
	x->left->right = y;
	x->right->left = y;

	y->left->right = x;
	y->right->left = x;

	x->left = y->left;
	x->right = y->right;

	y->left = q.left;
	y->right = q.right;
}





void main(){
	Book * first = NULL; //этот указатель всегда указывает на самую левую книгу
	Book a; a.name = "a";
	Book b; b.name = "b";
	Book c; c.name = "c";
	Book d; d.name = "d";
	Book j; j.name = "j";
	addR(first, &a);
	addR(first, &b);
	addR(first, &c);
	addR(first, &d);
	addR(first, &j);

	display(first);
	Book h; h.name = "hhhh";
	addNumber(first, &h,3);
	display(first);
	delNumber(first, 3);
	display(first);
	swap(first, 2, 4);
	display(first);
}