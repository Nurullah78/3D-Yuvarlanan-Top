using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    private Rigidbody fizik;

    private float yatay;
    private float dikey;
    private int puan;

    public int hiz;
    public int objeSayisi;

    public Text oyunBittiText;
    public Text puanText;
    public Text quitText;
    
    private void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        yatay = Input.GetAxisRaw("Horizontal");
        dikey = Input.GetAxisRaw("Vertical");

        Vector3 vektor = new Vector3(yatay, 0, dikey);
        
        fizik.AddForce(vektor * hiz);
    }

    private void Update()
    {
        if (quitText == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("Oyundan Çıkıldı!");
                Application.Quit();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        puan++;

        puanText.text = "Puan: " + puan;

        if (puan == objeSayisi)
        {
            oyunBittiText.gameObject.SetActive(true);
            quitText.gameObject.SetActive(true);
        }
    }
}
