using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagement : MonoBehaviour
{
    public void Scene0()
    {
        SceneManager.LoadScene(0);
    }
    public void Scene1()
    {
        SceneManager.LoadScene(1);
    }
    public void Scene2()
    {
        SceneManager.LoadScene(2);
    }
    public void Scene3()
    {
        SceneManager.LoadScene(3);
    }
    public void Scene4()
    {
        SceneManager.LoadScene(4);
    }
    public void Scene5()
    {
        SceneManager.LoadScene(5);
    }
    public void Scene6()
    {
        SceneManager.LoadScene(6);
    }
    public void Scene7()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1;
    }
    public void Scene8()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1;
    }
    public void Scene9()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(9);
    }
    public void Scene10()
    {
        SceneManager.LoadScene(10);
        Time.timeScale = 1;
    }
    public void Scene11()
    {
        SceneManager.LoadScene(11);
        Time.timeScale = 1;
    }
    public void Scene12()
    {
        SceneManager.LoadScene(12);
        Time.timeScale = 1;
    }
    public void Scene13()
    {
        SceneManager.LoadScene(13);
    }
    public void Quit()
    {
        Application.Quit();

    }

}
