using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6282)]
    [Attributes(9)]
    public sealed class Bc7IntelliceiverRcTuneCal
    {
        [FieldCount(2)]
        public ushort[] Value
        {
            get;
        }
    }
}