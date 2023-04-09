using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogMan : MonoBehaviour
{
    public Text dialog;
    public Text expText;
    public Text hpText;
    public Text rollText;
    public Text WeaponName;
    public Text WeaponModifier;

    public GameObject dialogBox;
    public GameObject restButton;
    public GameObject weaponButton;
    public GameObject encounterButton;
    public GameObject continueButton; //assign me
    public GameObject gameOverButton; //asignme

    public GameObject spriteGoblin;
    public GameObject spriteTroll;
    public GameObject spriteBandit;
    public GameObject spriteFanatic;
    public GameObject spriteCultist;
    public GameObject spriteBear;
    public GameObject spriteGryphon;
    public GameObject spriteWyvern;
    public GameObject spriteHarpy;
    public GameObject spriteMimic;
    public GameObject spriteKaren;
    public GameObject spriteAnimatedWeapon;
    public GameObject spriteFireElemental;
    public GameObject spriteDepression;
    public GameObject spriteDragon;



    //[SerializeField] YarraScript yarraScript;


    public int roomType; //1 = Rest, 2 = weapon, 3 = encounter, 4 = boss

    public void RoomInt(int roomNum)
    {
        roomType = roomNum;
    }

    public void NewDialog(string newText)
    {
        dialogBox.SetActive(true);

        if (roomType == 1)
        {
            restButton.SetActive(true);
            weaponButton.SetActive(false);
            encounterButton.SetActive(false);
        }
        else if(roomType == 2)
        {
            weaponButton.SetActive(true);
            restButton.SetActive(false);
            encounterButton.SetActive(false);
        }
        else if(roomType == 3)
        {
            encounterButton.SetActive(true);
            restButton.SetActive(false);
            weaponButton.SetActive(false);
        }
        else if(roomType == 4)
        {
            restButton.SetActive(false);
            weaponButton.SetActive(false);
            encounterButton.SetActive(true);
            
        }
        else
        {
            Debug.Log("NewDialog had a number it wasn't supposed to have");
        }
        dialog.text = newText;        
    }

    public void NewRoll(int newRoll)
    {
        rollText.text = "Roll: \n" + newRoll.ToString();
    }

    public void NewHP(int newHP)
    {
        hpText.text = "Enemy HP: \n" + newHP.ToString();
    }


    public void CloseDialogBox()
    {
        dialogBox.SetActive(false);
        HideSprites();
    }

    public void HideSprites()
    {
        spriteGoblin.SetActive(false);
        spriteTroll.SetActive(false);
        spriteBandit.SetActive(false); ;
        spriteFanatic.SetActive(false);
        spriteCultist.SetActive(false);
        spriteBear.SetActive(false);
        spriteGryphon.SetActive(false);
        spriteWyvern.SetActive(false);
        spriteHarpy.SetActive(false);
        spriteMimic.SetActive(false);
        spriteKaren.SetActive(false);
        spriteAnimatedWeapon.SetActive(false);
        spriteFireElemental.SetActive(false);
        spriteDepression.SetActive(false);
        spriteDragon.SetActive(false);
    }

    public void NewEnemySprite(string eName)
    {
        if(eName == "Goblin")
        {
            spriteGoblin.SetActive(true);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
}
        else if(eName == "Troll")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(true);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "Bandit")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(true); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "Fanatic")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(true);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "Cultist")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(true);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "Bear")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(true);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "Gryphon")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(true);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "Wyvern")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(true);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "Harpy")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(true);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "Mimic")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(true);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "Karen")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(true);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "AnimatedWeapon")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(true);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "FireElemental")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(true);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(false);
        }
        else if (eName == "Depression")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(true);
            spriteDragon.SetActive(false);
        }
        else if (eName == "Dragon")
        {
            spriteGoblin.SetActive(false);
            spriteTroll.SetActive(false);
            spriteBandit.SetActive(false); ;
            spriteFanatic.SetActive(false);
            spriteCultist.SetActive(false);
            spriteBear.SetActive(false);
            spriteGryphon.SetActive(false);
            spriteWyvern.SetActive(false);
            spriteHarpy.SetActive(false);
            spriteMimic.SetActive(false);
            spriteKaren.SetActive(false);
            spriteAnimatedWeapon.SetActive(false);
            spriteFireElemental.SetActive(false);
            spriteDepression.SetActive(false);
            spriteDragon.SetActive(true);
        }
    }

    public void ExpUpdate(int newExp)
    {
        expText.text = newExp.ToString();
        restButton.SetActive(false);
        dialogBox.SetActive(false);
    }

    public void GameOver()
    {
        restButton.SetActive(false);
        weaponButton.SetActive(false);
        encounterButton.SetActive(false);
        continueButton.SetActive(false);
        gameOverButton.SetActive(true);
    }

    public void WeaponUpdate(int newWeaponDamage, string newWeaponName)
    {
        WeaponModifier.text = "+" + newWeaponDamage.ToString();
        WeaponName.text = newWeaponName;        
    }
}
