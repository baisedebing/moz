using System.Collections.Generic;

namespace Moz.Core.Options
{
    public class MozOptions
    {
        public MozOptions()
        {
            Admin = new AdminOptions
            {
                Path = "admin",
                LoginView = "",
                WelcomeView = ""
            };
            
            Db = new List<DbOptions>();
        }


        /// <summary>
        /// 是否开启定时任务 默认不开启
        /// </summary>
        public bool IsEnableScheduling { get; set; } 
        
        /// <summary>
        /// 是否开启性能监测
        /// </summary>
        public bool IsEnablePerformanceMonitor { get; set; }
          
        /// <summary>
        /// 加密KEY,关系到应用安全，很重要
        /// </summary>
        public string EncryptKey { get; set; }

        /// <summary>
        /// 数据库相关配置
        /// </summary>
        public List<DbOptions> Db { get; }  
        
        /// <summary>
        /// 后台配置
        /// </summary>
        public AdminOptions Admin { get; }
    }
}