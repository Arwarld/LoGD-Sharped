using LoGD.Core.Game;
using LoGD.Core.Game.Scenes;
using LoGD.Core.Game.Templates;

namespace LoGD.Core
{
    public static class CoreElements
    {
        public static Template[] GetTemplates()
        {
            return new Template[] { Classic.Template() };
        }
        public static Scene[] GetScenes()
        {
            return new Scene[] { new Home() };
        }
    }
}
