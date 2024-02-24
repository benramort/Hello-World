using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string name;
    private int healthPoints  = 100;
    //int vida { get; set; }
    //bool alive { get; set; }

    public Character(string s)
    {
        name = s;
        Debug.Log(name);
    }

    ~Character()
    {
        Debug.Log(name + " ha muerto");
    }

    public virtual void TakeDamage()
    {
        healthPoints--;
    }

    public int HealthPoints { get => healthPoints; set => healthPoints = value; }
}
