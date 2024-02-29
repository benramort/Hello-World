using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    Enemy enemy;
    Player player;

    void Start()
    {
        Debug.Log("Hello world");
        enemy = new Enemy("Enemigooo");
        player = new Player("Jugador");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Nombre: "+enemy.name + "; Vida: " + enemy.HealthPoints);
        while (enemy.HealthPoints > 0)
        {
            player.TakeDamage();
            enemy.TakeDamage();
            Debug.Log("Enemigo: " + enemy.HealthPoints + "| Player: "+player.HealthPoints);
        }
    }
}
