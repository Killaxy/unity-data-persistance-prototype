using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static string Playername;
    public static int BestScore = 0;
    public static string BestPlayer;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    public static void CheckForBestScore(int score)
    {
        if(score > BestScore)
        {
            BestScore = score;
            BestPlayer = Playername;
        }
    }
}
