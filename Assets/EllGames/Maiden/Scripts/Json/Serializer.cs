using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using EllGames.Maiden.FileIO;
using UnityEngine;

namespace EllGames.Maiden.Json
{
    public static class Serializer
    {
        public static string Serialize(string value)
        {
            return JsonUtility.ToJson(value);
        }
    }
}