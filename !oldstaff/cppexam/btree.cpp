#include "btree.h"
#include <iostream>
#include <utility>

using namespace std;

BTree::BTree() : root(nullptr)
{

}
BTree::BTree(const BTree &original) : root(nullptr)
{
    root = clone(original.root);
}
BTree &BTree::operator=(const BTree &rhs)
{
    BTree temp(rhs);
    swap(*this, temp);
    return *this;
}
BTree::BTree(BTree &&victim) : root(nullptr)
{
    swap(root, victim.root);
}
BTree &BTree::operator=(BTree &&rhs)
{
    swap(*this, rhs);
    return *this;
}
BTree::~BTree()
{
    if (!root)
    {
        return;
    }
    else
    {
        delete root;
        root = nullptr;
    }
}

bool BTree::search(Data data) const
{
    if (!root)
    {
        return false;
    }
    else
    {
        Node *pointer = root;
        while (pointer)
        {
            if (data < pointer->data)
                pointer = pointer->left;
            else if (data > pointer->data)
                pointer = pointer->right;
            else
                return true;
        }
    }
    return false;
}
void BTree::add(Data data)
{
    if (!root)
    {
        root = new Node(data);
    }
    else
    {
        Node *pointer = root, *parent = nullptr;
        while (pointer && pointer->data != data)
        {
            parent = pointer;
            if (data < pointer->data)
                pointer = pointer->left;
            else
                pointer = pointer->right;
        }
        pointer = new Node(data);
        if (pointer->data < parent->data)
            parent->left = pointer;
        else
            parent->right = pointer;
    }
}
void BTree::remove(Data data)
{
    if (!root)
    {
        return;
    }
    else
    {
        Node *pointer = root, *parent = nullptr;
        while (pointer && pointer->data != data)
        {
            parent = pointer;
            if (data < pointer->data)
                pointer = pointer->left;
            else
                pointer = pointer->right;
        }
        if(pointer)
        {
            if(!pointer->left || !pointer->right)
            {
                Node *leaf = nullptr;
                if(pointer->left)
                    leaf = pointer->left;
                else if(pointer->right)
                    leaf = pointer->right;
                if(!parent)
                {
                    root = leaf;
                }
                else
                {
                    if(parent->left == pointer)
                        parent->left = leaf;
                    else
                        parent->right = leaf;
                }
            }
            else
            {
                Node *mostLeft = parent->right, *mostLeftParent = pointer;
                while(mostLeft->left)
                {
                    mostLeftParent = mostLeft;
                    mostLeft = mostLeft->left;
                }
                pointer->data = mostLeft->data;
                if(mostLeftParent->left == mostLeft)
                    mostLeftParent->left = nullptr;
                else
                    mostLeftParent->right = nullptr;
            }
        }
    }
}

BTree::Node *BTree::clone(BTree::Node *node)
{
    Node *result = nullptr;
    if(node)
    {
        result = new Node(*node);
        result->data = node->data;
        result->left = clone(node->left);
        result->right = clone(node->right);
    }
    return result;
}
void BTree::output() const
{
    output(root);
}

void BTree::output(Node *node, int level)
{
    if (node)
    {
        output(node->right,level+1);
        for(int i=0; i<level; i++)
        {
            cout<<"____";
        }
        cout<<node->data<<"\n";
        output(node->left,level+1);
    }
}


BTree::Node::Node(Data data) : data(data), right(nullptr), left(nullptr)
{

}

BTree::Node::~Node()
{
    right = nullptr;
    left = nullptr;
}
