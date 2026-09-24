using UnityEngine;
using UnityEngine.Events;

public class ExploringUnityEvents : MonoBehaviour
{
    /* defining a new Unity Event 
     * [SerializeField] acts similar to @export in Godot for private variables
     * Static ties the variable to the class and not a specific
     * object with the variable */
    public static UnityEvent onSpaceBarPressed = new UnityEvent();
    
}
