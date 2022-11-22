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
        [SerializeField] private Scene currentScene;

        [SerializeField] private GameObject playerCharacter;

        // Method that is called when a collision is detected
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Collision with Spikes");

            //new playerCharacter();
            //playerCharacter.Destroy;

            // Getting the current scene name from the Unity SceneManager
            //currentScene = SceneManager.GetActiveScene();
            //Debug.Log("The current scene is set to " + currentScene.name);

            //soundManager.killedBySpikes = true;

            // Reloading the current scene
            //SceneManager.LoadScene(currentScene.name);
            //Debug.Log("The scene has been reset");
        }
    }
}
