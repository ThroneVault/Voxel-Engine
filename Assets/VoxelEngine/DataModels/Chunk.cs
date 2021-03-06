﻿using System.Collections.Generic;
using UnityEngine;

namespace VoxelEngine
{
    /// <summary>
    /// Data representation of a mesh, a chunk is always in the scale of 1,1,1
    /// </summary>
    public class Chunk
    {
        public List<Vector3> vertices = new List<Vector3>();
        public List<int> triangles = new List<int>();
    }
}