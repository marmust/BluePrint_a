using UnityEngine;

public class NOT_gate : MonoBehaviour
{
    public gate_input Input;
    public gate_input outputCable;

    public bool state;

    public bool output;

    private void Update()
    {
        state = Input.connectedObject.GetComponent<cable_drawer>().electrified;

        outputCable.connectedObject.GetComponent<cable_drawer>().electrified = output;

        output = !state;
    }
}