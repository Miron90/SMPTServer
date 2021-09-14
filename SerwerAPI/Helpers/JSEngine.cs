using Jint;
using SerwerAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Helpers
{
    public class JSEngine :IJSEngine
    {
        Engine engine = new Engine();
        
        public JSEngine()
        {
            var milysymbol = System.IO.File.ReadAllText("C:\\APIDatabase\\milsymbol.js");
            engine.Execute(milysymbol);
        }

        public Engine runEngine(string code)
        {
            var result = engine.Execute("new ms.Symbol(\"" + code + "\", {"
                + "size: 60,"
                //+ "quantity: 200,"
                //+ "staffComments: \"for reinforcements\".toUpperCase(),"
                //+ "additionalInformation: \"added support for JJ\".toUpperCase(),"
                //+ "direction: (750 * 360) / 6400,"
                //+ "type: \"machine gun\".toUpperCase(),"
                //+"dtg: \"30140000ZSEP97\","
                //+"location: \"0900000.0E570306.0N\""
                + "}).asSVG();");
            return result;
        }
       
    }
}
