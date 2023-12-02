


/* KUTAY DURAN
 * 19*****37
 * Computer Engineering
 */



// C# program to Implement a stack
// using singly linked list

// import package
using System;
using System.Collections.Generic;

// Create Stack Using Linked list
public class Program
{

	public class StackUsingLinkedlist
{

	// A linked list node
	private class Node
	{
		// integer data
		public int data;

		// reference variable Node type
		public Node link;
	}

	// create global top reference variable
	Node top;

	// Constructor
	public StackUsingLinkedlist() { this.top = null; }

	// Utility function to add
	// an element x in the stack
	// insert at the beginning
	public void push(int x)
	{
		// create new node temp and allocate memory
		Node temp = new Node();

		// check if stack (heap) is full.
		// Then inserting an element
		// would lead to stack overflow
		if (temp == null)
		{
			Console.Write("\nHeap Overflow");
			return;
		}

		// initialize data into temp data field
		temp.data = x;

		// put top reference into temp link
		temp.link = top;

		// update top reference
		top = temp;
	}

	// Utility function to check if
	// the stack is empty or not
	public bool isEmpty() { return top == null; }

	// Utility function to return
	// top element in a stack
	public int peek()
	{
		// check for empty stack
		if (!isEmpty())
		{
			return top.data;
		}
		else
		{
			Console.WriteLine("Stack is empty");
			return -1;
		}
	}

	// Utility function to pop top element from the stack
	public void pop() // remove at the beginning
	{
		// check for stack underflow
		if (top == null)
		{
			Console.Write("\nStack Underflow");
			return;
		}

		// update the top pointer to
		// point to the next node
		top = (top).link;
	}

	public void display()
	{
		// check for stack underflow
		if (top == null)
		{
			Console.Write("\nStack Underflow");
			return;
		}
		else
		{
			Node temp = top;
			while (temp != null)
			{

				// print node data
				Console.Write(temp.data);

				// assign temp link to temp
				temp = temp.link;
				if (temp != null)
					Console.Write(" -> ");
			}
		}
	}
}
	public class CircularQueue
	{

		// Declaring the class variables.
		private int size, front, rear;

		// Declaring array list of integer type.
		private List<int> queue = new List<int>();

		// Constructor
		public CircularQueue(int size)
		{
			this.size = size;
			this.front = this.rear = -1;
		}

		// Method to insert a new element in the queue.
		public void enQueue(int data)
		{

			// Condition if queue is full.
			if ((front == 0 && rear == size - 1) ||
			(rear == (front - 1) % (size - 1)))
			{
				Console.Write("Queue is Full");
			}

			// condition for empty queue.
			else if (front == -1)
			{
				front = 0;
				rear = 0;
				queue.Add(data);
			}

			else if (rear == size - 1 && front != 0)
			{
				rear = 0;
				queue[rear] = data;
			}

			else
			{
				rear = (rear + 1);

				// Adding a new element if
				if (front <= rear)
				{
					queue.Add(data);
				}

				// Else updating old value
				else
				{
					queue[rear] = data;
				}
			}
		}

		// Function to dequeue an element
		// form th queue.
		public int deQueue()
		{
			int temp;

			// Condition for empty queue.
			if (front == -1)
			{
				Console.Write("Queue is Empty");

				// Return -1 in case of empty queue
				return -1;
			}

			temp = queue[front];

			// Condition for only one element
			if (front == rear)
			{
				front = -1;
				rear = -1;
			}

			else if (front == size - 1)
			{
				front = 0;
			}
			else
			{
				front = front + 1;
			}

			// Returns the dequeued element
			return temp;
		}

		// Method to display the elements of queue
		public void displayQueue()
		{

			// Condition for empty queue.
			if (front == -1)
			{
				Console.Write("Queue is Empty");
				return;
			}

			// If rear has not crossed the max size
			// or queue rear is still greater then
			// front.
			Console.Write("Elements in the circular queue are: ");

			if (rear >= front)
			{

				// Loop to print elements from
				// front to rear.
				for (int i = front; i <= rear; i++)
				{
					Console.Write(queue[i]);
					Console.Write(" ");
				}
				Console.Write("\n");
			}

			// If rear crossed the max index and
			// indexing has started in loop
			else
			{

				// Loop for printing elements from
				// front to max size or last index
				for (int i = front; i < size; i++)
				{
					Console.Write(queue[i]);
					Console.Write(" ");
				}

				// Loop for printing elements from
				// 0th index till rear position
				for (int i = 0; i <= rear; i++)
				{
					Console.Write(queue[i]);
					Console.Write(" ");
				}
				Console.Write("\n");
			}
		}
	}
	public class BST
	{

		// Class of a tree node
		public class Node
		{
			public int data;
			public Node left, right;

			public Node(int val)
			{
				this.data = val;
				this.left = null;
				this.right = null;
			}
		}

		// Function for traversing tree using
		// preorder postorder and inorder method
		public static void PostPreInOrderInOneFlowRecursive(Node root, List<int> pre, List<int> post, List<int> inOrder)
		{

			// Return if root is null
			if (root == null)
				return;

			// Pushes the root data into the pre
			// order vector
			pre.Add(root.data);

			// Recursively calls for the left node
			PostPreInOrderInOneFlowRecursive(root.left, pre, post, inOrder);

			// Pushes node data into the inorder vector
			inOrder.Add(root.data);

			// Recursively calls for the right node
			PostPreInOrderInOneFlowRecursive(root.right, pre, post, inOrder);

			// Pushes the node data into the Post Order
			// Vector
			post.Add(root.data);
		}

		// Driver Code
	}
	public class Graph
	{
		private int V; // No. of vertices

		// Array of lists for
		// Adjacency List Representation
		private List<int>[] adj;

		// Constructor
		 public Graph(int v)
		{
			V = v;
			adj = new List<int>[v];
			for (int i = 0; i < v; ++i)
				adj[i] = new List<int>();
			
		}

		// Function to Add an edge into the graph
		public void AddEdge(int v, int w)
		{
			adj[v].Add(w); // Add w to v's list.
		}

		// A function used by DFS
		void DFSUtil(int v, bool[] visited)
		{
			// Mark the current node as visited
			// and print it
			visited[v] = true;
			Console.Write(v + " ");

			// Recur for all the vertices
			// adjacent to this vertex
			List<int> vList = adj[v];
			foreach (var n in vList)
			{
				if (!visited[n])
					DFSUtil(n, visited);
			}
		}

		// The function to do DFS traversal.
		// It uses recursive DFSUtil()
		public void DFS(int v)
		{
			// Mark all the vertices as not visited
			// (set as false by default in c#)
			bool[] visited = new bool[V];

			// Call the recursive helper function
			// to print DFS traversal
			DFSUtil(v, visited);
		}

		// Driver's Code

	}

// Driver code
	public static void Main(String[] args)
	{
		stack();
		Circulr();
		Bst();
		fraph();
	}
	public static void stack()
    {
		StackUsingLinkedlist obj
		= new StackUsingLinkedlist();

		// insert Stack value
		obj.push(11);
		obj.push(22);
		obj.push(33);
		obj.push(44);

		// print Stack elements
		obj.display();

		// print Top element of Stack
		Console.Write("\nTop element is {0}\n", obj.peek());

		// Delete top element of Stack
		obj.pop();
		obj.pop();

		// print Stack elements
		obj.display();

		// print Top element of Stack
		Console.Write("\nTop element is {0}\n", obj.peek());
		Console.WriteLine("******************* Stack Finish **************");
	}
	public static void Circulr()
    {
		// CircularQueue class.
		CircularQueue q = new CircularQueue(5);

		q.enQueue(14);
		q.enQueue(22);
		q.enQueue(13);
		q.enQueue(-6);

		q.displayQueue();

		int x = q.deQueue();

		// Checking for empty queue.
		if (x != -1)
		{
			Console.Write("Deleted value = ");
			Console.Write(x + "\n");
		}

		x = q.deQueue();

		// Checking for empty queue.
		if (x != -1)
		{
			Console.Write("Deleted value = ");
			Console.Write(x + "\n");
		}

		q.displayQueue();

		q.enQueue(9);
		q.enQueue(20);
		q.enQueue(5);

		q.displayQueue();

		q.enQueue(20);
		Console.WriteLine(Environment.NewLine + "******************* Circular Finish **************");
	}
	public static void Bst()
    {
		BST.Node root = new BST.Node(1);
		root.left = new BST.Node(2);
		root.right = new BST.Node(3);
		root.left.left = new BST.Node(4);
		root.left.right = new BST.Node(5);
		root.right.left = new BST.Node(6);
		root.right.right = new BST.Node(7);
		root.left.left.left = new BST.Node(8);
		root.left.left.left.right = new BST.Node(12);
		root.left.right.left = new BST.Node(9);
		root.right.right.left = new BST.Node(10);
		root.right.right.right = new BST.Node(11);

		// Declaring the vector function to store
		// in, post, pre order values
		List<int> pre = new List<int>();
		List<int> post = new List<int>();
		List<int> inOrder = new List<int>();

		// Calling the function;
		BST.PostPreInOrderInOneFlowRecursive(root, pre, post, inOrder);

		// Print the values of Pre order, Post order
		// and In order
		Console.Write("Pre Order : ");
		foreach (var i in pre)
		{
			Console.Write(i + " ");
		}

		Console.Write("\n");
		Console.Write("Post Order : ");
		foreach (var i in post)
		{
			Console.Write(i + " ");
		}
		Console.Write("\n");
		Console.Write("In Order : ");
		foreach (var i in inOrder)
		{
			Console.Write(i + " ");
		}
		Console.WriteLine(Environment.NewLine + "******************* BST Finish **************");
	}
	public static void fraph()
    {
		Graph g = new Graph(4);

		g.AddEdge(0, 1);
		g.AddEdge(0, 2);
		g.AddEdge(1, 2);
		g.AddEdge(2, 0);
		g.AddEdge(2, 3);
		g.AddEdge(3, 3);

		Console.WriteLine(
			"Following is Depth First Traversal "
			+ "(starting from vertex 2)");

		// Function call
		g.DFS(2);
		Console.WriteLine(Environment.NewLine + "******************* DFS Finish **************");
		Console.ReadKey();
	}
}
// C# program to print DFS traversal


