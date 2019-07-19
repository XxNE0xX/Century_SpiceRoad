using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeMenuLogic : MonoBehaviour
{

    public void PlayLocalMultiplayer()
    {
        SceneManager.LoadScene("LocalMultiplayer");
    }
    public void PlayLocalSinglePlayer()
    {
        SceneManager.LoadScene("LocalSinglePlayer");
    }
    public void PlayNetworkMultiplayer()
    {
        SceneManager.LoadScene("NetworkMultiplayer");
    }
}
