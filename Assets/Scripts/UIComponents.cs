using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[Serializable]
public class UIComponents
{
    [Serializable]
    public class Hud{
        [Header("Text")]
        public Text  txtCoinCount;
        public Text  txtLifeCount;
         [Header("Other")]
        public GameObject panelHUD;
    }

    [Serializable]
    public class LevelCompletePanel
    {
        [Header("Text")]
        public Text txtScore;
        [Header("Other")]
        public GameObject LCPanel;
    }

    public Hud hud;
    public LevelCompletePanel levelCompletePanel;
}
