using UnityEngine;

public class Fruit : MonoBehaviour
{
    public float AngleDiv;
    public float MinSpeed;
    public float MaxSpeed;

    public bool isda;

    private void Start()
    {
        float zRot = Random.Range(-AngleDiv, AngleDiv);
        transform.Rotate(0, 0, zRot);
        float force = Random.Range(MinSpeed, MaxSpeed);
        GetComponent<Rigidbody2D>().velocity = transform.up * force;

    }

    private void Update()
    {
        if (!isda)
        {
            isda = true;
        }
    }
}