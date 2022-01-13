using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;

    //Max movement
    public float maxX;

    //Score system
    public Text scoreText;
    public int theScore;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      float horizontalInput = Input.GetAxis("Horizontal");

      transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        //Max Movement
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;

        if(theScore >= 100)
        {
            //SceneManager.LoadScene("LoseScenes");
        }
       
    }

    void OnTriggerEnter2D(Collider2D coliision)
    {
        if (coliision.gameObject.tag == "Healthy")
        {
            //ScoringSystem.instance.AddPoint();
            theScore += 10;
            scoreText.GetComponent<Text>().text = "Score: " + theScore;
            //scoreText.text = scoreText.ToString() + "Score: " + theScore;
            Destroy(coliision.gameObject);

        }
        if (coliision.gameObject.tag == "Unhealthy")
        {
            Debug.Log("1");
            SceneManager.LoadScene("LoseScenes");
        }

    }

    


}
