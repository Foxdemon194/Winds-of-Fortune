using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogMan : MonoBehaviour
{
    public Text dialog;
    public Text expText;
    public GameObject dialogBox;
    public GameObject restButton;
    public GameObject weaponButton;
    public GameObject encounterButton;


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
        }
        else if(roomType == 2)
        {
            //weaponButton.SetActive(true);
        }
        else if(roomType == 3)
        {
            //encounterButton.SetActive(true);
        }
        else
        {
            Debug.Log("NewDialog had a number it wasn't supposed to have");
        }
        dialog.text = newText;        
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

    public void WeaponUpdate()
    {

    }
}
