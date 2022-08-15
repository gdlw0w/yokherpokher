using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WczytajGre : MonoBehaviour
{
    // Start is called before the first frame update
    public void ZmienScene()
    {
        SceneManager.LoadScene(2);
    }
}
