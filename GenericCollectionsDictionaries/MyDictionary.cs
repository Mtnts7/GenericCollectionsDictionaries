using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsDictionaries
{
    class MyDictionary<Tkey,TValue>
    {
        Tkey[] _keyArray;
        TValue[] _valueArray;

        Tkey[] _tempKeyArray;
        TValue[] _tempValueArray;

        public MyDictionary()
        {
            _keyArray = new Tkey[0];
            _valueArray = new TValue[0];
        }
        
        public void Add(Tkey key, TValue value) 
        {
            _tempKeyArray = _keyArray;
            _tempValueArray = _valueArray;

            _keyArray = new Tkey[_keyArray.Length + 1];
            _valueArray = new TValue[_valueArray.Length + 1];

            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _keyArray[i] = _tempKeyArray[i];
            }

            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _valueArray[i] = _tempValueArray[i];
            }
            _keyArray[_keyArray.Length - 1]=key;
            _valueArray[_valueArray.Length - 1] = value;

        }
        public Tkey[] Mam1
        {
            get { return _keyArray; }

        }
        public TValue[] Mam2
        {
            get { return _valueArray; }

        }



    }
}
