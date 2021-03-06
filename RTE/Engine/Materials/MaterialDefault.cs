﻿using OpenTK.Graphics;
using RTE.Engine.MaterialRenderers;

namespace RTE.Engine.Materials
{
    class MaterialDefault : Material
    {
        public readonly Texture Diffuse;
        public readonly Color4 Specular;
        public readonly float Shininess;

        public MaterialDefault(
            string name,
            Texture diffuse,
            Color4 specular,
            float shininess = 16.0f
            )
            : base(name)
        {
            Diffuse = diffuse;
            Specular = specular;
            Shininess = shininess;
        }

        private DefaultRenderer renderer;
        public override MaterialRenderer Renderer
        {
            get => renderer ?? (renderer = new DefaultRenderer(this));
        }
    }
}
