using UnityEngine;

namespace Assets.Scripts
{
    abstract class Object
    {
        /// <summary>
        /// Angle of the object in Radians
        /// </summary>
        public float angleRadians = 0;
        /// <summary>
        /// Angle of the object in Degrees
        /// </summary>
        public float angleDegrees
        {
            get
            {
                return angleRadians * Mathf.Rad2Deg;
            }
            set
            {
                angleRadians = value;
            }
        }
        /// <summary>
        /// Width of the object
        /// </summary>
        public float width = 0;
        /// <summary>
        /// Height of the object
        /// </summary>
        public float Height = 0;
        /// <summary>
        /// Position of the center of the object
        /// </summary>
        public Position position;
        public abstract GameObject render();
        public abstract GameObject updateGameObject();
    }
}