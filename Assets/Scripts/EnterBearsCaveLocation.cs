using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBearsCaveLocation : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if(hit.collider != null)
            {
                string sceneNameImage = hit.collider.gameObject.name;
                if (sceneNameImage == "beehive_exterior")
                {
                    ChangeScene(2);
                }
                if (sceneNameImage == "bearscave_exterior")
                {
                    ChangeScene(3);
                }
                if (sceneNameImage == "theglade_exterior")
                {
                    ChangeScene(4);
                }
                if (sceneNameImage == "woodpeckerworkshop_exterior")
                {
                    ChangeScene(5);
                }
            }
            
        }
    }

    void ChangeScene(int parameter)
    {
        SceneManager.LoadScene(parameter);
    }

}
