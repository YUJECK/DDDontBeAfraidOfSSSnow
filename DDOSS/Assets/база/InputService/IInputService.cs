using System;
using UnityEngine;

namespace база.InputServices
{
    public interface IInputService
    {
        event Action<Vector2> OnMoved;
    }
}