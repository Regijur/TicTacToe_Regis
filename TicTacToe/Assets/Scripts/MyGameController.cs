using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game Controller", menuName = "S.O", order = 0)]
public class MyGameController : ScriptableObject
{
    public List<string> Player1 = new List<string>(9);
    public List<string> Player2 = new List<string>(9);
    public List<string> Win;
    public int round = 1;
    public int PW1 = 0;
    public int PW2 = 0;
    public int draw = 0;
}
