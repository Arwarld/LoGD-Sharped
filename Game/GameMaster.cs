using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using LoGD.Game.Templates;
using System.Reflection;
using System.Net.Http;
using Microsoft.AspNetCore.Http;

namespace LoGD.Game
{
    public class GameMaster
    {
        public GameMaster()
        {
            loadTemplates();
            loadScenes();
            db = new Database();
        }
        protected static IEnumerable<Type> GetClasses(string nameSpace)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            return asm.GetTypes().Where(type => type.Namespace == nameSpace);
        }
        private Database db;
        private void loadTemplates()
        {
            foreach (Type template in GetClasses("LoGD.Game.Templates"))
            {
                MethodInfo method = template.GetMethod("Template");
                Template templateObject = (Template)method.Invoke(null, null);
                templateCSS.Add(template.Name, templateObject.Css);
            }
        }
        private void loadScenes()
        {
            foreach (Type scene in GetClasses("LoGD.Game.Scenes"))
            {
                MethodInfo sceneMethod = scene.GetMethod("Show");
                scenes.Add(scene.Name.ToLower(), sceneMethod);
                MethodInfo sceneAnon = scene.GetMethod("AllowAnonymous");
                sceneAllowAnonymous.Add(scene.Name.ToLower(), (bool)sceneAnon.Invoke(null, null));
                MethodInfo sceneOverrideNav = scene.GetMethod("OverrideForcedNav");
                sceneOverrideForcedNav.Add(scene.Name.ToLower(), (bool)sceneOverrideNav.Invoke(null, null));
            }
        }
        private static Dictionary<string, string> templateCSS = new Dictionary<string, string>();
        private static Dictionary<string, MethodInfo> scenes = new Dictionary<string, MethodInfo>();
        private static Dictionary<string, bool> sceneAllowAnonymous = new Dictionary<string, bool>();
        private static Dictionary<string, bool> sceneOverrideForcedNav = new Dictionary<string, bool>();
        public static readonly ReadOnlyDictionary<string, string> TemplateCSS = new ReadOnlyDictionary<string, string>(templateCSS);

        public string BuildPage(ISession context, string page)
        {
            return BuildPage(context, page, new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()));
        }
        public string BuildPage(ISession context, string page, ReadOnlyDictionary<string, string> getValues)
        {
            if (context.Keys.Contains("loggedin") && context.GetInt32("loggedin") == 1)
            {
                if (scenes.ContainsKey(page))
                {
                    if (sceneOverrideForcedNav[page])
                        return (string)scenes[page].Invoke(null, new object[] { context, getValues, db });
                    //check allowednavs in DB
                    //allowed
                    return (string)scenes[page].Invoke(null, new object[] { context, getValues, db });

                }
                return "Badnav";
                //return last page again;
            }
            else
            {
                if (scenes.ContainsKey(page) && sceneAllowAnonymous[page])
                    return (string)scenes[page].Invoke(null, new object[] { context, getValues, db });
                return (string)scenes["home"].Invoke(null, new object[] { context, getValues, db });
            }
        }
    }
}
