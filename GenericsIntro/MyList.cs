using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{//T type den geliyor..
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            //constructor class ismi ile aynı otomatik çalışır ilk başla 
            items = new T[0];//Sıfır elemanlı bir dizi oluşturdukk nerde çağırırsak çağıralım ilk başta çalışan kod..
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i]= tempArray[i];
            }
            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
