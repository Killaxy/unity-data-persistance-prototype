using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static string Playername;
    public static BestPlayerData bestPlayerData;
    
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        LoadBestPlayerData();
    }

    public static void CheckForBestScore(int score)
    {
        if(score > bestPlayerData.BestScore)
        {
            bestPlayerData.BestScore = score;
            bestPlayerData.BestPlayer = Playername;
            SaveBestPlayerData();
        }
    }

    private static void LoadBestPlayerData()
    {
        if(File.Exists(Application.persistentDataPath + "save.json"))
        {
            bestPlayerData = JsonUtility.FromJson<BestPlayerData>(File.ReadAllText(Application.persistentDataPath + "save.json"));
        }
        else
        {
            bestPlayerData = new BestPlayerData();
        }
        
    }

    private static void SaveBestPlayerData()
    {
        string json = JsonUtility.ToJson(bestPlayerData);
        File.WriteAllText(Application.persistentDataPath +"save.json",json);
    }

    [System.Serializable]
    public class BestPlayerData
    {
        public int BestScore = 0;
        public string BestPlayer;
    }
}
