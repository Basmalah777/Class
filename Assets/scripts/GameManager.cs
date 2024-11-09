using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        Player player = new Player("Subhi", 70);
        Enemy enemy = new Enemy("Zarifeh", 90);


        Debug.Log("Player: " + player.Name + ", Health: " + player.Health);
        Debug.Log("Enemy: " + enemy.Name + ", Health: " + enemy.Health);


        player.heal(15);
        Debug.Log("After healing - " + player.Name + "'s health: " + player.Health);

        enemy.Attack(player, 20);
        Debug.Log("After attack - " + player.Name + "'s health: " + player.Health);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
