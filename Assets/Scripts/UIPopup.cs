using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace NathanHoward
{
    public class UIPopup : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("The UI Popup zone is triggered");
        }
    }
}
