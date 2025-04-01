using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.VFX;

class CallbackTest : MonoBehaviour
{
    public InputAction testAction;

    void Start()
    {
        testAction.Enable();
        testAction.performed +=
          _ => GetComponent<VisualEffect>().Play();
    }
}
