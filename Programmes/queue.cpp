#include <iostream>
using namespace std;

class Queue
{
    int front, rear, n;
    int *arr;

public:
    Queue(int size)
    {
        n = size;
        arr = new int[n];
        front = rear = -1;
    }

    void enqueue(int x)
    {
        if (rear == n - 1)
        {
            cout << "Queue Overflow!\n";
            return;
        }

        if (front == -1)
            front = 0;

        arr[++rear] = x;
        cout << x << " enqueued\n";
    }

    void dequeue()
    {
        if (front == -1 || front > rear)
        {
            cout << "Queue Underflow\n";
            return;
        }

        cout << "Dequeued: " << arr[front++] << endl;
    }

    void display()
    {
        if (front == -1 || front > rear)
        {
            cout << "Queue is empty\n";
            return;
        }

        cout << "Queue elements: ";
        for (int i = front; i <= rear; i++)
        {
            cout << arr[i] << " ";
        }
        cout << endl;
    }
};

int main()
{
    int n, value, choice;

    cout << "Enter queue size: ";
    cin >> n;

    Queue q(n);

    while (true)
    {
        cout << "\n===== Queue Menu =====\n";
        cout << "1. Insert\n2. Delete\n3. Display\n4. Exit\n";
        cout << "Enter your choice: ";
        cin >> choice;

        switch (choice)
        {
        case 1:
            cout << "Enter the number: ";
            cin >> value;
            q.enqueue(value);
            break;

        case 2:
            q.dequeue();
            break;

        case 3:
            q.display();
            break;

        case 4:
            cout << "Exiting program...\n";
            return 0;

        default:
            cout << "Invalid choice!\n";
        }
    }
}
