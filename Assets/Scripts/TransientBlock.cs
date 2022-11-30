using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace NathanHoward
{
    public class TransientBlock : MonoBehaviour
    {
        [SerializeField] private GameObject block;
        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;

        private void Start()
        {
            BroadcastMessage("TurnTangible");
        }

        private void TurnIntangible()
        {
            if (block.GetComponent<BoxCollider>().enabled == true)
            {
                block.GetComponent<BoxCollider>().enabled = false;
                block.GetComponent<MeshRenderer>().material = intangibleMaterial;
            }
            
        }

        private void TurnTangible()
        {
            if (block.GetComponent<BoxCollider>().enabled == false)
            {
                block.GetComponent<BoxCollider>().enabled = true;
                block.GetComponent<MeshRenderer>().material = tangibleMaterial;
            }
        }
    }
}