using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag != "Hit")
        {
            score++;
        }
    }
    
}