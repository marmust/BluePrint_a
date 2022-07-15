using UnityEngine;

public class OR_gate : MonoBehaviour
{
    public gate_input leftInput;
    public gate_input rightInput;
    public gate_input outputCable;

    public bool leftState;
    public bool rightState;

    public bool output;

    private void Update()
    {
        leftState = leftInput.connectedObject.GetComponent<cable_drawer>().electrified;
        rightState = rightInput.connectedObject.GetComponent<cable_drawer>().electrified;

        outputCable.connectedObject.GetComponent<cable_drawer>().electrified = output;

        if (leftState == true || rightState == true)
        {
            output = true;
        }
        else
        {
            output = false;
        }
    }
}