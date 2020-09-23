using System.Collections.ObjectModel;

namespace LoGD.Core.Game.Scenes
{
    class Home : Scene
    {
        public override string Show(int userID, ReadOnlyDictionary<string, string> getValues, Database db)
        {
            return "";
        }
        public Home()
            : base("home", true, false)
        {

        }
    }
}
