using System.Diagnostics.CodeAnalysis;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class CookieClicker : MonoBehaviour
{
    [SerializeField]
    TMP_Text GoldText;
    int Gold;
    float CurrentCooldown;
    float MaxCooldown = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {

        GoldText.text = Gold.ToString();

        CurrentCooldown = Mathf.Clamp(CurrentCooldown - Time.deltaTime, 0, MaxCooldown);
        if(CurrentCooldown == 0)
        {
            IncreasedGold();
            CurrentCooldown = MaxCooldown;
        }
    }

    bool Has10Gold()
    {
        if(Gold >= 10)
        {
            return true;
        }
        return false;
    }

    void IncreasedGold()
    {
        Gold++;
        Has10Gold();
        Debug.Log(Gold + Gold);
    }

    public void ActivateInput(InputAction.CallbackContext context)
    {
        IncreasedGold();
    }

    public void UpgradeInput(InputAction.CallbackContext context)
    {
        if (Has10Gold())
        {
            MaxCooldown -= 0.2f;
            Gold -= 10;
        }
    }


}
