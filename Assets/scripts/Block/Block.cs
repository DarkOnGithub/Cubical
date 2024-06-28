using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Block
{
    public class Block
    {
        public string BlockName;
        public int BlockId;
        
        public BlockMaterial BlockMaterial;
        public float Hardness = 10f;
        public bool HasGravity = false;
        public bool IsTransparent = false;
        public bool CanCollide = true;
        
        public Block(string blockName, int blockId)
        {
            BlockName = blockName;
            BlockId = blockId;
        }

        public Block SetCollidable(bool canCollide)
        {
            CanCollide = canCollide;
            return this;
        }
        public Block SetMaterial(BlockMaterial blockMaterial)
        {
            BlockMaterial = blockMaterial;
            return this;
        }

        public Block SetHardness(float hardness)
        {
            Hardness = hardness;
            return this;
        }

        public Block SetGravity(bool hasGravity)
        {
            HasGravity = hasGravity;
            return this;
        }
        
    }

}
