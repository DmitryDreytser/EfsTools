using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1414)]
    [Attributes(9)]
    public sealed class C0Bc5RxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value
        {
            get;
        }
    }
}