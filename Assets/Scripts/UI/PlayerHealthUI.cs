using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealthUI : MonoBehaviour
{


    Text levelText;

    Image healthSlider;

    Image expSlider;
    // Start is called before the first frame update

     void Awake()
    {
        levelText = transform.GetChild(2).GetComponent<Text>();
        healthSlider = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        expSlider = transform.GetChild(1).GetChild(0).GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        //��λ��
        levelText.text = "Level " + GameManager.Instance.playerStats.characterData.currentLevel.ToString("00");
        UpdateExp();
        UpdateHealth();
    }

    void UpdateHealth()
    {
        float sliderPercent = (float)GameManager.Instance.playerStats.CurrentHealth / GameManager.Instance.playerStats.MaxHealth;
        healthSlider.fillAmount = sliderPercent;

    }


    void UpdateExp()
    {
        float sliderPercent = (float)GameManager.Instance.playerStats.characterData.currentExp/ GameManager.Instance.playerStats.characterData.baseExp;
        expSlider.fillAmount = sliderPercent;

    }
}
