using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [Tooltip("The player object in the level")]
    [SerializeField]
    private GameObject ThePlayer = null;

    [Tooltip("The Death Screen")]
    [SerializeField]
    private GameObject TheDeathPanel = null;

    [Tooltip("this is the number level that the player is playing")]
    public int LevelNumber = 1;

    private bool PlayerAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerAlive)
        {
            if (ThePlayer.GetComponent<Player>().ReturnHealth() < 100)
            {
                TheDeathPanel.SetActive(true);
                PlayerAlive = false;
                Destroy(ThePlayer);
            }
        }
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


}
