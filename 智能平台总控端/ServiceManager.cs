using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.Configuration;

namespace 智能平台总控端
{
    public  class ServiceManager
    {
        public static void ServiceRegiter()
        {
            GlobalService.container = new UnityContainer();
            UCResigter(GlobalService.container);
        }
        private static IUnityContainer UCResigter(IUnityContainer container)
        {
            #region 注册窗体
            container.LoadConfiguration();
            #endregion
            return container;
        }
    }
}
