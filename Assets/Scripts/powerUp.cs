using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    private LevelManager levelManager;
    public GameObject paddle;
    public GameObject ball;
    int flavour;


    void Start()
    {
        flavour = Random.Range(0, 4);
        switch (flavour)
        {

            case 0:
                GetComponent<MeshRenderer>().material = Resources.Load("Materials/redMaterial") as Material;
                break;
            case 1:
                GetComponent<MeshRenderer>().material = Resources.Load("Materials/greenMaterial") as Material;
                break;
            case 2:
                GetComponent<MeshRenderer>().material = Resources.Load("Materials/blueMaterial") as Material;
                break;
            case 3:
                GetComponent<MeshRenderer>().material = Resources.Load("Materials/yellowMaterial") as Material;
                break;
            default:
                GetComponent<MeshRenderer>().material = Resources.Load("Materials/redMaterial") as Material;
                break;
        }



    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Paddle")
        {
            print("powerup + "+flavour);
            switch (flavour)
            {

                case 0:
                    levelManager = GameObject.FindObjectOfType<LevelManager>();
                    levelManager.LoadLevel("Loose Screen");
                    break;
                case 1:
                    print(other.transform.localScale);
                    other.transform.localScale += new Vector3(0.2f, 0, 0);
                    break;
                case 2:
                    print(ball.GetComponent<Rigidbody2D>().velocity);
                    ball.GetComponent<Rigidbody2D>().velocity -= new Vector2(0.2f, 0.2f);
                    break;
                case 3:
                    
                    break;
                default:
                    
                    break;
            }
        }
    }
}
