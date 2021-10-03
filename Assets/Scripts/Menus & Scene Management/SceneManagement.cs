using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    //Changes game scenes

    //Title Screen
    public void Scene0()
    {
        SceneManager.LoadScene(0);
    }

    //Level Select
    public void Scene1()
    {
        SceneManager.LoadScene(1);
    }

    //How to Play (HWH)
    public void Scene2()
    {
        SceneManager.LoadScene(2);
    }

    //How to Play (RRR)
    public void Scene3()
    {
        SceneManager.LoadScene(3);
    }

    //How to Play (LS&S)
    public void Scene4()
    {
        SceneManager.LoadScene(4);
    }

    //How to Play (FH)
    public void Scene5()
    {
        SceneManager.LoadScene(5);
    }

    //How to Play (BO)
    public void Scene6()
    {
        SceneManager.LoadScene(6);
    }

    //Handwashing section of HWH
    public void Scene7()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1;
    }

    //Obstacle Course section of HWH
    public void Scene8()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1;
    }

    //Blockout
    public void Scene9()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(9);
    }

    //Light Switch & Seek
    public void Scene10()
    {
        SceneManager.LoadScene(10);
        Time.timeScale = 1;
    }

    //Reading Repetition Redemption
    public void Scene11()
    {
        SceneManager.LoadScene(11);
        Time.timeScale = 1;
    }

    //Fire Hazard
    public void Scene12()
    {
        SceneManager.LoadScene(12);
        Time.timeScale = 1;
    }

    //S-TIer
    public void Scene13()
    {
        SceneManager.LoadScene(13);
    }

    //Quits Application
    public void Quit()
    {
        Application.Quit();

    }

}
