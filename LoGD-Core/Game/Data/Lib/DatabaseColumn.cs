#region

using System;

#endregion

namespace LoGD.Core.Game.Data.Lib
{
    internal sealed class DatabaseColumn
    {
        internal DatabaseColumn(string name, Type dataType, string length, bool signLess, bool notnull,
            string defaultValue)
        {
            Name = name;
            DataType = dataType;
            Length = length;
            SignLess = signLess;
            NotNull = notnull;
            DefaultValue = defaultValue;
        }

        internal string Name { get; }
        private Type DataType { get; }
        private string Length { get; }
        private bool SignLess { get; }
        private bool NotNull { get; }
        private string DefaultValue { get; }
    }
}
