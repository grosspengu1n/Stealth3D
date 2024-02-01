using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text visibility;
    public Text killability;
    public static bool visible;
    public static bool killable;

    void Update()
    {
        if (visible)
        {
            visibility.text = "Enemy can see you";
            killability.text = "";
        }
        else
        {
            visibility.text = "Enemy can't see you";
            if (killable)
            {
                killability.text = "Press (F) to kill";
            }
            else
            {
                killability.text = "";
            }
        }
    }
}
