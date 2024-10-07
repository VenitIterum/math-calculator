using System;
using System.Collections;

namespace DataStructure
{
	public class LinkedList<T> : IEnumerable
    {
		private Node<T>? head;
		private Node<T>? tail;
		private int count = 0;

		public void Add(T data)
		{
			Node<T> node = new Node<T>(data);

			if (head == null) head = node;
			else tail!.Next = node;
			tail = node;

			count++;
		}

		public bool Remove(T data)
		{
			Node<T>? current = head;
			Node<T>? previous = null;

			while (current != null && current.Data != null)
			{
				if (current.Data.Equals(data))
				{
					if (previous != null)
					{
						previous.Next = current.Next;

						if (current.Next == null) tail = previous;
					}
					else
					{
						head = head?.Next;
						if (head == null) tail = null;
					}

					count--;
					return true;
				}

				previous = current;
				current = current.Next;
			}

			return false;
		}

		public int Count { get { return count; } }
		public bool IsEmpty { get { return count == 0; } }

		public void Clear()
		{
			head = null;
			tail = null;
			count = 0;
		}

		public bool Contains(T data)
		{
			Node<T>? current = head;

			while (current != null && current.Data != null)
			{
				if (current.Data.Equals(data)) return true;
				current = current.Next;
			}

			return false;
		}

		public void AddFirst(T data)
		{
			Node<T> node = new Node<T>(data);

			node.Next = head;
			head = node;
			if (count == 0) tail = head;

			count++;
		}

		public IEnumerator GetEnumerator()
		{
			Node<T>? current = head;

			while (current != null)
			{
				yield return current.Data;
				current = current.Next;
			}
		}
    }

	internal class Node<T>
	{
		public T Data { get; set; }
		public Node<T> Next { get; set; }

		public Node(T data)
		{
			Data = data;
		}
	}
}

