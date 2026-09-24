using UnityEngine;
using UnityEngine.InputSystem;

public class UnityEventSubscriber : MonoBehaviour
{
    private void OnEnable()
    {
        //Subcribing to the events we wanna use
        if (ExploringUnityEvents.onSpaceBarPressed != null)
        {
            ExploringUnityEvents.onSpaceBarPressed.AddListener(PrintMessage);
            Debug.Log("Listener Added to Print Message");
        }
        else
        {
            Debug.LogError("onSpaceBarPressed is null!");
        }
    }
    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // The question mark is to check if anything is subbed to the event
            ExploringUnityEvents.onSpaceBarPressed?.Invoke();
            Debug.Log("Space Key was pressed");
        }
    }
    private void OnDisable()
    {
        //Unsub to all events in OnEnable()
        if (ExploringUnityEvents.onSpaceBarPressed != null)
        {
            ExploringUnityEvents.onSpaceBarPressed.RemoveListener(PrintMessage);
        }
    }
    private void PrintMessage()
    {
        Debug.Log("Hello World");
    }
}
