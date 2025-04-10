using BepInEx;
using GorillaNetworking;
using iiMenu.Classes;
using iiMenu.Menu;
using iiMenu.Mods;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using static iiMenu.Menu.Main;

namespace iiMenu.UI
{
    public class Main : MonoBehaviour
    {
        private string inputText = "goldentrophy";

        private string r = "255";
        private string g = "128";
        private string b = "0";

        public static bool isOpen = false; // Default to off
        public static bool lastCondition = false;

        public static Texture2D icon;

        private void Start()
        {
            // Force GUI to remain disabled regardless of any file
            isOpen = false;

            // Optional: Delete old GUI toggle file if it exists
            string hideFilePath = "iisStupidMenu/iiMenu_HideGUI.txt";
            if (File.Exists(hideFilePath))
            {
                try { File.Delete(hideFilePath); } catch { }
            }
        }

        // Completely disable GUI
        private void OnGUI()
        {
            // GUI has been intentionally disabled.
        }
    }
}
