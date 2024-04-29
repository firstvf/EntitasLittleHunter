using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class CreateEntitySystem : IInitializeSystem
{
    private readonly Contexts _contexts;

    public CreateEntitySystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        _contexts.game.CreateEntity();
            
    }
}
