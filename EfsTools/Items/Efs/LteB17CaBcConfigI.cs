using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025224", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB17CaBcConfig : LteBandsConfigBase
    {
    }
}