using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public int index;
    public void NextScene()
    {
        SceneManager.LoadScene(index);
    }
}
