using UnityEngine;
using UnityEngine.InputSystem;

class ReadValueTest : MonoBehaviour
{
    public InputAction testAction;

    void Start() => testAction.Enable();

    void Update()
    {
        var knob = testAction.ReadValue<float>();
        transform.localScale = Vector3.one * knob;
    }
}
