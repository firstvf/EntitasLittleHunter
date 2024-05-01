using Entitas;

namespace Project.Scripts.Systems
{
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
}
