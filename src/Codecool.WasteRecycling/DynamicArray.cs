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

        public void add(int data)
        {
            if(_count == _size)
            {
                grow();
            }

            _array[_count] = data;
            _count++;
        }

        public void grow()
        {
            int[] TemporaryArray = null;
            if(_count == _size)
            {
                TemporaryArray = new int[_size * 2];
                {
                    _array.CopyTo(TemporaryArray, 0);
                }

                _array = TemporaryArray;

                _size = _size * 2;
            }


        }
    }
}
