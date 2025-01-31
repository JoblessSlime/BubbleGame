using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed = 5f;
    public float changeInterval = 2f;
    public float rangeMovement = 5f;
    public string type = "";
    public float amount = 1f;


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

    private void OnMouseDown()
    {
        PopBubble(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log($"OnTriggerExit2D : {other.name}");
        if (other.name == "PlayArea")
        {
            PopBubble(false);
        }
    }

    private void PopBubble(bool isClick)
    {
        // Ajoute la bulle au compteur
        GameManager.Instance.AddBubble(type, isClick ? amount * 2f : amount);
        // Détruit la bulle
        Destroy(gameObject);
    }
}
