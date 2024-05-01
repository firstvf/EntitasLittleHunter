using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Project.Scripts.Components
{
    [Input, Unique]
    public class LookInputComponent : IComponent
    {
        public Vector2 Value;
    }
}