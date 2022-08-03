using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUiHandler : MonoBehaviour
{
    [SerializeField] private Text HightScoreContainer;
    [SerializeField] private InputField playerName;

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Playername != null)
        {
            HightScoreContainer.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        GameManager.Playername = this.playerName.text;
        SceneManager.LoadScene(1);
    }
}
