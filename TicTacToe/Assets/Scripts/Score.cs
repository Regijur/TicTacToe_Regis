using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public MyGameController controller;
    public SetButtons buttons;
    public Text Player1;
    public Text Player2;
    public Text Draw;
    public Text Turn;

    private void Start()
    {
        if(controller.round == 1)
        {
            controller.PW1 = 0;
            controller.PW2 = 0;
            controller.draw = 0;
        }
        Turn.text = "Player 1 joga";
        Player1.text = controller.PW1.ToString();
        Player2.text = controller.PW2.ToString();
        Draw.text = controller.draw.ToString();
    }

    public void RestartGame(int winner)
    {
        switch (winner)
        {
            case 0:
                if (controller.round % 2 != 0)
                {
                    controller.PW1++;
                    Player1.text = (int.Parse(Player1.text) + 1).ToString();
                }
                else
                {
                    controller.PW2++;
                    Player2.text = (int.Parse(Player2.text) + 1).ToString();
                }
                break;
            case 1:
                if (controller.round % 2 != 0)
                {
                    controller.PW2++;
                    Player2.text = (int.Parse(Player2.text) + 1).ToString();
                }
                else
                {
                    controller.PW1++;
                    Player1.text = (int.Parse(Player1.text) + 1).ToString();
                }
                break;
            case 2:
                controller.draw++;
                Draw.text = (int.Parse(Draw.text) + 1).ToString();
                break;
        }
        controller.round++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
