using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NameScript : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI nameText;
    public EnemyInfoScriptableObject obj;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = obj.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
