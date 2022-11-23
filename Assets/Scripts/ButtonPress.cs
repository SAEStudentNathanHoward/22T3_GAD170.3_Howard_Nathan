using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    [SerializeField] private GameObject playerCharacter;
    [SerializeField] private GameObject buttonObject;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("The enter key has been pressed.");

            if (playerCharacter.transform.position == buttonObject.transform.position)
            {
                Debug.Log("You are in front of the button.");
            }
        }
    }
}
