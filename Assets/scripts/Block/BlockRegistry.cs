using System.Collections.Generic;
using JetBrains.Annotations;

namespace Block
{
    public static class BlockRegistry
    {
        public static Dictionary<string, Block> NameBlocks = new Dictionary<string, Block>(); 
        public static Dictionary<int, Block> IdBlocks = new Dictionary<int, Block>(); 

        public static void Registrer(Block block)
        {

            NameBlocks[block.BlockName] = block;
            IdBlocks[block.BlockId] = block;
        }

        [CanBeNull] public static Block GetBlock(int id) => IdBlocks[id];
        [CanBeNull] public static Block GetBlock(string name) => NameBlocks[name];

        static BlockRegistry()
        {
            Registrer(new Block("Air", 0).SetHardness(0f));
            Registrer(new Block("Null",1));
        }
    }
    
}