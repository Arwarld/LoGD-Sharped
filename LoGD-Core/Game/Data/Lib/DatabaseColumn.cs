#region

using System;

#endregion

namespace LoGD.Core.Game.Data.Lib
{
    internal sealed class DatabaseColumn
    {
        internal DatabaseColumn(string name, Type dataType, string length, bool notnull, string defaultValue,
            string extra = "")
        {
            Name = name;
            DataType = dataType;
            Length = length;
            NotNull = notnull;
            DefaultValue = defaultValue;
            Extra = extra;
        }

        internal Type DataType { get; }
        internal string Extra { get; }
        internal string Length { get; }
        internal string Name { get; }
        internal bool NotNull { get; }
        internal string DefaultValue { get; }
    }
}
