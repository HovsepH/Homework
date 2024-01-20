using System.Collections;

namespace Homework3
{
    class MyEnumerator<T> : IEnumerator<T>
    {
        private CustomList<T> _list;

        private int _index;
        public MyEnumerator(CustomList<T> list)
        {
            _list = list;
            _index = -1;
        }
        public T Current => _list[_index];

        object IEnumerator.Current => _list[_index];

        public bool MoveNext()
        {
            bool b = (++_index < _list.Count) ? true : false;
            return b;
        }

        public void Reset()
        {
            _index = -1;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

    }
}
