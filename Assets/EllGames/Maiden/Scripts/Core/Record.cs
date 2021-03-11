using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using EllGames.Maiden.FileIO;
using UnityEngine;

namespace EllGames.Maiden.Core
{
    [Serializable]
    public class Record<T> 
    {
        public string key;
        public T value;
    }
}