using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class YarraScript : MonoBehaviour
{
    public int exp;
    int weaponDamage;
    string weaponName;
    int newWeaponDamage;

    [SerializeField] int currentPosition; //private this when done

    public bool isBusy;

    string monName;
    int enemyHP;


    [SerializeField] MapScript mapScript;
    [SerializeField] DialogMan dialogMan;

    [SerializeField] RoomType[] roomTypeArray;
    [SerializeField] WeaponType[] weaponTypeArray;
    [SerializeField] EnemyType[] enemyTypeArray;

    [SerializeField] List<EnemyType> enemyTypeList;
    [SerializeField] List<WeaponType> weaponTypeList;


    private void Start()
    {
        currentPosition = 0;
        exp = 0;
        weaponDamage = 2;
        IsBusy(false);
        roomTypeArray = RoomAssigner();
        weaponTypeArray = WeaponAssigner();
        enemyTypeArray = EnemyAssigner();
        enemyTypeList = enemyTypeArray.ToList();
        weaponTypeList = weaponTypeArray.ToList();
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

        if (currentPosition >= 28)
        {
             currentPosition = 27;
             //mapScript.NewRoom(27);
             //return;
        }

        mapScript.NewRoom(currentPosition);
        IsBusy(false);
    }

    void FinalEncounter()
    {
        if (exp >= 8)
        {
            dialogMan.RoomInt(4);
            monName = "Dragon";
            enemyHP = 10;
            dialogMan.NewHP(enemyHP);
            dialogMan.NewEnemySprite(monName);
            dialogMan.NewDialog("You encountered a " + monName + "!");
        }
        else
        {
            dialogMan.NewDialog("Alas, the dragon’s eyes stare at you and places you under his spell. " +
                "You try to move but fail to do so and find yourself torched by the dragon’s fire. " +
                "If only you had more experience, you could have seen it coming.");
            dialogMan.NewEnemySprite("Dragon");
            dialogMan.GameOver();

        }
    }

    public void Attack()
    {
        int damage = Random.Range(1, 7) + weaponDamage;
        dialogMan.NewRoll(damage);
        if (damage >= enemyHP) 
        {
            exp++;
            dialogMan.HideSprites();
            dialogMan.ExpUpdate(exp);
            if(currentPosition == 27)
            {
                dialogMan.NewDialog("Due to your cunning and experience, you have defeated the deadly dragon. " +
                    "Your quest has ended good sir. You’ve obtained the Chalice of knowledge and all of earth’s mysteries are revealed.");
                dialogMan.GameOver();
            }
        }
        else
        {
            dialogMan.NewDialog("You Died...");
            dialogMan.GameOver();
        }
    }   

    public void NewWeapon()
    {
        weaponDamage = newWeaponDamage;
        dialogMan.WeaponUpdate(weaponDamage, weaponName);
        dialogMan.CloseDialogBox();
    }

    void Encounter()
    {
        if(currentPosition >= 28)
        {
            FinalEncounter();
            return;
        }
        int x = Random.Range(0, enemyTypeList.Count-1);
        dialogMan.RoomInt(3);
        monName = enemyTypeList[x].ToString();
        dialogMan.NewDialog("You encountered a " + monName + "!");
        if (monName == "Dragon")
        {
            enemyHP =10;
        }
        else if (monName == "Goblin")
        {
            enemyHP = 3;
        }
        else if (monName == "Troll")
        {
            enemyHP = 5;
        }
        else if (monName == "Bandit")
        {
            enemyHP = 3;
        }
        else if (monName == "Fanatic")
        {
            enemyHP = 3;
        }
        else if (monName == "Cultist")
        {
            enemyHP = 3;
        }
        else if (monName == "Bear")
        {
            enemyHP = 4;
        }
        else if (monName == "gryphon")
        {
            enemyHP = 6;
        }
        else if (monName == "Wyvern")
        {
            enemyHP = 7;
        }
        else if (monName == "Harpy")
        {
            enemyHP = 4;
        }
        else if (monName == "Mimic")
        {
            enemyHP = 5;
        }
        else if (monName == "Karen")
        {
            enemyHP = 6;
        }
        else if (monName == "AnimatedWeapon")
        {
            enemyHP = 3;
        }
        else if (monName == "Fire Elemental")
        {
            enemyHP = 5;
        }
        else if (monName == "Depression")
        {
            enemyHP = 7;
        }
        dialogMan.NewHP(enemyHP);
        dialogMan.NewEnemySprite(monName);
        enemyTypeList.RemoveAt(x);
    }

    void Rest()
    {
        dialogMan.RoomInt(1);
        dialogMan.NewDialog("There is nothing for you to do, so you reflect upon your adventures thus far. \n(You take the time to train and enchance your reflexes)");
    }

    void Loot()
    {
        int x = Random.Range(0, weaponTypeList.Count);
        weaponName = weaponTypeList[x].ToString();
        dialogMan.RoomInt(2);
        if (weaponName == "Crossbow")
        {
            newWeaponDamage = 3;
        }
        else if (weaponName == "Flail")
        {
            newWeaponDamage = 4;
        }
        else if (weaponName == "BroadSword")
        {
            newWeaponDamage = 5;
        }
        else if (weaponName == "DragonSlayer")
        {
            newWeaponDamage = 6;
        }
        else if (weaponName == "SpellOfTheGods")
        {
            newWeaponDamage = 7;
        }

        dialogMan.NewDialog("You stumble upon a " + weaponName + " +" + newWeaponDamage + ". \n Will you replace your current weapon with the " + weaponName + "?");
        weaponTypeList.RemoveAt(x);
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


