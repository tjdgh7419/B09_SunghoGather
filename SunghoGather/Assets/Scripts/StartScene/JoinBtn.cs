using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinBtn : MonoBehaviour
{
	public void MainStart()
    {
        if (PlayerPrefs.GetString("CurrentName") != "")
        {
            SceneManager.LoadScene("SelectScene");
        }     
    }
}
