using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace InsightAvionics.Repository
{
    public static class InputStream
    {
        public static byte[] ReadToEnd(this Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}