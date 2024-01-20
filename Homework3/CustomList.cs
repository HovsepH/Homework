using System.Collections;
using System.Collections.Generic;


namespace Homework3
{
    class CustomList<T> : IList<T>
    {
        private T[] _arr = new T[0];

        private int _index = -1;
        public int Capacity
        {
            get;
            private set;
        }

        public int Count => _index + 1;

        public bool IsReadOnly => false;
        public void Add(T item)
        {
            CheckCapacity();
            ElementAdded_Event?.Invoke(this, new CustomEventArgs(item?.ToString()));
            _arr[++_index] = item;
        }

        public void Clear()
        {
            _arr = new T[0];
            _index = -1;
            Capacity = 0;
        }

        public bool Contains(T item)
        {
            return _arr.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _arr.CopyTo(array, arrayIndex);
        }

        public T this[int index]
        {
            get
            {
                if (CheckIndex(index))
                {
                    return _arr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (CheckIndex(index))
                {
                    _arr[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }



        public int IndexOf(T item)
        {
            if (Count == 0)
                return -1;
            for (int i = 0; i <= _index; i++)
            {
                if (_arr[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }


        public void Insert(int index, T item)
        {
            if (CheckIndex(index))
            {
                CheckCapacity();
                _index++;
                for (int i = _index + 1; i > index; i--)
                {
                    _arr[i] = _arr[i - 1];
                }
                _arr[index] = item;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public bool Remove(T item)
        {
            if (Count == 0)
                throw new InvalidOperationException();

            bool t = false;

            for (int i = 0; i <= _index; i++)
            {
                if (_arr[i].Equals(item))
                {
                    t = true;
                    RemoveAt(i);

                    break;
                }
            }
            return t;
        }

        public void RemoveAt(int index)
        {
            if (CheckIndex(index))
            {
                for (int j = index; j <= _index; j++)
                {
                    if (CheckIndex(j + 1))
                    {
                        _arr[j] = _arr[j + 1];
                    }
                }
                _index--;
            }
            else
            {
                throw new InvalidOperationException();
            }
            ElementRemoved_Event?.Invoke(this, new CustomEventArgs(index.ToString()));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void CheckCapacity()
        {
            if (Capacity == _index + 1)
            {
                if (Capacity == 0)
                    Capacity = 5;
                else
                    Capacity *= 2;
                Array.Resize(ref _arr, Capacity);
            }
        }

        private bool CheckIndex(int index) => (index >= 0 && index <= _index);

        public event EventHandler<CustomEventArgs> ElementAdded_Event;

        public event EventHandler<CustomEventArgs> ElementRemoved_Event;

    }

}

