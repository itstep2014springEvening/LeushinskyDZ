#ifndef BINTREE_H
#define BINTREE_H

#define MAX 100

typedef int Data;

class BTree
{
public:
    BTree();
    BTree(const BTree &original);
    BTree &operator=(const BTree &rhs);
    BTree(BTree &&victim);
    BTree &operator=(BTree &&rhs);
    ~BTree();

    bool search(Data data) const;
    void add(Data data);
    void remove(Data data);
    void output() const;
private:
    struct Node
    {
        Data data;
        Node *right;
        Node *left;
        Node(Data data);
        ~Node();
    } *root;
    static void output(Node *node, int level=0);
    static Node *clone(Node *node);
};

#endif // BINTREE_H
