using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<Key, Value>
    {
        Key[] _keys;
        Value[] _values;
        public MyDictionary()
        {
            _keys = new Key[0];
            _values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] tempKeys = _keys;
            Value[] tempValues = _values;

            _keys = new Key[_keys.Length + 1];
            _values = new Value[_values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                tempKeys[i] = _keys[i];
                tempValues[i] = _values[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }
    }
}
