using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NathanHoward
{
    public class SpotlightHazard : MonoBehaviour
    {
        // Declaration of the spotlight and the player character used for tracking and collision
        [SerializeField] private GameObject thisSpotlight;
        [SerializeField] private GameObject playerCharacter;

        [SerializeField] private Material spotlightRedMaterial;
        [SerializeField] private Material spotlightYellowMaterial;

        private Color spotlightColorRed = new Color(1f, 0f, 0.0319f, 1f);
        private Color spotlightColorYellow = new Color(1f, 0.764f, 0f, 1f);

        // Declaration and setting a bool for wether the character is seen or not
        private bool isPlayerCharacterSeen = false;

        // Method for when the collision is triggered
        private void OnTriggerEnter(Collider other)
        {
            // Debug log for testing
            Debug.Log("You are in a spotlight");
            
            // Changing of the bool to change Update method
            isPlayerCharacterSeen = true;
        }

        // Method for when the collision is no longer detected
        private void OnTriggerExit(Collider other)
        {
            // Debug log for testing
            Debug.Log("You have left a spotlight");

            // Changing the bool to change the Update method
            isPlayerCharacterSeen = false;
        }

        // Constantly updating
        private void Update()
        {
            // checking to make sure the character is trigering the collision 
            if (isPlayerCharacterSeen == true)
            {
                // Constantly updating the lights transform to look at the player character
                thisSpotlight.transform.LookAt(playerCharacter.transform);

                thisSpotlight.GetComponentInParent<Light>().color = spotlightColorRed;
                thisSpotlight.GetComponentInChildren<MeshRenderer>().material = spotlightRedMaterial;
                
            }
            else
            {
                thisSpotlight.GetComponentInParent<Light>().color = spotlightColorYellow;
                thisSpotlight.GetComponentInChildren<MeshRenderer>().material = spotlightYellowMaterial;
            }
        }
    }
}