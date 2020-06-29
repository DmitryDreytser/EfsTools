using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3281)]
    [Attributes(9)]
    public sealed class C0Bc5LnaSwitchpointsLpm2
    {
        [FieldCount(8)]
        public sbyte[] Value
        {
            get;
        }
    }
}