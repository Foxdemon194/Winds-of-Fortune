using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class YarraScript : MonoBehaviour
{
    public int exp;
    public static int weaponDamage;

    [SerializeField] int currentPosition; //private this when done

    public bool isBusy;

    int crossbow = 3;
    int flail = 4;
    int broadSword = 5;
    int dragonSlayer = 6;
    int spellOfTheGods = 7;

    string monName;


   [SerializeField] MapScript mapScript;
    [SerializeField] DialogMan dialogMan;

    [SerializeField] RoomType[] roomTypeArray;
    [SerializeField] WeaponType[] weaponTypeArray;
    [SerializeField] EnemyType[] enemyTypeArray;

    [SerializeField] List<EnemyType> enemyTypeList;


    private void Start()
    {
        currentPosition = 0;
        exp = 0;
        weaponDamage = 0;
        IsBusy(false);
        roomTypeArray = RoomAssigner();
        weaponTypeArray = WeaponAssigner();
        enemyTypeArray = EnemyAssigner();
        enemyTypeList = enemyTypeArray.ToList();
    }

    public void Dismount()
    {
        if (isBusy == false)
        {
            if (roomTypeArray[currentPosition] == RoomType.Boss)
            {
                FinalEncounter();
            }
            else if (roomTypeArray[currentPosition] == RoomType.Weapon)
            {
                Loot();
            }
            else if (roomTypeArray[currentPosition] == RoomType.Rest)
            {
                Rest();
            }
            else if (roomTypeArray[currentPosition] == RoomType.Encounter)
            {
                Encounter();
            }
            else
            {
                throw new System.Exception("Dismount didn't identify a known room type");
            }
        }
        IsBusy(true);
    }

    private  RoomType[] RoomAssigner()
    {
        List<int> indexList = Enumerable.Range(0, 27).ToList();
        RoomType[] roomTypeArray = Enumerable.Repeat(RoomType.Encounter, 28).ToArray();
        for (int i = 0; i < 5; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            roomTypeArray[indexList[randIndex]] = RoomType.Weapon;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 7; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            roomTypeArray[indexList[randIndex]] = RoomType.Rest;
            indexList.RemoveAt(randIndex);
        }
        roomTypeArray[27] = RoomType.Boss;
        return roomTypeArray; 
    }

    private WeaponType[] WeaponAssigner()
    {
        List<int> indexList = Enumerable.Range(0, 5).ToList();
        WeaponType[] weaponTypeArray = Enumerable.Repeat(WeaponType.Crossbow, 5).ToArray();
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            weaponTypeArray[indexList[randIndex]] = WeaponType.Flail;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            weaponTypeArray[indexList[randIndex]] = WeaponType.BroadSword;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            weaponTypeArray[indexList[randIndex]] = WeaponType.DragonSlayer;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            weaponTypeArray[indexList[randIndex]] = WeaponType.SpellOfTheGods;
            indexList.RemoveAt(randIndex);
        }
        return weaponTypeArray;
    }

    private EnemyType[] EnemyAssigner()
    {
        List<int> indexList = Enumerable.Range(0, 15).ToList();
        EnemyType[] enemyTypeArray = Enumerable.Repeat(EnemyType.Goblin, 16).ToArray();
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Troll;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Troll;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Bandit;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Fanatic;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Cultist;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Bear;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Gryphon;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Wyvern;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Harpy;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Mimic;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Karen;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.AnimatedWeapon;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.FireElemental;
            indexList.RemoveAt(randIndex);
        }
        for (int i = 0; i < 1; i++)
        {
            int randIndex = Random.Range(0, indexList.Count);
            enemyTypeArray[indexList[randIndex]] = EnemyType.Depression;
            indexList.RemoveAt(randIndex);
        }
        enemyTypeArray[15] = EnemyType.Dragon;

        return enemyTypeArray;
    }

    public void Travel()
    {
            int movement = Random.Range(1, 7);
            currentPosition += movement;
            if (currentPosition > 26)
            {
                currentPosition = 26;
                mapScript.NewRoom(27);
                return;
            }
            mapScript.NewRoom(currentPosition);
        IsBusy(false);
    }

    void FinalEncounter()
    {

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

    void Encounter()
    {
        int i = Random.Range(0, enemyTypeList.Count);
        dialogMan.RoomInt(3);
        monName = enemyTypeList[i].ToString();
        dialogMan.NewDialog("You encountered a " + monName + "!");
        enemyTypeList.RemoveAt(i);
    }

    void Rest()
    {
        dialogMan.RoomInt(1);
        dialogMan.NewDialog("There is nothing for you to do, so you reflect upon your adventures thus far. \n(You take the time to train and enchance your reflexes)");
    }

    void Loot()
    {
        dialogMan.RoomInt(2);
        //make a variable that randomly selects a weapon
        dialogMan.NewDialog("You stumble upon a "  );
        Debug.Log("Loot was selected");
    }

    public void IsBusy(bool isItBusy)
    {
        isBusy = isItBusy;
    }

    public void TrueRestButton()
    {
        exp++;
        dialogMan.ExpUpdate(exp);
    }



}

public enum RoomType
{
    Rest,
    Weapon,
    Encounter,
    Boss
}

public enum WeaponType
{
    Crossbow,
    Flail,
    BroadSword,
    DragonSlayer,
    SpellOfTheGods
}

public enum EnemyType
{
    Goblin,
    Troll,
    Bandit,
    Fanatic,
    Cultist,
    Bear,
    Gryphon,
    Wyvern,
    Harpy,
    Mimic,
    Karen,
    AnimatedWeapon,
    FireElemental,
    Depression,
    Dragon
}


