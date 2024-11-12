using System.Collections;

namespace OOP.Interface.IEnumerableApp
{
    internal class ArrayEnumerator : IEnumerator
    {
        private int[] InnerList;
        private int index;
        public object Current => InnerList[index];
        public ArrayEnumerator(int[] arr)
        {
            InnerList = arr;
            //index = -1;
            index = InnerList.Length;
        }
        public bool MoveNext()
        {
            if (index == InnerList.Length)
            {
                index--;
                return true;
            }
            if (index > 0) 
            {
                index--;
                return true;
            }
            else
            {
                index = InnerList.Length;
                return false;
            }
        }

        public void Reset()
        {
            index = InnerList.Length;
        }
    }
}