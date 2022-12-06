using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    // Honestly not sure what these declarations mean
    //... maybe something I need to check with Aaron?
    public delegate void VoidDelegate();

    public delegate void IntDelegate(int number);

    public static VoidDelegate OnCharacterDeathEvent;
    public static VoidDelegate OnTangibleBlockButtonPressEvent;

}
