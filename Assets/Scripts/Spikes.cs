using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NathanHoward
{
    public class Spikes : MonoBehaviour
    {
        // Scene variable that reloads the current scene
        //private Scene currentScene;

        // Declaration of the Player Character and the respawn paoint
        [SerializeField] private GameObject playerCharacter;
        [SerializeField] private GameObject respawnPointGameObject;

        // Declaration of the variables needed to respawn the player
        [SerializeField] private float respawnVectorX;
        [SerializeField] private float respawnVectorY;
        [SerializeField] private float respawnVectorZ;

        // Declaration of the Sound Effect used
        [SerializeField] private AudioSource spikeSoundEffect;

        // Method that sets the Vector positions (X,Y,Z) based on the respawnPointGameObject position
        private void Start()
        {
            // Seting the x,y and z values
            respawnVectorX = respawnPointGameObject.transform.position.x;
            respawnVectorY = respawnPointGameObject.transform.position.y;
            respawnVectorZ = respawnPointGameObject.transform.position.z;
            Debug.Log("The X, Y and Z have been set.");
        }

        // Method that is called when a collision is detected
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Collision with Spikes");

            // OLD SCRIPT THAT RESETS SCENE
            // Getting the current scene name from the Unity SceneManager
            //currentScene = SceneManager.GetActiveScene();
            //Debug.Log("The current scene is set to " + currentScene.name);
            // Reloading the current scene
            //SceneManager.LoadScene(currentScene.name);
            //Debug.Log("The scene has been reset");

            // Disabling the player movement, setting the player position and then re enabling the player movement
            playerCharacter.GetComponent<CharacterController>().enabled = false;
            playerCharacter.GetComponent<PlayerMovement>().enabled = false;
            playerCharacter.transform.position = new Vector3(respawnVectorX, respawnVectorY, respawnVectorZ);
            playerCharacter.GetComponent<CharacterController>().enabled = true;
            playerCharacter.GetComponent<PlayerMovement>().enabled = true;

            // Plays the sound effect attached to the script
            spikeSoundEffect.Play();
        }
    }
}
