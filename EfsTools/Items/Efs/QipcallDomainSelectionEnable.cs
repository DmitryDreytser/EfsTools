using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/ims/qipcall_domain_selection_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallDomainSelectionEnable
    {
        public byte Value { get; set; }
    }
}