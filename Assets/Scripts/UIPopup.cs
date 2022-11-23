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

        [SerializeField] private GameObject triggerZone;

        [SerializeField] private GameObject playerCharacter;
        [SerializeField] private Camera playerCamera;
        
        private Vector3 playerCharacterPosition;
        private bool uiVisable;

        [SerializeField] private float respawnVectorX;
        [SerializeField] private float respawnVectorY;
        [SerializeField] private float respawnVectorZ;

        private void Start()
        {
            uiVisable = false;
            playerCamera.enabled = false;
        }

        // Method that starts on collision with the UIPopupZone
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("The UI Popup zone is triggered");
            
            // Sets the UI object (Image) as active abnd therfore shows it on screen
            tutorialPopup.SetActive(true);
            
            uiVisable = true;

            respawnVectorX = playerCharacter.transform.position.x;
            respawnVectorY = playerCharacter.transform.position.y;
            respawnVectorZ = playerCharacter.transform.position.z;

            playerCharacter.GetComponent<CharacterController>().enabled = false;
            playerCharacter.GetComponent<PlayerMovement>().enabled = false;
            playerCharacter.GetComponent<CapsuleCollider>().enabled = false;
            playerCharacter.GetComponent<BoxCollider>().enabled = false;
            playerCharacter.GetComponent<Rigidbody>().useGravity = false;

            playerCharacter.transform.position = new Vector3(respawnVectorX, respawnVectorY, respawnVectorZ);

        }
        private void Update()
        {
            if (uiVisable == true)
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    Debug.Log("The popup is disabled");
                    tutorialPopup.SetActive(false);
                    uiVisable = false;
                    triggerZone.SetActive(false);
                    playerCharacter.GetComponent<CharacterController>().enabled = true;
                    playerCharacter.GetComponent<PlayerMovement>().enabled = true;
                }
            }
        }
    }
}
