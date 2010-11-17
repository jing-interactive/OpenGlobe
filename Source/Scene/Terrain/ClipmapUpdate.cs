﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenGlobe.Renderer;

namespace OpenGlobe.Scene.Terrain
{
    public class ClipmapUpdate
    {
        public ClipmapUpdate(int level, int west, int south, int east, int north)
        {
            _level = level;
            _west = west;
            _south = south;
            _east = east;
            _north = north;
        }

        public int Level
        {
            get { return _level; }
        }

        public int West
        {
            get { return _west; }
        }

        public int South
        {
            get { return _south; }
        }

        public int East
        {
            get { return _east; }
        }

        public int North
        {
            get { return _north; }
        }

        public int Width
        {
            get { return East - West + 1; }
        }
        
        public int Height
        {
            get { return North - South + 1; }
        }

        public Texture2D Load(Context context)
        {
            return null;
        }

        private int _level;
        private int _west;
        private int _south;
        private int _east;
        private int _north;
    }
}
