public class GameSystem : Feature
{
    public GameSystem(Contexts contexts)
    {
        Add(new CreateEntitySystem(contexts));
        Add(new EmitInputSystem(contexts, new UnityInputServiceImplementation()));
    }
}