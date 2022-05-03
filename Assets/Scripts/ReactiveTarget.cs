using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    public void ReactToHit()
    {
        WanderingAI wanderingAI = GetComponent<WanderingAI>();
        if (wanderingAI != null)
        {
            wanderingAI.SetAlive(false);
        }
        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        this.transform.Rotate(0, 0, 90);
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
}
