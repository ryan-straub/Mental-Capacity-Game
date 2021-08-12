using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicSceneTransition : MonoBehaviour
{

    //https://www.youtube.com/watch?v=JKoBWBXVvKY
    //https://www.codegrepper.com/code-examples/csharp/music+that+stays+when+you+change+scene+unity

    public AudioSource menuMusic;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        menuMusic = GetComponent<AudioSource>();
    }

    public void stopMusic()
    {
        menuMusic.Stop();
    }
}
