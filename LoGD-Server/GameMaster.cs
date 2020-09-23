using LoGD.Core;
using LoGD.Core.Game;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LoGD.Server
{
    public class GameMaster
    {
        public GameMaster()
        {
            loadTemplates();
            loadScenes();
            db = new Database();
        }
        private Database db;
        private void loadTemplates()
        {
            foreach (Template template in CoreElements.GetTemplates())
            {
                templateCSS.Add(template.Name, template);
            }
        }
        private void loadScenes()
        {
            foreach (Scene scene in CoreElements.GetScenes())
            {
                scenes.Add(scene.Name, scene);
            }
        }
        private static Dictionary<string, Template> templateCSS = new Dictionary<string, Template>();
        private static Dictionary<string, Scene> scenes = new Dictionary<string, Scene>();
        public static readonly ReadOnlyDictionary<string, Template> TemplateCSS = new ReadOnlyDictionary<string, Template>(templateCSS);

        public string BuildPage(ISession context, string page)
        {
            return BuildPage(context, page, new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()));
        }
        public string BuildPage(ISession context, string page, ReadOnlyDictionary<string, string> getValues)
        {
            if (context.Keys.Contains("loggedin") && context.GetInt32("loggedin") == 1 && context.Keys.Contains("userid"))
            {
                int userid = (int)context.GetInt32("userid");
                if (scenes.ContainsKey(page))
                {
                    if (scenes[page].OverrideForcedNav)
                        return (string)scenes[page].Show( userid, getValues, db);
                    //check allowednavs in DB
                    //allowed
                    return (string)scenes[page].Show( userid, getValues, db );

                }
                return "Badnav";
                //return last page again;
            }
            else
            {
                if (scenes.ContainsKey(page) && scenes[page].AllowAnonymous)
                    return (string)scenes[page].Show( -1, getValues, db );
                return (string)scenes["home"].Show( -1, getValues, db );
            }
        }
    }
}
