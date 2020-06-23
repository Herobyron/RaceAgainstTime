using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [Tooltip("the text that displays if the level is completed")]
    [SerializeField]
    private Text LevelCompleted = null;

    [Tooltip("the text that displays the levels total time")]
    [SerializeField]
    private Text TimeToCompleteLevel = null;

    [Tooltip("the text element that displays the time the player had to complete the level")]
    [SerializeField]
    private Text TimeTaken = null;

    [Tooltip("This is the level manager in the main menu scene")]
    [SerializeField]
    private LevelManager TheManager = null;

    [Tooltip("this is the start Game button that will load the level selected by the player")]
    [SerializeField]
    private GameObject StartGameButton = null;

    // Start is called before the first frame update
    void Start()
    {
        TheManager.Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSelected(int LevelNum)
    {
        TheManager.SetLevelNumber(LevelNum);


        switch (LevelNum)
        {
            case (1):
                {
                    if (TheManager.ReturnPlayerData().LevelOneComplete)
                    {

                        LevelCompleted.text = "Level Completed";

                        string Mins = ((int)TheManager.ReturnPlayerData().LevelOneTime / 60).ToString();
                        string Seconds = (TheManager.ReturnPlayerData().LevelOneTime % 60).ToString("f2");

                        TimeTaken.text = Mins + ":" + Seconds;

                        TimeToCompleteLevel.text = "2 mins";

                        LevelCompleted.gameObject.SetActive(true);
                        TimeTaken.gameObject.SetActive(true);
                        TimeToCompleteLevel.gameObject.SetActive(true);
                        StartGameButton.SetActive(true);

                    }
                    else
                    {
                        LevelCompleted.text = "Level InComplete";
                        TimeTaken.text = "0:0.0";
                        TimeToCompleteLevel.text = "2 mins";

                        LevelCompleted.gameObject.SetActive(true);
                        TimeTaken.gameObject.SetActive(true);
                        TimeToCompleteLevel.gameObject.SetActive(true);
                        StartGameButton.SetActive(true);
                    }

                    


                    break;
                }
            case (2):
                {
                    if(TheManager.ReturnPlayerData().LevelTwoComplete)
                    {
                        LevelCompleted.text = "Level Completed";

                        string Mins = ((int)TheManager.ReturnPlayerData().LevelTwoTime / 60).ToString();
                        string Seconds = (TheManager.ReturnPlayerData().LevelTwoTime % 60).ToString("f2");

                        TimeTaken.text = Mins + ":" + Seconds;

                        TimeToCompleteLevel.text = "2 Mins";

                        LevelCompleted.gameObject.SetActive(true);
                        TimeTaken.gameObject.SetActive(true);
                        TimeToCompleteLevel.gameObject.SetActive(true);
                        StartGameButton.SetActive(true);
                    }
                    else
                    {
                        LevelCompleted.text = "Level InComplete";
                        TimeTaken.text = "0:0.0";
                        TimeToCompleteLevel.text = "2 mins";

                        LevelCompleted.gameObject.SetActive(true);
                        TimeTaken.gameObject.SetActive(true);
                        TimeToCompleteLevel.gameObject.SetActive(true);
                        StartGameButton.SetActive(true);
                    }
                    break;
                }
            case (3):
                {
                    if (TheManager.ReturnPlayerData().LevelThreeComplete)
                    {
                        LevelCompleted.text = "Level Completed";

                        string Mins = ((int)TheManager.ReturnPlayerData().LevelThreeTime / 60).ToString();
                        string Seconds = (TheManager.ReturnPlayerData().LevelThreeTime % 60).ToString("f2");

                        TimeTaken.text = Mins + ":" + Seconds;

                        TimeToCompleteLevel.text = "3 Mins";

                        LevelCompleted.gameObject.SetActive(true);
                        TimeTaken.gameObject.SetActive(true);
                        TimeToCompleteLevel.gameObject.SetActive(true);
                        StartGameButton.SetActive(true);
                    }
                    else
                    {
                        LevelCompleted.text = "Level InComplete";
                        TimeTaken.text = "0:0.0";
                        TimeToCompleteLevel.text = "3 mins";

                        LevelCompleted.gameObject.SetActive(true);
                        TimeTaken.gameObject.SetActive(true);
                        TimeToCompleteLevel.gameObject.SetActive(true);
                        StartGameButton.SetActive(true);
                    }
                    break;
                }
            case (4):
                {
                    if (TheManager.ReturnPlayerData().LevelFourComplete)
                    {
                        LevelCompleted.text = "Level Completed";

                        string Mins = ((int)TheManager.ReturnPlayerData().LevelFourTime / 60).ToString();
                        string Seconds = (TheManager.ReturnPlayerData().LevelFourTime % 60).ToString("f2");

                        TimeTaken.text = Mins + ":" + Seconds;

                        TimeToCompleteLevel.text = "5 Mins";

                        LevelCompleted.gameObject.SetActive(true);
                        TimeTaken.gameObject.SetActive(true);
                        TimeToCompleteLevel.gameObject.SetActive(true);
                        StartGameButton.SetActive(true);
                    }
                    else
                    {
                        LevelCompleted.text = "Level InComplete";
                        TimeTaken.text = "0:0.0";
                        TimeToCompleteLevel.text = "5 mins";

                        LevelCompleted.gameObject.SetActive(true);
                        TimeTaken.gameObject.SetActive(true);
                        TimeToCompleteLevel.gameObject.SetActive(true);
                        StartGameButton.SetActive(true);
                    }
                    break;
                }
            case (5):
                {
                    if (TheManager.ReturnPlayerData().LevelFiveComplete)
                    {
                        LevelCompleted.text = "Level Completed";

                        string Mins = ((int)TheManager.ReturnPlayerData().LevelFiveTime / 60).ToString();
                        string Seconds = (TheManager.ReturnPlayerData().LevelFiveTime % 60).ToString("f2");

                        TimeTaken.text = Mins + ":" + Seconds;

                        TimeToCompleteLevel.text = "1 Mins";

                        LevelCompleted.gameObject.SetActive(true);
                        TimeTaken.gameObject.SetActive(true);
                        TimeToCompleteLevel.gameObject.SetActive(true);
                        StartGameButton.SetActive(true);
                    }
                    else
                    {
                        LevelCompleted.text = "Level InComplete";
                        TimeTaken.text = "0:0.0";
                        TimeToCompleteLevel.text = "1 mins";

                        LevelCompleted.gameObject.SetActive(true);
                        TimeTaken.gameObject.SetActive(true);
                        TimeToCompleteLevel.gameObject.SetActive(true);
                        StartGameButton.SetActive(true);
                    }
                    break;
                }
        }

        
    }


    public void TurnOffObjects()
    {
        TimeTaken.gameObject.SetActive(false);
        TimeToCompleteLevel.gameObject.SetActive(false);
        LevelCompleted.gameObject.SetActive(false);
        StartGameButton.SetActive(false);
    }

}
