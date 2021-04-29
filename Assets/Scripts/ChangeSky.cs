using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSky : MonoBehaviour
{
    //resource used http://www.bigfatblueberry.com/unity3d-how-to-change-skybox-with-script/

    //assign skybox materials
    public Material sunriseSkybox;
    public Material midDaySkybox;
    public Material sunsetSkybox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //change skybox to sunrise
    void sunrise()
    {
        RenderSettings.skybox = sunriseSkybox;
    }

    //change skybox to midDay
    void midDay()
    {
        RenderSettings.skybox = midDaySkybox;
    }

    //change skybox to sunset
    void sunset()
    {
        RenderSettings.skybox = sunsetSkybox;
    }
}
