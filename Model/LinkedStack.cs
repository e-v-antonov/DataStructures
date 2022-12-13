using System;

namespace DataStructures.Model
{
    public class LinkedStack<T>
    {
        public ItemStack<T> Head { get; set; }

        public int Count { get; set; }

        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }

        public LinkedStack(T data)
        {
            Head = new ItemStack<T>(data);
            Count = 1;
        }

        /// <summary>
        /// Запись в стек
        /// </summary>
        /// <param name="data"></param>
        public void Push (T data)
        {
            var item = new ItemStack<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }

        /// <summary>
        /// Взятие из стека
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public T Pop()
        {
            if (Count > 0)
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст.");
            }
        }

        /// <summary>
        /// Просмотр стека
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public T Peek()
        {
            if (Count > 0)
            {
                return Head.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст.");
            }
        }
    }
}
