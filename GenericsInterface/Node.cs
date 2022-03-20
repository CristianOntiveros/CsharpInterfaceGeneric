using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInterface
{
    class Node<T>
    {//  -> Las clases solo pueden ser públicas o package-private
        internal T data;
        internal Node<T> next;
        internal Node<T> previous;

        internal Node(T data)
        {
            this.data = data;
        }
    }
}
