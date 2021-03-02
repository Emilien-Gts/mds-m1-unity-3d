using UnityEngine;

[RequireComponent(typeof(Animator), typeof(SpriteRenderer))]
public class AnimateTrump : MonoBehaviour {

    Animator animator;
    SpriteRenderer spriteRenderer;
    Transform transform;
    Rigidbody2D rigidbody2d;
    public int MaxSpeed = 10;
    private Vector3 initialPosition;

    private void Start() {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        transform = GetComponent<Transform>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
    }

    void Update() {
        var veloc = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow)) {
            animator.SetFloat("Speed", 2f);
            spriteRenderer.flipX = false;
            // this.transform.position -= Vector3.left * MaxSpeed * Time.deltaTime;
            veloc = new Vector2(MaxSpeed, 0);

        }else if(Input.GetKey(KeyCode.LeftArrow)){
            animator.SetFloat("Speed", 2f);
            spriteRenderer.flipX = true;
            veloc = new Vector2(-MaxSpeed, 0);
            // this.transform.position -= Vector3.right * MaxSpeed * Time.deltaTime;

        }else if(Input.GetKey(KeyCode.UpArrow)){
            animator.SetFloat("Speed", 2f);
            spriteRenderer.flipX = false;
            veloc = new Vector2(0, MaxSpeed);

            // this.transform.position += Vector3.up * MaxSpeed * Time.deltaTime;

        }else if(Input.GetKey(KeyCode.DownArrow)){
            animator.SetFloat("Speed", 2f);
            spriteRenderer.flipX = false;
            veloc = new Vector2(0, -MaxSpeed);
            // this.transform.position += Vector3.down * MaxSpeed * Time.deltaTime;

        }else {
            animator.SetFloat("Speed", 0f);
            animator.SetFloat("Roll", 0f);
        }

        rigidbody2d.velocity = veloc;


        if(Input.GetKeyDown(KeyCode.Space)){
            animator.SetFloat("Roll", 2f);
            spriteRenderer.flipX = false;
        }
    }

    public Vector3 getInitialPosition() {
    return this.initialPosition;
  }
}
