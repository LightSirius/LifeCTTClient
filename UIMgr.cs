using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMgr : Singleton<UIMgr>
{
    public Image LifeProgressBar;
    public Text LifeInfoText;

    private void Awake() {
        LifeInfoText.text = " ";
      
        LifeProgressBar.gameObject.SetActive(false);
       
    }

    private void Update() {
        //LifeProgressBar.fillAmount -= 1f / 20f * Time.deltaTime;
    }
    
    public void SetLifeUI(bool state){
        LifeInfoText.gameObject.SetActive(state);
        LifeProgressBar.gameObject.SetActive(state);

        LifeProgressBar.fillAmount = 1f;
        LifeInfoText.text = "";
    }
}