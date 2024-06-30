
using System;
using UnityEngine;
using Block;
using Core;

namespace World.Chunk
{
    public sealed class Chunk
    {
        public static Vector3Int ChunkSize = new Vector3Int(16,256,16);

        public Vector2Int Origin;
        private UInt16[] _blocks;     
        private byte[] _states;     

        public Chunk(Vector2Int origin)
        {
            
            Origin = origin;
            _blocks = new UInt16[ChunkSize.x * ChunkSize.y * ChunkSize.z];
        }

        public void AddBlock(Block.Block.BlockState state, Vector3Int position)
        {
            UInt16 index = position.ToInt16();
            if (index < 0 || index >= UInt16.MaxValue)
            {
                throw new IndexOutOfRangeException($"{position.ToString()} out of chunk bound");
            }

            if (_blocks[index] != 0) throw new ArgumentException($"There is already a block at: {position.ToString()}");
            _blocks[index] = (ushort)state.Block.BlockId;
            _states[index] = state.State;
        }

    }
}