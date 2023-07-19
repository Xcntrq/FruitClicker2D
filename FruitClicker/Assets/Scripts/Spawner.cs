using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float CD;
    public GameObject Fruit;
    public float MinX;
    public float MaxX;

    private float _timer;

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer < 0)
        {
            _timer = CD;

            Vector2 pos = transform.position;
            pos.x = Random.Range(MinX, MaxX);
            transform.position = pos;

            Instantiate(Fruit, transform.position, transform.rotation);
        }
    }
}