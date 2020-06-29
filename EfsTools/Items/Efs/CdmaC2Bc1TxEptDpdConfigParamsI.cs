using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Items.Data;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024151", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxEptDpdConfigParams
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }
}