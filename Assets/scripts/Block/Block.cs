using System;

namespace Block
{

    public class Block
    {       
        public string BlockName;
        public ushort BlockId;
        
        public BlockMaterial BlockMaterial;
        public float Hardness = 10f;
        public bool HasGravity = false;
        public bool IsTransparent = false;
        public bool CanCollide = true;
        public bool IsSolid = true;
        public Block(string blockName, ushort blockId)
        {
            BlockName = blockName;
            BlockId = blockId;
        }
        
        public T ConvertState<T>(byte state) where T : class 
        {
            return null;
        }
        public Block SetCollision(bool canCollide)
        {
            CanCollide = canCollide;
            return this;
        }
        public Block SetSolidity(bool isSolid)
        {
            IsSolid = isSolid;
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
