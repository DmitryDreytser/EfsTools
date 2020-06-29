using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/ims/qipcall_enable_hd_voice", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallEnableHdVoice
    {
        public byte Value { get; set; }
    }
}