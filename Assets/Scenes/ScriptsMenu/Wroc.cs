using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Wroc : MonoBehaviour
{
    // Start is called before the first frame update
  
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      
        ScrollView scrollView = new ScrollView();
        scrollView.transform.position = new Vector3(0, 0,0);
        Button button = new Button();
        button.text = "Robiê co chcê";
        scrollView.visible = true;
        scrollView.Add(button);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
