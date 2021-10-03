using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorLightSwitch : MonoBehaviour
{
    public GameObject Door;
    public int numberOfLightSwitches = 0;

    //Keeps track of how many lights have been turned off
    //When number of light switches turned off equals 31, then it will open downstairs door
    public void addLight()
    {
        numberOfLightSwitches += 1;

        if (numberOfLightSwitches == 31)
        {
            Destroy(Door);
        }
    }

}
