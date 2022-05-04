using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour
{
    private int _health;
    // Start is called before the first frame update
    void Start()
    {
        _health = 5;
    }

    public void Hurt(int damage)
    {
        _health -= damage;
        
        if (_health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Debug.Log("Health: " + _health);
        }
    }
}
