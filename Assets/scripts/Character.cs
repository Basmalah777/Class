using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{

    private string name;
    private int health;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Health
    {
        get { return health; }
        set
        {
            // عشان نتأكد من أن الصحه لن تتجاوز 100 ولن تقل عن 0
            if (value > 100)
            {
                health = 100;
            }
            else if (value < 0)
            {
                health = 0;
            }
            else
            {
                health = value;
            }
        }
    }
    public Character(string name, int health)
    {

        Name = name;
        Health = health;


        // this.name = name;
        //this.health = health;

    }

}
