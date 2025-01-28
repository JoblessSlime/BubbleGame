using Unity.VisualScripting;
using UnityEngine;

public class BubbleMouvement : MonoBehaviour
{
    public float speed = 5f;
    public float changeInterval = 2f;

    public float rangeMovement = 5f;


    private float startX;

    private void Start()
    {
        startX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = transform.position.y + speed * Time.deltaTime;

        float newX = startX + Mathf.Cos(Time.time * changeInterval) * rangeMovement;

        transform.position = new Vector3(newX, newY);
    }
}
