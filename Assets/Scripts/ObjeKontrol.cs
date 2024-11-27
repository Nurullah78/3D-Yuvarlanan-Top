using UnityEngine;

public class ObjeKontrol : MonoBehaviour
{
    private Vector3 vector = new Vector3(15, 30, 45);

    void Update()
    {
        transform.Rotate(vector * 0.01f);
    }
}
