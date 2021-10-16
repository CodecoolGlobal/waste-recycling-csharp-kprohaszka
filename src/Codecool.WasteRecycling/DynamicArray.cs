using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.WasteRecycling
{
    public class DynamicArray
    {
        public DynamicArray()
        {
            _array = new Garbage[1];
            _count = 0;
            _size = 1;
        }

        public Garbage[] _array { get; private set; }
        public int _count { get; private set; }
        public int _size { get; private set; }

        public void Add(Garbage data)
        {
            if (_count == _size)
            {
                Grow();
            }

            _array[_count] = data;
            _count++;
        }

        public void Clear()
        {
            _array = new Garbage[1];
            _count = 0;
            _size = 1;
        }

        public void Grow()
        {
            Garbage[] TemporaryArray = null;
            if (_count == _size)
            {
                TemporaryArray = new Garbage[_size * 2];
                {
                    _array.CopyTo(TemporaryArray, 0);
                }

                _array = TemporaryArray;

                _size = _size * 2;
            }
        }

        public void GrowWithoutBuiltInCopy()
        {
            Garbage[] TemporaryArray = null;
            if (_count == _size)
            {
                TemporaryArray = new Garbage[_size * 2];
                {
                    for (int i = 0; i < _size; i++)
                    {
                        TemporaryArray[i] = _array[i];
                    }
                }

                _array = TemporaryArray;

                _size = _size * 2;
            }
        }

        public void Shrink()
        {
            Garbage[] TemporaryArray = null;
            if(_count > 0)
            {
                TemporaryArray = new Garbage[_count];
                for (int i = 0; i < _count; i++)
                {
                    TemporaryArray[i] = _array[i];
                }

                _size = _count;

                _array = TemporaryArray;
            }
        }

        public void AddAt(int index, Garbage data)
        {
            if(_count == _size)
            {
                Grow();
            }

            for (int i = _count -1; i >= index; i--)
            {
                _array[i + 1] = _array[i];
            }

            _array[index] = data;
            _count++;
        }

        public void Remove()
        {
            if(_count > 0)
            {
                _array[_count - 1] = null;
                _count--;
            }
        }

        public void RemoveAt(int index)
        {
            if(_count > 0)
            {
                for (int i = index; i < _count -1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _array[_count - 1] = null;
                _count--;
            }
        }

    }
}
