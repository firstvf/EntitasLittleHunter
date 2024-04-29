using UnityEngine;

public interface IInputService 
{
    public Vector2 GetMovement { get; }
    public Vector2 GetLook { get; }
    public void Dispose();
}