using Falzoni.Utils.Helpers;
using System.Diagnostics;
using System.Web.Optimization;

namespace Falzoni.Presentation.Web
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o Agrupamento, visite https://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
            //RegisterJQueryScriptManager();

            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                            "~/Scripts/WebForms/WebForms.js",
                            "~/Scripts/WebForms/WebUIValidation.js",
                            "~/Scripts/WebForms/MenuStandards.js",
                            "~/Scripts/WebForms/Focus.js",
                            "~/Scripts/WebForms/GridView.js",
                            "~/Scripts/WebForms/DetailsView.js",
                            "~/Scripts/WebForms/TreeView.js",
                            "~/Scripts/WebForms/WebParts.js"));

            // A ordem é muito importante para que esses arquivos funcionem; eles possuem dependências explícitas
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

            RegisterJQueryBundle(bundles);

            // Use a versão de Desenvolvimento do Modernizr para se desenvolver e aprender com ele. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //                "~/Scripts/Libraries/modernizr-*"));
        }

        public static void RegisterJQueryBundle(BundleCollection bundles)
        {
            bundles.UseCdn = !ConfigurationHelper.IsBundleled;

            string cdnPath = "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.7.1.min.js";

            if (Debugger.IsAttached)
            {
                cdnPath = "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.7.1.js";
                BundleTable.EnableOptimizations = true;
            }

            var scriptBundle = new ScriptBundle("~/Scripts/jquery", cdnPath);
            if (ConfigurationHelper.IsBundleled) 
            {
                scriptBundle.Include("~/Scripts/Libraries/jquery/jquery-*");
            }

            bundles.Add(scriptBundle);
        }

        //public static void RegisterJQueryScriptManager()
        //{
        //    ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
        //        new ScriptResourceDefinition
        //        {
        //            Path = "~/scripts/libraries/jquery/jquery-3.7.0.min.js",
        //            DebugPath = "~/scripts/libraries/jquery/jquery-3.7.0.js",
        //            CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.7.1.min.js",
        //            CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.7.1.js"
        //        });
        //}
    }
}