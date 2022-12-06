using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace NathanHoward
{
    public class TransientBlock : MonoBehaviour
    {
        // Declaration of the blocks that will toggle tangibility
        [SerializeField] private GameObject block;

        // Declaration of the two materials used to show tangibility
        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;

        // This starts when the script is enabled
        private void OnEnable()
        {
            // Subscribing to the OnTangibleBlockButtonPressEvent event
            GameEvents.OnTangibleBlockButtonPressEvent += ToggleTangible;
        }

        // This starts when the script is disabled
        private void OnDisable()
        {
            // Unsubscribing to the OnTangibleBlockButtonPressEvent event
            GameEvents.OnTangibleBlockButtonPressEvent -= ToggleTangible;
        }

        // Method called to toggle tangibility
        private void ToggleTangible()
        {
            // If statement checks current block status
            if (block.GetComponent<BoxCollider>().enabled == true)
            {
                // Turning the block intangible (Changing material and disabling the box collider)
                block.GetComponent<BoxCollider>().enabled = false;
                block.GetComponent<MeshRenderer>().material = intangibleMaterial;
            }
            else if (block.GetComponent<BoxCollider>().enabled == false)
            {
                // Turning the block tangible (Changing material and enabling the box collider)
                block.GetComponent<BoxCollider>().enabled = true;
                block.GetComponent<MeshRenderer>().material = tangibleMaterial;
            }
        }
    }
}