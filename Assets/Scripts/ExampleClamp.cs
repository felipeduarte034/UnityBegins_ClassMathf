using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClamp : MonoBehaviour
{
    public float value = 0f;
    public float min = 1f;
    public float max = 3f;
    public float m_Return = 0f;

    void Update()
    {
        //transform.position = new Vector3(Mathf.Clamp(Time.time, 1.0F, 3.0F), 0, 0);
        value = Time.time;
        transform.position = new Vector3(m_Return = Mathf.Clamp(value, min, max), 0, 0);
    }
}
