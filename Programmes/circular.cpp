#include <iostream>
using namespace std;

class CircularQueue
{
    int *arr;
    int front, rear, size;

public:
    CircularQueue(int s)
    {
        size = s;
        arr = new int[size];
        front = rear = 0;
    }

    bool isFull()
    {
        return (rear + 1) % size == front;
    }

    bool isEmpty()
    {
        return front == rear;
    }

    void enqueue(int val)
    {
        if (isFull())
        {
            cout << "Queue Overflow!\n";
            return;
        }
        rear = (rear + 1) % size;
        arr[rear] = val;
        cout << val << " enqueued\n";
    }

    void dequeue()
    {
        if (isEmpty())
        {
            cout << "Queue Underflow!\n";
            return;
        }
        front = (front + 1) % size;
        cout << "Dequeued: " << arr[front] << endl;
    }

    void display()
    {
        if (isEmpty())
        {
            cout << "Queue is Empty\n";
            return;
        }

        cout << "Queue Elements: ";
        int i = (front + 1) % size;
        while (i != (rear + 1) % size)
        {
            cout << arr[i] << " ";
            i = (i + 1) % size;
        }
        cout << endl;
    }
};

int main()
{
    int n;
    cout << "Enter Queue size: ";
    cin >> n;

    CircularQueue q(n + 1); //CircularQueue q(n);

    int choice, value;

    while (true)
    {
        cout << "\n===== Circular Queue Menu =====\n";
        cout << "1. Enqueue\n";
        cout << "2. Dequeue\n";
        cout << "3. Display\n";
        cout << "4. Exit\n";
        cout << "Enter your choice: ";
        cin >> choice;

        switch (choice)
        {
        case 1:
            cout << "Enter value: ";
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
            cout << "Exiting...\n";
            return 0;

        default:
            cout << "Invalid choice! Try again.\n";
        }
    }
}
