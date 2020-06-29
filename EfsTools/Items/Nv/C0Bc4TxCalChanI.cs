using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1491)]
    [Attributes(9)]
    public sealed class C0Bc4TxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value
        {
            get;
        }
    }
}