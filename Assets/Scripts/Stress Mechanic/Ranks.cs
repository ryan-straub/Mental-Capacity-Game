using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranks : MonoBehaviour
{
    public Sprite RankS;
    public Sprite RankA;
    public Sprite RankB;
    public Sprite RankC;
    public Sprite RankD;
    public Sprite RankF;

    // Update is called once per frame

    public void setRank(string rank)
    {
        switch (rank)
        {
            case "S":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = RankS;
                break;

            case "A":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = RankA;
                break;

            case "B":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = RankB;
                break;

            case "C":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = RankC;
                break;

            case "D":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = RankD;
                break;

            case "F":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = RankF;
                break;
        }
        PlayerPrefs.SetString("rank",rank); 
        //can do floats strings and integers
    }
}
