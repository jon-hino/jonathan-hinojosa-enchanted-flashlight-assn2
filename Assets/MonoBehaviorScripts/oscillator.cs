using UnityEngine;

public class Oscillator : MonoBehaviour
{

    public float amplitude = 2f;


    public float frequency = 1f;

    public Vector3 movementAxis = Vector3.up;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float wave = Mathf.Sin(Time.time * Mathf.PI * 2f * frequency);

        float offset = wave * amplitude;

        transform.position = startPosition + (movementAxis.normalized * offset);
    }
}

