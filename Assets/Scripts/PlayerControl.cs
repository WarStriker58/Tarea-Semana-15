using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D _compRigidbody;
    public float speedX;
    public float speedY;
    public GameObject bulletPrefab;
    private float horizontal;
    private float vertical;
    public AudioClip gunshotSound;

    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            if (gunshotSound != null)
            {
                AudioSource.PlayClipAtPoint(gunshotSound, transform.position);
            }
        }
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(horizontal*speedX, vertical*speedY);
    }
}
