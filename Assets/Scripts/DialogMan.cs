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
        WeaponModifier.text = newWeaponDamage.ToString();
        WeaponName.text = newWeaponName;        
    }
}
