using UnityEngine;
using System.Collections;

public class ObjectMove : MonoBehaviour
{

    public float amounttomovex;
    public float speed;
    private float currentposx;
    private float currentposy;
    private int facing;
    
    
    void Start()
    {
        currentposx = gameObject.transform.position.y;
        facing = 0;
        

    }

    
    void Update()
    {
        
        if (facing == 1 && gameObject.transform.position.y < currentposx - amounttomovex)
        {
            facing = 0;
        }

        if (facing == 0 && gameObject.transform.position.y > currentposx)
        {
            facing = 1;
        }

        
            if (facing == 0)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);

            }
            else if (facing == 1)
            {
                transform.Translate(-Vector2.up * speed * Time.deltaTime);
            }
        }
        

    }