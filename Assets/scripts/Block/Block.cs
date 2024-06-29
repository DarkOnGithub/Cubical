using System;

namespace Block
{

    public class Block
    {

        public struct BlockState
        {
            public Block Block;
            public byte State;
            public override string ToString()
            {
                return $"Cubical: {Block.BlockName}";
            }

            public void StateProperties(byte state)
            {
                
            }
            public BlockState(Block block, byte state)
            {
                Block = block;
                State = state;
            }   
            
        }
        
        public string BlockName;
        public int BlockId;
        
        public BlockMaterial BlockMaterial;
        public float Hardness = 10f;
        public bool HasGravity = false;
        public bool IsTransparent = false;
        public bool CanCollide = true;
        public bool ImmutableState = true;
        public Func<byte, BlockState> State;
        public Block(string blockName, int blockId)
        {
            BlockName = blockName;
            BlockId = blockId;
            if (ImmutableState)
            {
                BlockState s = new BlockState(this, 0);
                State = state => s;
            }
            else
            {
                State = state => new BlockState(this, state);
            } 
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
