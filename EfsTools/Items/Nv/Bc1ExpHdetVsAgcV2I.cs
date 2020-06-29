using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5723)]
    [Attributes(9)]
    public sealed class Bc1ExpHdetVsAgcV2
    {
        [FieldCount(16)]
        public ushort[] Value
        {
            get;
        }
    }
}