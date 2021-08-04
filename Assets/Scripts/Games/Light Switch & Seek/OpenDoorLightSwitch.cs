using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorLightSwitch : MonoBehaviour
{
    public GameObject Door;
    public int numberOfLightSwitches = 0;

    // Update is called once per frame
    void Update()
    {

    }

    public void addLight()
    {
        numberOfLightSwitches += 1;

        if (numberOfLightSwitches == 31)
        {
            Destroy(Door);
        }
    }

}
