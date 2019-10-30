using UnityEngine;

public class GameMaster : MonoBehaviour
{

    public static int currentScore = 0;

    public float offsetY = 40;
    public float sizeX = 100;
    public float sizeY = 40;

    private void Start()
    {
        currentScore = 0;
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2 - sizeX / 2, offsetY, sizeX, sizeY), "Score: " + currentScore);
    }
}
