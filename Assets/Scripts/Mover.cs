using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        var deltaTime = Time.deltaTime;

        float xValue = Input.GetAxis("Horizontal") * deltaTime;
        float zValue = Input.GetAxis("Vertical") * deltaTime;
        transform.Translate(xValue * moveSpeed, 0f, zValue * moveSpeed);
    }
}
