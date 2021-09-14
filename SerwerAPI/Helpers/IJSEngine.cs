using Jint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI.Helpers
{
    public interface IJSEngine
    {
        public Engine runEngine(string code);
    }
}
