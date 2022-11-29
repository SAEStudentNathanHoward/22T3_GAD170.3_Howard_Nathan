using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace NathanHoward
{
    public class UIPopup : MonoBehaviour
    {
        // The declaration of the GameObject (image) used to show on the trigger
        [SerializeField] private GameObject tutorialPopup;

        // Declaration of the trigger zone
        [SerializeField] private GameObject triggerZone;

        // Declaration of the PlayerCharacter game object
        [SerializeField] private GameObject playerCharacter;
        
        // Declaration of the bool used to check if there is a display currently up
        private bool uiVisable = false;

        // Method that starts on collision with the UIPopupZone
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("The UI Popup zone is triggered");
            
            // Sets the UI object (Image) as active and therfore shows it on screen
            tutorialPopup.SetActive(true);
            uiVisable = true;

            // Turns the time off freeezing the players input
            Time.timeScale = 0;

            // Turns the PlayerMovement script off to stop cammera change
            playerCharacter.GetComponent<PlayerMovement>().enabled = false;

        }

        // Update method will constantly check if the UI is visable and if the button is return pressed
        private void Update()
        {
            if (uiVisable == true && Input.GetKeyDown(KeyCode.Return))
            {
                // Disables all of the UI Popups and deletes the game object
                tutorialPopup.SetActive(false);
                uiVisable = false;
                triggerZone.SetActive(false);
                Debug.Log("The popup is disabled");

                // Re-enables player and camera movement
                playerCharacter.GetComponent<PlayerMovement>().enabled = true;
                Time.timeScale = 1;
            }
        }
    }
}
