using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NathanHoward
{ 
    public class TransientBlockButtonPress : MonoBehaviour
    {
        // Declaration of the GameObjects used in this code
        // Serialized so I can set them in the inspector
        [SerializeField] private GameObject playerCharacter;
        [SerializeField] private GameObject buttonInstruction;

        // Boolean used to tell whether the player is in contact with the buttons zone
        public bool playerIsClose = false;

        // Update method to check for button presses
        private void Update()
        {
            // Checks to make sure the player is close AND pressing the activate button
            if (Input.GetKeyDown(KeyCode.Return) && playerIsClose == true && GameEvents.OnTangibleBlockButtonPressEvent != null)
            {
                Debug.Log("The enter key has been pressed.");
                Debug.Log("the button is pressed");
                
                //Announcing the block toggler to our events script
                GameEvents.OnTangibleBlockButtonPressEvent();
               
            }
        }

        // Checks to see if the player has entered the button trigger zone
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

