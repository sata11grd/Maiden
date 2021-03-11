using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using EllGames.Maiden.FileIO;
using EllGames.Maiden.Json;
using UnityEngine;

namespace EllGames.Maiden.Core
{
    public static class Maiden
    {
        public static bool KeyExists(string key)
        {
            return true;
        }

        public static void Save<T>(string key, T value)
        {
            Writer.Write(Application.dataPath + "/StreamingAssets/maiden", Serializer.Serialize(value.ToString()));
        }

        public static T Load<T>(string key)
        {
            throw new NotImplementedException();
        }
    }
}