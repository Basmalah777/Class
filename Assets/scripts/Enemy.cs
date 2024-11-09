using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health) { }
    public void Attack(Character victim, int damage)
    {
        if (victim.Health - damage < 0)
        {
            victim.Health = 0;
        }
        else
        {
            victim.Health -= damage;
        }
        Debug.Log(Name + " attacked " + victim.Name + ". " + victim.Name + " new Health: " + victim.Health);
    }
}
