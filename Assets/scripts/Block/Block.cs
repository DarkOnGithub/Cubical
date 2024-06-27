using System.Collections;
using System.Collections.Generic;
using Assets.scripts.Block;
using Unity.VisualScripting;
using UnityEngine;

public class Block
{
    public BlockMaterial BlockMaterial;
    public Block(BlockMaterial blockMaterial)
    {
        this.BlockMaterial = blockMaterial;
    }

}
