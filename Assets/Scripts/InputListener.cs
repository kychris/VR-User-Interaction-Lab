using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.Events;

public class InputListener : MonoBehaviour
{
    public XRNode controllerNode;
    List<InputDevice> inputDevices;

    [Tooltip("Event when the button starts being pressed")]
    public UnityEvent OnPress;

    [Tooltip("Event when the button starts being released")]
    public UnityEvent OnRelease;

    bool isPressed = false;

    // Awake will be called even if script is disabled
    private void Awake()
    {
        inputDevices = new List<InputDevice>();
    }

    // Start is called before the first frame update
    void Start()
    {
        GetDevice();
    }

    // Update is called once per frame
    void Update()
    {
        GetDevice();
        foreach (InputDevice device in inputDevices)
        {
            if (device.isValid)
            {
                bool inputValue;
                if (device.TryGetFeatureValue(CommonUsages.secondaryButton, out inputValue) && inputValue)
                {
                    if (!isPressed)
                    {
                        isPressed = true;
                        Debug.Log("OnPress event is called");
                        OnPress.Invoke();
                    }
                }
                else if (isPressed)
                {
                    isPressed = false;
                    OnRelease.Invoke();
                    Debug.Log("OnRelease event is called");
                }
            }
        }
    }

    void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(controllerNode, inputDevices);
    }
}
