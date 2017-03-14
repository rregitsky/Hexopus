using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine

namespace Assets.Scripts
{
    class MapPieceObject
    {
        /**
         * @var Width of the map piece wall
         */
        public int wallWidth = 0;
        /**
         * @var Angle of the wall in Radians
         */
        public float wallAngleRadians = 0;
        /**
         * @var Angle of the wall in Degrees
         */
        public float wallAngleDegress
        {
            get
            {
                return wallAngleRadians * Mathf.Rad2Deg;
            }
            set
            {
                wallAngleRadians = value;
            }
        }
        private MapObject next;
        private MapObject previous;

        public MapPieceObject(MapObject next, MapObject previous)
        {

        }
        public MapPieceObject(int width, int angle, MapObject next, MapObject previous)
        {

        }
    }
}
