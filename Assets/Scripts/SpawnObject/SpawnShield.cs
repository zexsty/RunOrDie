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
        while (!PlayerController.lose)
        {
            yield return new WaitForSeconds(Random.Range(30f, 90f)); // Задержка при создани и  Рандомный спавн обьекта
            Instantiate(shield, new Vector2(Random.Range(-2.85f, 2.85f), 5.521f), Quaternion.identity); //Рандомное расположение падения обьекта
            
        }
        
    }
}
