using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public GameObject top;
    private Vector3 aradakiFark;

    void Start()
    {
        aradakiFark = transform.position - top.transform.position;
    }

    void Update()
    {
        transform.position = top.transform.position + aradakiFark;
    }
}
