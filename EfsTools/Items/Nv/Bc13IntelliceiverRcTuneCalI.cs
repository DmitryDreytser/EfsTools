using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6288)]
    [Attributes(9)]
    public sealed class Bc13IntelliceiverRcTuneCal
    {
        [FieldCount(2)]
        public ushort[] Value
        {
            get;
        }
    }
}