using System.Collections;
using UnityEngine;

public class SpawnShield : MonoBehaviour
{
    public GameObject shield;
    
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            yield return new WaitForSeconds(Random.Range(5.0f, 6.0f)); // Задержка при создани и  Рандомный спавн обьекта
            Instantiate(shield, new Vector2(Random.Range(-2.85f, 2.85f), 5.521f), Quaternion.identity); //Рандомное расположение падения обьекта
            
        }
        
    }
}
