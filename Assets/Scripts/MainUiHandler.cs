using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUiHandler : MonoBehaviour
{
    [SerializeField] private Text bestScore;

    // Start is called before the first frame update
    void Start()
    {
       this.BestScoreUpdate();
    }

    // Update is called once per frame
    void BestScoreUpdate()
    {
        if (GameManager.BestPlayer == null) return;
        bestScore.text = "Best score: " + GameManager.BestPlayer + ": " + GameManager.BestScore;
    }
}
