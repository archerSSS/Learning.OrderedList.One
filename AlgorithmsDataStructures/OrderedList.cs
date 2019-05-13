﻿using System;
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


        // Доработать сравнение строк
        //
        public int Compare(T v1, T v2)
        {
            int result = 0;
            if (typeof(T) == typeof(String))
            {
                char[] a1 = v1.ToString().ToCharArray();
                char[] a2 = v2.ToString().ToCharArray();
                for (int i = 0; i <= (a1.Length > a2.Length ? a1.Length : a2.Length); i++)
                {
                    if (i >= a2.Length) return 1;
                    else if (i >= a1.Length) return -1;
                    if (a1[i] > a2[i]) return 1;
                    else if (a1[i] < a2[i]) return -1;
                }
                // версия для лексикографического сравнения строк
            }
            else
            {
                int n1 = 0;
                int n2 = 0;
                if (v1.GetType() == typeof(int) && v2.GetType() == typeof(int))
                {
                    n1 = Convert.ToInt32(v1);
                    n2 = Convert.ToInt32(v2);
                    if (n1 > n2) result = 1;
                    else if (n1 < n2) result = -1;
                }
                // универсальное сравнение
            }

            return result;
            // -1 если v1 < v2
            // 0 если v1 == v2
            // +1 если v1 > v2
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
                    if (node.prev == null)
                    {
                        new_node.next = node;
                        node.prev = new_node;
                        head = new_node;
                    }
                    else
                    {
                        node.prev.next = new_node;
                        new_node.next = node;
                        new_node.prev = node.prev;
                        node.prev = new_node;
                    }
                    return;
                }
                node = node.next;
            }
            new_node.prev = tail;
            new_node.prev.next = new_node;
            tail = new_node;
            // автоматическая вставка value 
            //в нужную позицию
        }

        public Node<T> Find(T val)
        {
            if (val != null)
            {
                Node<T> node = head;
                while (node != null)
                {
                    if (node.value.Equals(val)) return node;
                    node = node.next;
                }
            }
            return null; // здесь будет ваш код
        }

        public void Delete(T val)
        {
            if (head == null) return;
            Node<T> node = head;
            while (node != null)
            {
                if (node.value.Equals(val))
                {
                    if (node == head && node == tail)
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
                }
                node = node.next;
            }

            // здесь будет ваш код
        }

        public void Clear(bool asc)
        {
            _ascending = asc;
            head = null;
            tail = null;
            // здесь будет ваш код
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
            return 0; // здесь будет ваш код подсчёта количества элементов в списке
        }

        List<Node<T>> GetAll() // выдать все элементы упорядоченного 
                               // списка в виде стандартного списка
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
    }

}