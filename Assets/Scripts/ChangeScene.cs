using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private bool HAS_FIRED;
    // Start is called before the first frame update
    void Start()
    {
        HAS_FIRED = false;
    }

    public void nextLevel()
    {
        if (HAS_FIRED == false)
        {
            //progress to next level 
            SceneManager.LoadScene("Level2", LoadSceneMode.Additive);
            HAS_FIRED = true;
        }

    }
}

