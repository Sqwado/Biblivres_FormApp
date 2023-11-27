using System;

namespace Biblivres.Globals
{
    public static class Globals
    {
        public static string connectionString = Environment.GetEnvironmentVariable("CONNECTIONSTRING");
    }
}