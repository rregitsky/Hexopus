using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class Position
    {
        /**
         * @var X position
         */
        public float x = 0;
        /**
         * @var Y position
         */
        public float y = 0;

        public Position(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2 ToVector2()
        {
            return new Vector2(this.x, this.y);
        }
    }
}
