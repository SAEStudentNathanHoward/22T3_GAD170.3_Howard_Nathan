using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace NathanHoward
{
    public class ButtonPress : MonoBehaviour
    {
        // Declaration of the GameObjects used in this code
        // Serialized so I can set them in the inspector
        [SerializeField] private GameObject playerCharacter;
        [SerializeField] private GameObject laserGrid;
        [SerializeField] private GameObject buttonInstruction;

        // Boolean used to tell whether the player is in contact with the buttons zone
        public bool playerIsClose = false;

        // Update method to check for button presses
        private void Update()
        {
            // Checks to make sure the player is close AND pressing the activate button
            if (Input.GetKeyDown(KeyCode.Return) && playerIsClose == true)
            {
                Debug.Log("The enter key has been pressed.");
                Debug.Log("the button is pressed");

                // Code that toggles the attached laser grid on or off
                if (laserGrid.activeSelf == true)
                {
                    laserGrid.SetActive(false);
                }
                else
                {
                    laserGrid.SetActive(true);
                }
            }
        }

        // Checks to see if the player has enterd the button trigger zone
        private void OnTriggerEnter(Collider other)
        {
            // Changing the bool becuase the player is close and showing the instruction text
            playerIsClose = true;
            buttonInstruction.SetActive(true);
        }

        // Checks to see if the player has exited the button trigger zone
        private void OnTriggerExit(Collider other)
        {
            // Changing the bool becuase the player is no longer close and disabling the instruction text
            playerIsClose = false;
            buttonInstruction.SetActive(false);
        }
    }
}
