using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(679)]
    [Attributes(9)]
    public sealed class CdmaDaccQaccum4
    {
        public byte Value { get; set; }
    }
}