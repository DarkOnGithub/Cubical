using System;
using UnityEngine;
using World.Chunk;

namespace Renderer
{
    public static class ChunkRenderer
    {
        private static int ChunkSize = Chunk.ChunkSize.x;
        private static int ChunkSizeP = Chunk.ChunkSize.x + 2;
        public static void BuildChunkMesh(Chunk chunk)
        {
            
            GameObject gameObject = new GameObject();
            ulong[,,] axisCols = new ulong[3, ChunkSizeP, ChunkSizeP];
            ulong[,,] colFaceMasks  = new ulong[6, ChunkSizeP, ChunkSizeP];

            void AddBlockToCol(Block.Block block, int x, int y, int z, ulong[,,] axis_cols)
            {
                if (block.IsSolid)
                {
                    axisCols[0,z,x] |= 1UL << y;
                    axisCols[1,y,z] |= 1UL << x;
                    axisCols[2,y, x] |= 1UL << z;
                }
            }

            for (var z = 0; z < ChunkSize; z++)
            {
                //for(var y)
            }
        }
    }
}