using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace EllGames.Maiden.FileIO
{
    public static class Reader
    {
        public static string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}