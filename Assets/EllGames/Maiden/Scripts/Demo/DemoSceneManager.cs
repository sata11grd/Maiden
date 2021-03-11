using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using EllGames.Maiden.FileIO;
using EllGames.Maiden.Json;
using UnityEngine;

namespace EllGames.Maiden.Demo
{
    public class DemoSceneManager : MonoBehaviour
    {
        private void Awake()
        {
            Core.Maiden.Save("hp", 100);
        }
    }
}