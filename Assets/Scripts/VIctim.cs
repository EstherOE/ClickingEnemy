using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIctim : MonoBehaviour
{

    private HpScript hpSign;
    // Start is called before the first frame update
    void Start()
    {
        hpSign = FindObjectOfType<HpScript>();
    }

    public GameObject[] enemy;
    public void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase== TouchPhase.Began)
        {
            MouseDown();

        }

    }
    public void MouseDown()
    {
        GameManager.AddScore();
        int random = UnityEngine.Random.Range(0, 9);
        hpSign.ReduceHp();

        if(hpSign.GetHPValue()<=0.1)
        {

            Destroy(gameObject);
            Instantiate(enemy[random], new Vector3(3.46f, -2.56f, 0), Quaternion.identity);
        }

    }
}
