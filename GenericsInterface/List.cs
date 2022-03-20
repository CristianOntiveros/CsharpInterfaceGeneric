using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInterface
{
    internal interface List<T>
    {

        void addAtTail(T data);

        void addAtFront(T data);

        void remove(int index);

        void removeAll();

        void setAt(int index, T data);

        T getAt(int index);

        Iterator<T> getIterator();

        int getSize();
    }
}
