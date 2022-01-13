using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectMovement : MonoBehaviour
{
    private float ySpeed = -4f;


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
        transform.Translate(new Vector3(0f, ySpeed * Time.deltaTime, 0f));
        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }

    /* void OnTriggerEnter(Collider other)
    {
       
      scoreSystem += 10;
      scoreText.GetComponent<Text>().text = "Score: " + scoreSystem;
      Destroy(gameObject);*/
        
    
}
