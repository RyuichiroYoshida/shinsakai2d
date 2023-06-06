using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitCount : MonoBehaviour
{
    private float _hitCounter = 0;
    public Text _hitCounterText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "kyaku")
        {
            _hitCounter++;
            print(_hitCounter);
            float count = _hitCounter;
            //gameObject.GetComponent<Text>().text = _hitCounter.ToString();
            _hitCounterText.text = _hitCounter.ToString();
        }
    }
}
