using System;
using System.IO;

namespace Querles.Configuration
{
    internal static class Queries
    {
        public static string QueriesPath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "Queries.xml");
    }
}
