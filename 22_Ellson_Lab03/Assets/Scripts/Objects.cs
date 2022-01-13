using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
    //Fruits and Junk object
    public GameObject Apple;
    public GameObject Strawberry;
    public GameObject CakeSlice;
    public GameObject SweetBun;

    //Score system
    public GameObject scoreText;
    public int scoreSystem;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        scoreSystem += 10;
        scoreText.GetComponent<Text>().text = "Score: " + scoreSystem;
        Destroy(gameObject);
    }
}
