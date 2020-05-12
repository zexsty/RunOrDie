using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player; // Перемещение игрока
    [SerializeField]
    private float speed = 1f; // Скорость игрока

    private bool faceRight = true; //поле для поворота игрока в сторону куда он идёт
    private Animator animator; 

    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("MovePlayer", false);
    }
    void Update()
    {
        if (!Player.lose || Player.pause) // Если игрок не мёртв или не нажата пауза
        {
            float moveX;

            if (Input.GetMouseButton(0))// Если нажата левая кнопка мыши
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Управление 
                moveX = Mathf.Clamp(mousePos.x - player.position.x, -1, 1);//Пока зажата левая кнопка мыши игрок будет следовать за курсором
            }
            else
            {
                moveX = Input.GetAxis("Horizontal"); //Передвижение стралками
            }

            if (moveX > 0 && !faceRight)//Поворот игрока при смене направления
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
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);// Поворачивает спрайт игрока при смене направления
    }

}
