using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Player" && transform.tag != "Hit")
        {
            var meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.red;

            transform.tag = "Hit";
        }                
    }
    
}
