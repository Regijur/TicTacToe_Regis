using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButtons : MonoBehaviour
{
    public bool turn = false;
    public List<Button> Buttons;
    public MyGameController controller;
    public Text Turn;

    private void Start()
    {
        controller.Player1.Clear();
        controller.Player2.Clear();
        
        for(int i = 0; i < 9; i++)
        {
            controller.Player1.Add("0");
            controller.Player2.Add("0");
        }
    }

    public void ChangeTurn()
    {
        if(controller.round % 2 != 0)
        {
            if (!turn) Turn.text = "Player 1 joga!";
            else Turn.text = "Player 2 joga!";
        }
        else
        {
            if (!turn) Turn.text = "Player 2 joga!";
            else Turn.text = "Player 1 joga!";
        }    
    }

    public bool Win(List<string> Player)
    {
        string[] values = Player.ToArray();
        for (int i = 0; i < controller.Win.Count; i++)
        {
            int sum = 0;
            char[] numbers = controller.Win[i].ToCharArray();
            for (int h = 0; h < numbers.Length; h++)
            {
                int index = int.Parse(numbers[h].ToString());
                if (values[index] == "1") sum++;
                
            }               
            
            if (sum == 3)
            {
                return true;
            }

        }
        return false;
    }

}
