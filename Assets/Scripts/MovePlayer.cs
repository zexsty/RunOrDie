using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float speed = 1f;

    private bool faceRight = true;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("MovePlayer", false);
    }
    void Update()
    {
        if (!Player.lose || Player.pause)
        {
            float moveX;
            if (Input.GetMouseButton(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                moveX = Mathf.Clamp(mousePos.x - player.position.x, -1, 1);
            }
            else
            {
                moveX = Input.GetAxis("Horizontal");
            }

            if (moveX > 0 && !faceRight)
                Flip();
            else if (moveX < 0 && faceRight)
                Flip();

            if (Mathf.Abs(moveX) > float.Epsilon)
            {
                animator.SetBool("MovePlayer", true);
                player.position = Vector2.MoveTowards(player.position, new Vector2(player.position.x + moveX, player.position.y), speed * Time.deltaTime);
            }
            else
            {
                animator.SetBool("MovePlayer", false);
            }
        }
    }

    public void Flip() // Метод поворота спрайта при смене направления
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

}
