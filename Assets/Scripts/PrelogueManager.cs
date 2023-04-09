using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrelogueManager : MonoBehaviour
{
    public GameObject prologue;

    public void EnablePrologue()
    {
        prologue.SetActive(true);
    }

    public void DissablePrologue()
    {
        prologue.SetActive(false);
    }
}
