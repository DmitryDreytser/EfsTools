using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5722)]
    [Attributes(9)]
    public sealed class Bc0ExpHdetVsAgcV2
    {
        [FieldCount(16)]
        public ushort[] Value
        {
            get;
        }
    }
}