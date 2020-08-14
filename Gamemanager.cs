using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject EndPanel;

    private void Start()
    {
        if (!DataManager.Instance.PlayerDie)
        {

        }

        if (DataManager.Instance.PlayerDie == true)
        {
            EndPanel.SetActive(true);
        }
        
    }
    
    public void Restart_Btu()
    {
        DataManager.Instance.score = 0;
        DataManager.Instance.PlayerDie = false;
        DataManager.Instance.PlayerTimeCurrent = DataManager.Instance.playTimeMax;
        DataManager.Instance.margnetTimeCurrent = 0;

        SceneManager.LoadScene("SampleScene");
    }
}
