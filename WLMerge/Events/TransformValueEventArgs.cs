using System;

namespace WLMerge
{
    public class TransformValueEventArgs : EventArgs
    {
        private ValueTransformer _transformer;

        public TransformValueEventArgs(ValueTransformer transformer)
        {
            _transformer = transformer;
        }

        public ValueTransformer Transformer { get { return _transformer; } }
    }
}
