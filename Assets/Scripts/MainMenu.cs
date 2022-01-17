using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if(hit.collider != null && hit.collider.gameObject.name == "ContinueGame")
            {
                SceneManager.LoadScene(1);
            }

            if(hit.collider != null && hit.collider.gameObject.name == "NewGame")
            {
                SceneManager.LoadScene(1);
            }

            if(hit.collider != null && hit.collider.gameObject.name == "ExitToDesktop")
            {
                Application.Quit();
            }
        }
    }
}
