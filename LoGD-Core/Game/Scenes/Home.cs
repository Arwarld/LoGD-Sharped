#region

using System.Collections.ObjectModel;

#endregion

namespace LoGD.Core.Game.Scenes
{
    internal sealed class Home : Scene
    {
        public Home()
            : base("home", true, false)
        {
        }

        public override string Show(int userId, ReadOnlyDictionary<string, string> getValues, Database db)
        {
            return "";
        }
    }
}
