using UnityEngine;
using World.Chunk;

namespace Util
{
    public class Utils
    {
        public static int XY = Chunk.ChunkSize.y * Chunk.ChunkSize.z;
        
        public static int PositionToIndex(Vector3Int vector)
        {
            return vector.z * XY + vector.y * Chunk.ChunkSize.x + vector.x;
        }
        
        public static int PositionToIndex(int x, int y, int z)
        {
            return z * XY + y * Chunk.ChunkSize.x + x;
        }
    }
}