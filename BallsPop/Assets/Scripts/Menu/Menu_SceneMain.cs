using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_SceneMain : MonoBehaviour
{
    SceneLoader sceneLoader;
    ScoreManager scoreManager;
    UI_Menu_Main ui_MainMenu;
    UI_Menu_ScorePanel ui_ScorePanel;

    private void Awake()
    {
        sceneLoader = new SceneLoader();
        //scoreManager = new ScoreManager();
        ui_MainMenu = new UI_Menu_Main(sceneLoader);
        ui_ScorePanel = new UI_Menu_ScorePanel(scoreManager);
    }
}