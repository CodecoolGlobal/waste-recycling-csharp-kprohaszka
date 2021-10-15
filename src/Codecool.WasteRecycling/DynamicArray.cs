using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.WasteRecycling
{
    class DynamicArray
    {

        private int[] _array;
        private int _count;
        private int _size;

        public DynamicArray(int[] array, int count, int size)
        {
            _array = array;
            _count = count;
            _size = size;
        }

        public void Add(int data)
        {
            if (_count == _size)
            {
                Grow();
            }

            _array[_count] = data;
            _count++;
        }

        public void Grow()
        {
            int[] TemporaryArray = null;
            if (_count == _size)
            {
                TemporaryArray = new int[_size * 2];
                {
                    _array.CopyTo(TemporaryArray, 0);
                }

                _array = TemporaryArray;

                _size = _size * 2;
            }
        }

        public void GrowWithoutBuiltInCopy()
        {
            int[] TemporaryArray = null;
            if (_count == _size)
            {
                TemporaryArray = new int[_size * 2];
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
            int[] TemporaryArray = null;
            if(_count > 0)
            {
                TemporaryArray = new int[_count];
                for (int i = 0; i < _count; i++)
                {
                    TemporaryArray[i] = _array[i];
                }

                _size = _count;

                _array = TemporaryArray;
            }
        }

        public void AddAt(int index, int data)
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
                _array[_count - 1] = 0;
                _count--;
            }
        }

        public void RemoveAt(int index)
        {
            if(_count > 0)
            {
                for (int i = index; i < _count; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _array[_count - 1] = 0;
                _count--;
            }
        }

    }
}
