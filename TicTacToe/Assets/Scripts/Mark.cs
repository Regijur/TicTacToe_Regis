using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mark : MonoBehaviour
{
    public Text text;
    public MyGameController controller;
    public SetButtons buttons;
    private int index;
    public Button button;
    public Score score;
    private int buttonsOff = 0;
    public void MarkSpace()
    {
       

        index = buttons.Buttons.IndexOf(button);
        if (!buttons.turn)
        {
            text.text = "O";
            controller.Player1.RemoveAt(index);
            controller.Player1.Insert(index, "1");
        }
        else
        {
            text.text = "X";
            controller.Player2.RemoveAt(index);
            controller.Player2.Insert(index, "1");
        }
        button.interactable = false;
        buttons.turn = !buttons.turn;
        buttons.ChangeTurn();

        foreach(Button b in buttons.Buttons)
        {
            if (b.interactable == false) buttonsOff++;
        }
        
        if (buttons.Win(controller.Player1)) score.RestartGame(0);
        if (buttons.Win(controller.Player2)) score.RestartGame(1);
        
        if (buttonsOff == 9 && !buttons.Win(controller.Player1) && !buttons.Win(controller.Player2)) score.RestartGame(2);
        
    }
}
