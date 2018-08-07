using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMoveTowards : MonoBehaviour
{
    public float currStrength;
    public float maxStrength;
    public float recoveryRate;
    void Update()
    {
        currStrength = Mathf.MoveTowards(currStrength, maxStrength, recoveryRate * Time.deltaTime);
    }
}
