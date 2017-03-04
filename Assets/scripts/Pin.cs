using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class Pin : MonoBehaviour {

	[SerializeField]
    private float speed;

    private Rigidbody2D rb;
    private bool isPinned;

    private void Awake ()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    private void Update ()
    {
        if (!isPinned)
        {
            rb.MovePosition (rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "rotator")
        {
            isPinned = true;
            transform.parent = other.transform;
        }
    }

}
