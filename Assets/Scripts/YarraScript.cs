using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YarraScript : MonoBehaviour
{
    public static int exp;
    public static int weaponDamage;

    int crossbow = 3;
    int flail = 4;
    int broadSword = 5;
    int dragonSlayer = 6;
    int spellOfTheGods = 7;

    int lootEvents = 5;
    int restEvents = 7;
    int encounterEvents = 15;

    private void Start()
    {
        exp = 0;
        weaponDamage = 0;
    }

    public void Dismount()
    {
        bool amRolling = true;
        while (amRolling)
        {
            Debug.Log("I was called");
            int whatHappens = Random.Range(1, 4);
            if (whatHappens == 1 && encounterEvents >= 1)
            {
                Encounter();
                amRolling = false;

            }
            if (whatHappens == 2 && restEvents >= 1)
            {
                Rest();
                amRolling = false;
            }
            if (whatHappens == 3 && lootEvents >= 1)
            {
                Loot();
                amRolling = false;
            }
            else
            {
                Debug.Log("Dismount() encountered an error");
            }
            Debug.Log("Encounters: " + encounterEvents + " / Rests: " + restEvents + " / Loots: " + lootEvents);
        }
    }

    public int Travel()
    {
        int movement = Random.Range(1, 7);
        return movement;
    }

    public int Attack()
    {
        int damage = Random.Range(1, 7) + weaponDamage;
        return damage;
    }

    public void NewWeapon(int newDamage)
    {
        weaponDamage = newDamage;
    }

    public void AddEXP(int newExp)
    {
        exp += newExp;
    }

    void Encounter()
    {
        encounterEvents--;
        Debug.Log("Encounter was selected");
    }

    void Rest()
    {
        restEvents--;
        Debug.Log("Rest was selected");
    }

    void Loot()
    {
        lootEvents--;
        Debug.Log("Loot was selected");
    }
}


