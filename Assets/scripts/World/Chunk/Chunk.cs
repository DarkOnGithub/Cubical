
using UnityEngine;
using Block;
namespace World.Chunk
{
    public sealed class Chunk
    {
        public static Vector3Int ChunkSize = new Vector3Int(16,256,16);

        public Vector2Int Origin;
        private int[] _blocks;     
        
        public Chunk(Vector2Int origin)
        {
            Origin = origin;
            _blocks = new int[ChunkSize.x * ChunkSize.y * ChunkSize.z];
        }

        public void AddBlock(Block.Block block)
        {
            
        }

    }
}