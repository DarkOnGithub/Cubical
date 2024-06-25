using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.scripts.Block
{
    public sealed class BlockMaterial
    {
        public static Dictionary<string, BlockMaterial> Materials = new Dictionary<string, BlockMaterial>();
        public static Dictionary<string, Texture2D> TextureCache = new Dictionary<string, Texture2D>()
        {
            {"null",(Texture2D)Resources.Load("null") }
        };

        public static BlockMaterial GetMaterial(string materialName)
        {
            return Materials[materialName] ?? new BlockMaterial(materialName);
        }

        public static Texture2D LoadTexture(string imagePath)
        {
            if(TextureCache.ContainsKey(imagePath)) return TextureCache[imagePath];
            if(File.Exists(imagePath))
            {
                Texture2D Texture = new Texture2D(0,0);
                Texture.LoadImage(File.ReadAllBytes(imagePath));
                return Texture;
            }
            return TextureCache["null"];
        }

        public string materialName;
        public string defaultTexturePath;
        Dictionary<Faces,Texture2D> facesTexture;
        public BlockMaterial(string materialName)
        {
            Materials[materialName] = this;
            this.materialName = materialName;
        }

        BlockMaterial SetDefault(string defaultTexturePath)
        {
            this.defaultTexturePath = defaultTexturePath;
            return this;
        }

        BlockMaterial SetFacesTexture(Dictionary<Faces, string> faces)
        {
            foreach(var face in faces)
            {
                this.SetFaceTexture(face.Key, face.Value);
            }
            return this;
        }

        void SetFaceTexture(Faces face, string texture)
        {
            this.facesTexture[face] = LoadTexture(texture);
        }
        
        Texture2D GetFaceTexture(Faces faces)
        {
            return this.facesTexture[faces];
        }
    }
}