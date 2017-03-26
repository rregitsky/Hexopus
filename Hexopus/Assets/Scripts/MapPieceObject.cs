 /// <summary>
 /// A Spring-Loaded Map Wall Piece connected to adjacent Map Wall Pieces
 /// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class MapPieceObject : Object
    {

        private const float DefaultWidth = 1.5f;
        private const float DefaultAngle = 0;
         /// <summary>
         /// Position of the head of the map piece. Head is the side closest to the end of the level.
         /// </summary>
        public Position headPosition
        {
            get
            {
                float x = position.x + (width / 2) * Mathf.Cos(this.angleRadians);
                float y = position.y + (width / 2) * Mathf.Sin(this.angleRadians);
                return new Position(x,y);
            }
        }
         /// <summary>
         /// Position of the tail of the map piece. Tail is the side closest to the beginning of the level. (Read-only)
         /// </summary>
        public Position tailPosition
        {
            get
            {
                float x = position.x - (width / 2) * Mathf.Cos(this.angleRadians);
                float y = position.y - (width / 2) * Mathf.Sin(this.angleRadians);
                return new Position(x, y);
            }
        }
        /// <summary>
        /// The neighboring Map Object attached to the head position of this Map Object
        /// </summary>
        private MapObject next;
        /// <summary>
        /// The neighboring Map Object attached to the tail position of this Map Object
        /// </summary>
        private MapObject previous;
        /// <summary>
        /// The Game Object of this Map Object
        /// </summary>
        private GameObject gameObject;

        public MapPieceObject(float width = MapPieceObject.DefaultWidth, float angleRadians = MapPieceObject.DefaultAngle) : this(null, null, width, angleRadians)
        {
            this.width = width;
            this.angleRadians = angleRadians;
        }
        public MapPieceObject(
            MapObject next, 
            MapObject previous, 
            float width = MapPieceObject.DefaultWidth, 
            float angleRadians = MapPieceObject.DefaultAngle
            ) : this(null, next, previous, width, angleRadians)
        {
            this.next = next;
            this.previous = previous;
        }

        public MapPieceObject(
            Position position,
            MapObject next = null, 
            MapObject previous = null,
            float width = MapPieceObject.DefaultWidth, 
            float angleRadians = MapPieceObject.DefaultAngle
            )
        {
            this.position = position ?? new Position(0, 0);
        }

        /// <summary>
        /// Set up the Game Object for this element
        /// </summary>
        /// <returns>This Object's Game Object</returns>
        public override GameObject render()
        {
            this.gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            this.updateGameObject();
            return this.gameObject;
        }
        /// <summary>
        /// Update the prpoerties of the game object for this element to match this object's properties.
        /// </summary>
        /// <returns></returns>
        public override GameObject updateGameObject()
        {
            this.gameObject.transform.position = this.position.ToVector2();
            this.gameObject.transform.rotation = Quaternion.Euler(0, 0, this.angleDegrees);
            this.gameObject.transform.localScale = new Vector3(this.width, 0);
            return this.gameObject;
        }
    }
}
