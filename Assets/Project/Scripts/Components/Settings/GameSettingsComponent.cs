using Entitas;
using Entitas.CodeGeneration.Attributes;
using Project.Scripts.Data;

namespace Assets.Project.Scripts.Components.Settings
{
    [Settings, Unique]
    public class GameSettingsComponent : IComponent
    {
        public GameSettingsData Value;
    }
}