﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Test1
    {
        public static bool __hotfix_Game_Test1_TestA_Enable__ = false;

        public static void TestA()
        {
            if (__hotfix_Game_Test1_TestA_Enable__)
            {
                Knight.Framework.Hotfix.HotfixManager.Instance.InvokeStatic("Game.Hotfix.Test1", "TestA");
                return;
            }
            Debug.LogError("I am TestA func");
        }
    }
}
