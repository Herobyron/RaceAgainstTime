using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenUI : MonoBehaviour
{
    [Tooltip("this is the text displayed on the screen")]
    public Text EndGameText = null;

    [Tooltip(" the text used to display the time left.")]
    public Text EndGameTime = null;

    [Tooltip("this is the image of end screen")]
    public Image EndGameScreen = null;

    public void WinScreen(string minuets, string seconds)
    {
        EndGameText.text = "Victory";
        EndGameTime.text = "Time: " +  minuets + ":" + seconds;
        EndGameScreen.color = Color.blue;
    }


    public void LoseScreen(string minuets, string seconds)
    {
        EndGameText.text = "Defeat";
        EndGameTime.text = "Time: " + minuets + ":" + seconds;
        EndGameScreen.color = Color.black;
    }


}
