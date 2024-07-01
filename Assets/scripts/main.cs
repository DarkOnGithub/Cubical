using System;
using System.Collections;
using System.Collections.Generic;
using Block;
using UnityEngine;
using World.Chunk;

public class main : MonoBehaviour
{
    public void Start()
    {
        var c = new Chunk(new Vector2Int(0,0));
        c.AddBlock(BlockRegistry.GetBlock(0),new Vector3Int(0,0,0));
    }
}
