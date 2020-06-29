using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1391)]
    [Attributes(9)]
    public sealed class Bc5TxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value
        {
            get;
        }
    }
}