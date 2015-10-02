using UnityEngine;
using System.Collections;

public class BouncingColumns : MonoBehaviour
{

    public float speed;
    public float maxBounce;
    public float minBounce;
    public float initialDirection;

    private float sumBounce;


    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;
        Vector3 newPosition = transform.position;
        sumBounce += step;
        newPosition.y += step * GetDirection();
        transform.position = newPosition;
    }

    private float GetDirection()
    {
        if (sumBounce > maxBounce)
        {
            initialDirection = initialDirection * -1;
            sumBounce = 0;
        }

        return initialDirection;
    }
}
