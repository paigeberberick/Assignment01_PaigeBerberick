using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); 
        float y = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, y, 0f);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
}
