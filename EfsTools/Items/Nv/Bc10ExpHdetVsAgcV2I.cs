using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5732)]
    [Attributes(9)]
    public sealed class Bc10ExpHdetVsAgcV2
    {
        [FieldCount(16)]
        public ushort[] Value
        {
            get;
        }
    }
}