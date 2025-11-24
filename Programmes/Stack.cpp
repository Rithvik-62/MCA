#include<iostream>
using namespace std;
class Stack
{
    private:
        int *arr;
        int top;
        int capacity;

    public:
        Stack(int Size)
        {
            arr = new int[Size];
            capacity=Size;
            top =-1;
        }
        ~Stack()
        {
            delete[] arr;
        }
        void push(int element)
        {
            if(isFull())
            {
                cout <<"Stack Overflow! Cannot Push" << element<<endl;
                return;
            }
            arr[++top]=element;
            cout<<element<< " Pushed to Stack"<<endl;
        }
        int pop()
        {
            if(isEmpty())
            {
                cout<<"Stack Underflow! Cannot Pop"<<endl;
                return -1;
            }
            return arr[top--];
        }
        int peek()
        {
            if(isEmpty())
            {
                cout << "Stack is Empty "<<endl;
                return -1;
            }
            return arr[top];
        }
        bool isEmpty()
        {
            return top==-1;
        }
        bool isFull()
        {
            return top==capacity-1;
        }
        void display()
        {
            if(isEmpty())
            {
                cout << "Stack is Empty" << endl;
                return;
            }
            cout<<"Stack elements : ";
            for(int i=0;i<=top;i++)
            {
                cout <<arr[i]<< " ";
            }
            cout << endl;
        }
};
int main()
{
    int size;
    cout << "Enter the size of the stack: ";
    cin >> size;

    Stack s(size);
    int choice, value;

    while(true)
    {
        cout << "\n------ STACK MENU ------\n";
        cout << "1. PUSH\n2. POP\n3. PEEK\n4. DISPLAY\n5. EXIT\n";
        cout << "Enter your choice: ";
        cin >> choice;

        switch(choice)
        {
            case 1:
                cout << "Enter element to push: ";
                cin >> value;
                s.push(value);
                break;

            case 2:
                cout << "Popped: " << s.pop() << endl;
                break;

            case 3:
                cout << "Top element: " << s.peek() << endl;
                break;

            case 4:
                s.display();
                break;

            case 5:
                cout << "Exiting...\n";
                return 0;

            default:
                cout << "Invalid choice! Please try again.\n";
        }
    }
}
