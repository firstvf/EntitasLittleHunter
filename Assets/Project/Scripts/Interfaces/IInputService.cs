using UnityEngine;

namespace Project.Scripts.Interfaces
{
    public interface IInputService 
    {
        public Vector2 GetMovement { get; }
        public Vector2 GetLook { get; }
        public void Dispose();
    }
}