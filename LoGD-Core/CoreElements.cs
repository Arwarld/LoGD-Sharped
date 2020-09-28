#region

using System.Collections.Generic;
using LoGD.Core.Game;
using LoGD.Core.Game.Scenes;
using LoGD.Core.Game.Templates;

#endregion

namespace LoGD.Core
{
    public static class CoreElements
    {
        public static IEnumerable<Template> GetTemplates()
        {
            return new[] {Classic.Template()};
        }

        public static IEnumerable<Scene> GetScenes()
        {
            return new[] {new Home()};
        }
    }
}
