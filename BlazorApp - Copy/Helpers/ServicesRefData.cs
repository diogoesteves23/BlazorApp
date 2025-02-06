using BlazorApp.Model.Services;

namespace BlazorApp.Helpers
{
    public static class ServicesRefData
    {
        public static List<Service> ServicesList => ServicesListPrivate;

        private static readonly List<Service> ServicesListPrivate = new() {
            new Service { PageName = "Change Account to BadAccount", PageCode = "BadAccount" },
            new Service { PageName = "Get Files In Diretory", PageCode = "GetFilesInDiretory" },
            new Service { PageName = "Copy or Move Files In Diretory", PageCode = "CopyOrMoveInDiretory"},
            new Service { PageName = "Job Dashboard", PageCode = "JobDashboard" },
            new Service { PageName = "Business Date View", PageCode = "BusinessDateView" },
            new Service { PageName = "Isins Manager", PageCode = "IsinsManager" }
        };

        public static Dictionary<string, Dictionary<int, string>> Services => ServicesPrivate;

        private static readonly Dictionary<string, Dictionary<int, string>> ServicesPrivate = new()
        {
            {
                "D", new Dictionary<int, string>()
                { 
                    {1, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/api/trading/clearaccount/markaccountwithbadaccount?{0}" },
                    {2, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/getfilesindiretory?prefixPathOrigin={0}&folderNameOrigin={1}&{2}" },
                    {3, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/copyfilesindiretory" },
                    {4, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/movefilesindiretory" },
                    {5, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/getjobinfo?jobId={0}" },
                    {6, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullerdumpjobexecution?{0}" },
                    {7, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullerresetbusinessdate" },
                    {8, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullersetjobschanges" },
                    {9, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullerinsertjobexecution" },
                    {10, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullerchangejobexecution" },
                    {11, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullertriggerrunexecution" },
                    {12, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/getisinnotfound?{0}" },
                    {13, "https://dotnet-service-trading-internal-dev-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/insertdummyisin" }
                }
            },
            {
                "Q", new Dictionary<int, string>()
                {
                    {1, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/api/trading/clearaccount/markaccountwithbadaccount?{0}" },
                    {2, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/getfilesindiretory?prefixPathOrigin={0}&folderNameOrigin={1}&{2}" },
                    {3, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/copyfilesindiretory" },
                    {4, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/movefilesindiretory" },
                    {5, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/getjobinfo?jobId={0}" },
                    {6, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullerdumpjobexecution?{0}" },
                    {7, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullerresetbusinessdate" },
                    {8, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullersetjobschanges" },
                    {9, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullerinsertjobexecution" },
                    {10, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullerchangejobexecution" },
                    {11, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/schedullertriggerrunexecution" },
                    {12, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/getisinnotfound?{0}" },
                    {13, "https://dotnet-service-trading-internal-qua-wealthmanagement.apps.aro03.bdso.tech/job/trading/auxiliar/insertdummyisin" }
                }
            },
            {
                "P", new Dictionary<int, string>()
                {
                    {1, "https://aro-prd.apps.aro04.bdso.tech/api/trading/clearaccount/markaccountwithbadaccount?{0}" },
                    {2, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/getfilesindiretory?prefixPathOrigin={0}&folderNameOrigin={1}&{2}" },
                    {3, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/copyfilesindiretory" },
                    {4, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/movefilesindiretory" },
                    {5, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/getjobinfo?jobId={0}" },
                    {6, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/schedullerdumpjobexecution?{0}" },
                    {7, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/schedullerresetbusinessdate" },
                    {8, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/schedullersetjobschanges" },
                    {9, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/schedullerinsertjobexecution" },
                    {10, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/schedullerchangejobexecution" },
                    {11, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/schedullertriggerrunexecution" },
                    {12, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/getisinnotfound?{0}" },
                    {13, "https://aro-prd.apps.aro04.bdso.tech/job/trading/auxiliar/insertdummyisin" }
                }
            }
        };
    }
}
