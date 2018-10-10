using System;

namespace WLMerge
{
    /// <summary>
    /// Represents the supported types of value transformations
    /// </summary>
    public enum TransformValueOperation
    {
        Multiply = 0,
        Add = 1,
        Subtract = 2,
    }

    /// <summary>
    /// Implements a simple and customized value transformer. Given a type, a value and an operation, 
    /// it can transform given value according to this, using method Transform(object)
    /// </summary>
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

        /// <summary>
        /// Transform the given value according to predetermined rules
        /// - strings only supports add and means contatenation. Other operations will return given value unaffected
        /// - integers and decimals supports all transformations
        /// - Value given is not type checked, the ValueTransformer is supposed to have been created with correct type to work with
        /// - All other types the ValueTransformer have been created with, this method will return null regardless of given value
        /// </summary>
        /// <param name="value">The value to transform</param>
        /// <returns></returns>
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
