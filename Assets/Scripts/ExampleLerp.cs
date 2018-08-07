using UnityEngine;

public class ExampleLerp : MonoBehaviour
{
    // animate the game object from -1 to +1 and back
    public float minimum = -1.0F;
    public float maximum =  1.0F;

    // starting value for the Lerp
    static float m_Time = 0.0f;
	public float m_Return = 0f;

    void Update()
    {
        // animate the position of the game object...
        transform.position = new Vector3(m_Return = Mathf.Lerp(minimum, maximum, m_Time), 2, 0);

        // .. and increate the t interpolater
        m_Time += 0.5f * Time.deltaTime;

        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (m_Time > 1.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            m_Time = 0.0f;
        }
    }
}