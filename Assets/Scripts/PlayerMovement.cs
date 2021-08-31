using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 10;
    public float jumpforce = 3;
    private Vector3 _move;
    private bool _jumping = false;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();    
    }
    void OnCollisionEnter2D(Collision2D collision)
        {
            _jumping = false;
        }
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        _move = new Vector2(horizontalInput,0);

        if(Input.GetButton("Jump") && !_jumping)
        {
            _rigidbody.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
            _jumping = true;
        }

    }
    void FixedUpdate()
    {
        transform.position += (_move * speed * Time.deltaTime);   
    }
}
