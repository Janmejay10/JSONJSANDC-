using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class JavaScriptSettings
    {
        public JRaw OnLoadFunction { get; set; }
        public JRaw OnUnloadFunction { get; set; }

        static void Main(string[] args)
        {
            JavaScriptSettings settings = new JavaScriptSettings
            {
                OnLoadFunction = new JRaw("OnLoad"),
                OnUnloadFunction = new JRaw("function(e) { alert(e); }")
            };

            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);

            Console.WriteLine(json);
            Console.Read();
            // {
            //   "OnLoadFunction": OnLoad,
            //   "OnUnloadFunction": function(e) { alert(e); }
            // }
        }
    }
}
