#include<iostream>
using namespace std;

struct Node
{
    int data;
    Node* next;
};

void printList(Node* head)
{
    Node* temp = head;
    while(temp!=nullptr)
    {
        cout<<temp->data << " ->";
        temp = temp->next;
    }
    cout << "NULL" << endl;
}

int main()
{
    int n,value;
    cout << "Enter number of Nodes : ";
    cin >> n;

    if(n<=0)
    {
        cout << "Invalid Size ! " << endl;
        return 0;
    }
    cout << "Enter value for Node 1 : ";
    cin >> value;
    Node* head = new Node {value,nullptr};
    Node* temp = head;

    for(int i=2;i<=n;i++)
    {
        cout << "Enter Value for Node " << i << ":" ;
        cin >> value;
        temp -> next = new Node{value,nullptr};
        temp = temp->next;
    }
    cout << "\n Singly linked List ";
    printList(head);

    return 0;
}
