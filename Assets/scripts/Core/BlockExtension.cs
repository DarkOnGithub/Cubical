using System;
using UnityEngine;
using UnityEngine.UIElements;
using World.Chunk;

namespace Core
{
    public static class BlockExtension  
    {
        public static int XY = Chunk.ChunkSize.y * Chunk.ChunkSize.z;
        public static int X = Chunk.ChunkSize.x;
        public static int Y = Chunk.ChunkSize.y;
        public static int Z = Chunk.ChunkSize.z;
        public static UInt16 ToInt16(this Vector3Int vector3)
        {
            return (UInt16)(vector3.z * XY + vector3.y * X + vector3.x);
        }
        
        public static Vector3Int ToVector3(this UInt16 index)
        {
            return new Vector3Int(index % X,(index / X) % Y,index / XY);
        }

    }
}