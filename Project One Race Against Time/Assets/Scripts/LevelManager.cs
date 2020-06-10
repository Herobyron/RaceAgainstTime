using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [Tooltip("The player object in the level")]
    [SerializeField]
    private GameObject ThePlayer = null;

    [Tooltip("this is the number level that the player is playing")]
    public int LevelNumber = 1;

    private bool PlayerAlive = true;

    Data GameData;


    [Tooltip("this is the end screen UI object")]
    [SerializeField]
    private GameObject EndScreenObject = null;

    private float StartTime;

    private bool TimerEnd = false;

    public Text TimerText = null;

    [Tooltip("this is the time in minutes the player has to complete the level")]
    [SerializeField]
    private int LevelTime = 0;

    private string Minutes;
    private string Seconds;


    private bool EndReached = false;

    // Start is called before the first frame update
    void Start()
    {
        GameData = new Data();
        StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerAlive)
        {
            if(!TimerEnd)
            {
                float T = Time.time - StartTime;

                 Minutes = ((int)T / 60).ToString();

                 Seconds = (T % 60).ToString("f2");

                TimerText.text = Minutes + ":" + Seconds;

                if((int)T / 60 >= LevelTime)
                {
                    TimerEnd = true;
                    TimerText.gameObject.SetActive(false);
                    EndScreenObject.SetActive(true);
                    EndScreenObject.GetComponent<EndScreenUI>().LoseScreen(Minutes, Seconds);
                }
            }

            if (ThePlayer.GetComponent<Player>().ReturnHealth() < 100)
            {
                PlayerAlive = false;
                Destroy(ThePlayer);
                EndScreenObject.SetActive(true);
                EndScreenObject.GetComponent<EndScreenUI>().LoseScreen(Minutes, Seconds);
            }

            if(EndReached)
            {
                Destroy(ThePlayer);
                EndScreenObject.SetActive(true);
                EndScreenObject.GetComponent<EndScreenUI>().WinScreen(Minutes, Seconds);
            }
        }
    }

    public void LevelComplete()
    {
        EndReached = true;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadCurrentLevel()
    {
        switch (LevelNumber)
        {
            case (1):
                {
                    SceneManager.LoadScene("Level One");
                    break;
                }
            case (2):
                {
                    break;
                }
            case (3):
                {
                    break;
                }
            case (4):
                {
                    break;
                }
            case (5):
                {
                    break;
                }
        }

    }

    public void ExitApplication()
    {
        Application.Quit();
    }

    public void Save()
    {
        BinaryFormatter BinFormatter = new BinaryFormatter();
        FileStream DataFile = File.Create(Application.persistentDataPath + "/PlayerLevelData.dat");

        BinFormatter.Serialize(DataFile, GameData);
        DataFile.Close();

    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/PlayerLevelData.dat"))
        {
            BinaryFormatter BinFormater = new BinaryFormatter();
            FileStream DataFile = File.Open(Application.persistentDataPath + "/PlayerLevelData.dat", FileMode.Open);
            Data data = (Data)BinFormater.Deserialize(DataFile);
            DataFile.Close();

            GameData = data;
        }
    }

}


[System.Serializable]
class Data
{

    // the bools for the when the level is completed
    public bool LevelOneComplete;
    public bool LevelTwoComplete;
    public bool LevelThreeComplete;
    public bool LevelFourComplete;
    public bool LevelFiveComplete;


    // floats for the time taken for each level
    public float LevelOneTime;
    public float LevelTwoTime;
    public float LevelThreeTime;
    public float LevelFourTime;
    public float LevelFiveTime;
}

