using UnityEngine;

namespace Assets.Scripts
{
    interface IObject
    {
        GameObject render();
        GameObject updateGameObject();
    }
}