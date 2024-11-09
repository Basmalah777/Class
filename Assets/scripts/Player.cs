using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    // Actually, I know what the error was, I learned it before, so I fixed it...
    // Constructor to inherit from Character
    public Player(string name, int health) : base(name, health) { }


    public void heal(int amount)
    {
        Health += amount;
        Debug.Log(Name + " has healed. New Health: " + Health);
    }
}
