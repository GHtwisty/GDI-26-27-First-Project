using UnityEngine;
using UnityEngine.InputSystem;

public class CookieClicker : MonoBehaviour
{

    int Gold;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool Has10Gold()
    {
        if(Gold >= 10)
        {
            return true;
        }
        return false;
    }

    public void ActivateInput(InputAction.CallbackContext context)
    {
        Gold++;
        Has10Gold();
    }

}
