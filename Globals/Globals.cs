﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblivres;

namespace Biblivres.Globals
{
    public static class Globals
    {
        public static string connectionString = Environment.GetEnvironmentVariable("CONNECTIONSTRING");
    }
}

