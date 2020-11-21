using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarControls : MonoBehaviour
{
# public static Sprite[] healthLevels;
    public static Image healthBar;
    public GameObject healthBarMain;
# public int ReduceValue;

# bool hitFromEnemy;

    void Start()
    {
        healthBar = healthBarMain.GetComponent<Image>();
        HealthBarValue(1);
    }

    private void Update()
    {
        HealthBarValue(healthBar.fillAmount - 0.01f);
# HealthBarValue(healthBar.fillAmount - ReduceValue);
    }

    /*
    public static void HealthBarValue(float value)
    {
        healthBar.fillAmount = value;
        if (healthBar.fillAmount < 0.2f)
        {
            SetHealthBarImage(healthLevels[0]);
        }
        else if (healthBar.fillAmount < 0.4f)
        {
            SetHealthBarImage(healthLevels[1]);
        }
        else
        {
            SetHealthBarImage(healthLevels[2]);
        }
    }
    

    public static void SetHealthBarImage(Sprite HealthSprite)
    {
        healthBar.sprite = HealthSprite;
    }

    */
}
