using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node<T>
    {
        public T value;
        public Node<T> next, prev;

        public Node(T _value)
        {
            value = _value;
            next = null;
            prev = null;
        }
    }

    public class OrderedList<T>
    {
        public Node<T> head, tail;
        private bool _ascending;

        public OrderedList(bool asc)
        {
            head = null;
            tail = null;
            _ascending = asc;
        }

        
        public int Compare(T v1, T v2)
        {
            int result = 0;
            if (typeof(T) == typeof(String)) result = DeleteEdgeSpaces(v1.ToString()).CompareTo(v2.ToString());
            else
            {
                if (v1.GetType() == typeof(int) && v2.GetType() == typeof(int))
                {
                    if (Convert.ToInt32(v1) > Convert.ToInt32(v2)) result = 1;
                    else if (Convert.ToInt32(v1) < Convert.ToInt32(v2)) result = -1;
                }
            }

            return result;
        }

        public void Add(T value)
        {
            if (value == null) { return; }
            if (head == null) { head = new Node<T>(value); tail = head; return; }
            Node<T> node = head;
            Node<T> new_node = new Node<T>(value);

            int asc = 0;
            if (_ascending) asc = 1;
            else asc = -1;

            while (node != null)
            {
                if (Compare(value, node.value) == -asc)
                {
                    if (node == head)
                    {
                        new_node.next = node;
                        head = new_node;
                    }
                    else
                    {
                        node.prev.next = new_node;
                        new_node.next = node;
                        new_node.prev = node.prev;
                    }
                    node.prev = new_node;
                    return;
                }
                node = node.next;
            }
            new_node.prev = tail;
            new_node.prev.next = new_node;
            tail = new_node;
        }

        public Node<T> Find(T val)
        {
            int asc = 0;
            if (_ascending) asc = -1;
            else asc = 1;
            if (val != null)
            {
                Node<T> node = head;
                while (node != null)
                {
                    if (Compare(val, node.value) == asc) return null;
                    if (node.value.Equals(val)) return node;
                    node = node.next;
                }
            }
            return null;
        }

        public void Delete(T val)
        {
            if (head == null) return;
            Node<T> node = head;
            while (node != null)
            {
                if (node.value.Equals(val))
                {
                    if (head.next == null)
                    {
                        head = null;
                        tail = null;
                    }
                    else if (node.prev == null)
                    {
                        head = head.next;
                        node.next.prev = node.prev;
                    }
                    else if (node.next == null)
                    {
                        tail = tail.prev;
                        node.prev.next = node.next;
                    }
                    else
                    {
                        node.prev.next = node.next;
                        node.next.prev = node.prev;
                    }
                    return;
                }
                node = node.next;
            }
        }

        public void Clear(bool asc)
        {
            _ascending = asc;
            head = null;
            tail = null;
        }

        public int Count()
        {
            if (head != null)
            {
                Node<T> node = head;
                int count = 0;
                while (node != null)
                {
                    count++;
                    node = node.next;
                }
                return count;
            }
            return 0;
        }

        List<Node<T>> GetAll()
                              
        {
            List<Node<T>> r = new List<Node<T>>();
            Node<T> node = head;
            while (node != null)
            {
                r.Add(node);
                node = node.next;
            }
            return r;
        }

        private String DeleteEdgeSpaces(String str)
        {
            char[] ch = str.ToCharArray();
            char[] newChars = new char[str.Length];
            bool StopDelete = false;

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] != ' ') StopDelete = true;
                if (StopDelete) { newChars[i] = ch[i]; }
            }
            StopDelete = false;
            ch = new char[newChars.Length];
            for (int i = newChars.Length-1; i >= 0 ; i--)
            {
                if (newChars[i] != ' ') StopDelete = true;
                if (StopDelete) { ch[i] = newChars[i]; }
            }
            str = new String(ch);

            return str;
        }
    }

}