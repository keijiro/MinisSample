using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.VFX;

class TriggerTest : MonoBehaviour
{
    public InputAction testAction;

    void Start() => testAction.Enable();

    void Update()
    {
        if (testAction.triggered)
            GetComponent<VisualEffect>().Play();
    }
}
