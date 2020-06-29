using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4197)]
    [Attributes(9)]
    public sealed class Wcdma800DrxModeSel
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}