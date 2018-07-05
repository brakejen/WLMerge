using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLMerge
{
    public enum TransformValueOperation
    {
        Multiply = 0,
        Add = 1,
        Subtract = 2,
    }

    public class ValueTransformer
    {
        private Type _type;
        private string _transformValueAsString;
        TransformValueOperation _operation;

        public ValueTransformer(Type type, string transformValue, TransformValueOperation operation)
        {
            _type = type;
            _transformValueAsString = transformValue;
            _operation = operation;
        }

        public object Transform(object value)
        {
            if (_type == typeof(string))
            {
                if (_operation == TransformValueOperation.Add)
                {
                    return ($"{value}{_transformValueAsString}");
                }
                else
                {
                    return value;
                }
            }
            else if (_type == typeof(int))
            {
                switch (_operation)
                {
                    case TransformValueOperation.Multiply:
                        return (int)value * int.Parse(_transformValueAsString);
                    case TransformValueOperation.Add:
                        return (int)value + int.Parse(_transformValueAsString);
                    case TransformValueOperation.Subtract:
                        return (int)value - int.Parse(_transformValueAsString);
                    default:
                        throw new ArgumentException("ValueTransformer.Transform");

                }
            }
            else if (_type == typeof(decimal))
            {
                switch (_operation)
                {
                    case TransformValueOperation.Multiply:
                        return (decimal)value * decimal.Parse(_transformValueAsString);
                    case TransformValueOperation.Add:
                        return (decimal)value + decimal.Parse(_transformValueAsString);
                    case TransformValueOperation.Subtract:
                        return (decimal)value - decimal.Parse(_transformValueAsString);
                    default:
                        throw new ArgumentException("ValueTransformer.Transform");

                }
            }

            return null;
        }
    }
}
