using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponExample : MonoBehaviour
{
    private delegate void MyDelegate();
    private MyDelegate onClick;

    private void Start()
    {
        onClick += ShootGun;
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {

        }
    }

    private void ShootGun()
    {

    }
}
