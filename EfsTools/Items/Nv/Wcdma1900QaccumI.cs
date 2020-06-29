using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4164)]
    [Attributes(9)]
    public sealed class Wcdma1900Qaccum
    {
        [FieldCount(6)]
        public ushort[] Value { get; set; }
    }
}