using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class TwoTypePamameter<T,V>
    {
        private T tFirstObject;

        public T TFirsetObject
        {
            get { return tFirstObject; }
            set { tFirstObject = value; }
        }

        private V vSecondObject;

        public V VSecondObject
        {
            get { return vSecondObject; }
            set { vSecondObject = value; }
        }
        public override string ToString()
        {
            return $"Type of First Object{typeof(T)} and Type of Second Object {typeof(V)}";
        }
    }
}
