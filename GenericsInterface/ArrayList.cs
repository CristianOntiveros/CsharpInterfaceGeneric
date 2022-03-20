using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInterface
{
    internal class ArrayList<T> : List<T>
    {
        private static readonly int DEFAULT_SIZE = 50;
        private T[] array;
        private int size;

        public ArrayList()
        {
            array = new T[DEFAULT_SIZE];
        }

        public ArrayList(int size)
        {
            array = new T[size];
        }

        public void addAtTail(T data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }
            array[size] = data;
            size++;
        }

        public void addAtFront(T data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }

            if (size >= 0)
            {
                Array.Copy(array, 0, array, 1, size);
            }

            array[0] = data;
            size++;
        }

        public void remove(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }

            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[size - 1] = default;
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = default;
            }
            size = 0;
        }

        public void setAt(int index, T data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        /**
         * @param index 0-index
         * @return element at position index
         */

        public T getAt(int index)
        {
            if (index >= 0 && index < size)
            {
                return array[index];
            }
            else
            {
                return default;
            }
        }

        public Iterator<T> getIterator()
        {
            return new ArrayListIterator<T>(this);
        }

        public int getSize()
        {
            return size;
        }

        private void increaseArraySize()
        {
            T[] newArray = new T[array.Length * 2];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

    }
}


