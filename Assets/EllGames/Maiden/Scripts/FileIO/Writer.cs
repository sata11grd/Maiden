using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace EllGames.Maiden.FileIO
{
    public static class Writer
    {
        public static void Write(string path, string value)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            File.WriteAllText(path, value);
        }
    }
}
