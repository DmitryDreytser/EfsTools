using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2759)]
    [Attributes(9)]
    public sealed class DcsAmamArfcnF1
    {
        public ushort Value { get; set; }
    }
}