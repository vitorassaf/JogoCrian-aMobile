using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrastar : MonoBehaviour
{
    private Vector3 posStart;
    public bool move;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition;
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                posStart = transform.position;

            }
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 25f));
                if (GetComponent<Collider2D>().OverlapPoint(touchPosition))
                {
                    transform.position = new Vector3(touchPosition.x, touchPosition.y, 0);
                }
            }
        }
        if (Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            if (move)
            {
                transform.position = pos;
            }
            
        }


    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Celeiro")
        {
            Debug.Log("entrou");
            SegundoControle.conteudo += 1;
            Destroy(gameObject);
            SegundoControle.numerotexto -= 1;
        }
    }

    
}

