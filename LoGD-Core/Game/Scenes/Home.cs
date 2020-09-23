using System.Collections.ObjectModel;

namespace LoGD.Core.Game.Scenes
{
    class Home : Scene
    {
        public override string Show(int userID, ReadOnlyDictionary<string, string> getValues, Database db)
        {
            return "<html><body><form action=\"http://localhost:5000/\" method=\"post\"><input type=\"hidden\" id=\"test\" name=\"test\" value=\"Doe\"><input type=\"submit\" value=\"Submit\"></form></body></html>";
        }

        public Home()
            : base("home", true, false)
        {

        }
    }
}
