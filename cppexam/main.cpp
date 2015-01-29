#include "btree.h"
#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include <exception>
#include <string>
#include <fstream>

using namespace std;

int main()
{
    BTree tree;
    int size = 0, element=0, choice=0;
    do
    {
        system("cls");
        cout << "Hello user. It's binary tree.\n" << endl;
        cout << "Main menu: " << endl;
        cout << "1. Build a tree." << endl;
        cout << "2. Add a new element." << endl;
        cout << "3. Find element." << endl;
        cout << "4. Remove element." << endl;
        cout << "5. Output tree." << endl;
        cout << "0. Exit.\n" << endl;
        cin >> choice;
        switch (choice)
        {
        case 1://new
            system("cls");
            cout << "Let's build new tree. Please enter tree size: ";
            cin >> size;
            for (int i = 0; i < size; i++)
            {
                cout << "Enter " << i+1 << " element: ";
                cin >> element;
                tree.add(element);
            }
            tree.output();
            cout << "\nTree built." << endl;
            system("pause");
            break;
        case 2://add
            system("cls");
            int newElement;
            cout<<"Let's add a new element."<<endl;
            cout<<"Enter element: ";
            cin>>newElement;
            tree.add(newElement);
            cout<<"Element added\n";
            tree.output();
            cout << "\n";
            system("pause");
            break;
        case 3://find
            system("cls");
            int whichElement;
            cout<<"Let's find element.\nEnter element you want to find: "<<endl;
            cin>>whichElement;
            if (tree.search(whichElement))
                cout << "Element founded." << endl;
            else
                cout << "Error. No such element." << endl;
            system("pause");
            break;
        case 4://remove
            system("cls");
            int removinElement;
            cout<<"Let's remove element.\nEnter element you want to remove: "<<endl;
            cin>>removinElement;
            if (tree.search(removinElement))
            {
                tree.remove(removinElement);
                cout<<"\nElement removed";
                tree.output();
            }
            else
            {
                cout << "Error. No such element." << endl;
                return 0;
            }
            system("pause");
            break;
        case 5://output
            system("cls");
            tree.output();
            system("pause");
            break;
        case 0:
            system("cls");
            cout<<"Bye-bye, user.\n";
            return 0;
            break;
        default:
            cout << "!ERROR! No such menu's variant.\nTry again or enter 0 to exit." <<endl;
            break;
        }
    }
    while(choice!=0);


    return 0;
}
