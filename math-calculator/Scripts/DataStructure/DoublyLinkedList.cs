using System;

namespace DataStructure
{
	public class DoublyLinkedList<T>
	{
		private DoublyNode<T>? head = null;
		private DoublyNode<T>? tail = null;
		private int count = 0;

		public void Add(T data)
		{
			DoublyNode<T> doublyNode = new DoublyNode<T>(data);

			if (head == null)
			{
				head = doublyNode;
			}
			else
			{
				tail!.Next = doublyNode;
				doublyNode.Previous = tail;
			}
			tail = doublyNode;

			count++;
		}

		public void AddFirst(T data)
		{
			DoublyNode<T> doublyNode = new DoublyNode<T>(data);
			DoublyNode<T>? temp = head;

			doublyNode.Next = temp;
			head = doublyNode;

			if (count == 0)
				tail = head;
			else
				temp!.Previous = head;

			count++;
		}

        public bool Remove(int data)
		{

			return false;
		}

		private int Count { get { return count; } }
		private bool IsEmpty { get { return count == 0; } }
	}

	internal class DoublyNode<T>
	{
		public T Data { get; set; }
		public DoublyNode<T> Previous { get; set; }
		public DoublyNode<T> Next { get; set; }

		public DoublyNode(T data)
		{
			Data = data;
		}
	}
}

