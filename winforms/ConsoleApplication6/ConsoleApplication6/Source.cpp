#include <iostream>
using namespace std;

struct Auto {
	int probeg;
	Auto *left = NULL; //лево- право
	Auto *right = NULL;

};

void addLeft(Auto *a, Auto* &first) {
	if (first == NULL){
		first = a;
	}
	else {
		a->right = first;
		first->left = a;
		first = a;
	}


}

void addRight(Auto *a, Auto* &first){
	if (first == NULL) {
		first = a;
	}
	else {
		//1/ допрыгать до правого конца
		Auto *temp = first;
		while (temp->right != NULL)
			temp = temp->right;
		a->left = temp;
		temp->right = a;

	}
}

void display(Auto* first) {
	while (first != NULL) {
		cout << first->probeg << " ";
		first = first->right;
	}
	cout << endl;
}

//вернуть список машин с пробегом от А до Б
Auto* search(Auto *first, int a, int b){
	Auto* result = NULL;
	while (first != NULL){
		if (a < first->probeg && first->probeg < b) {
			Auto* w = new Auto;
			w->probeg = first->probeg;
			addRight(w, result);
		}
		first = first->right;
	}
	return result;
}

//Функция удаления по номеру
void remove(Auto* &first, int n){
	Auto *temp = first;
	if (first == NULL)
		return;

	if (n == 1) {
		first = first->right;
		first->left = NULL;
		return;
	}

	int c = 1;
	while (temp != NULL){
		if (c == n){
			Auto *l = temp->left;
			Auto *r = temp->right;
			if (l != NULL)
			    l->right = r;
			if (r != NULL)
			r->left = l;
		}
		temp = temp->right;
		c++;
	}
}

void main(){
	Auto *first = NULL;
	Auto a;  a.probeg = 100;
	Auto b; b.probeg = 200;
	Auto c; c.probeg = 300;
	Auto d; d.probeg = 400;

	addRight(&a, first);
	addRight(&b, first);
	addLeft(&c, first);
	addLeft(&d, first);
	display(first);
	
	Auto *result = search(first, 199, 301);
	display(result);

	remove(first, 3);
	display(first);
}