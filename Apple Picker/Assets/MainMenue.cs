using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenue : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
    }
    public void buttonClicked() {
        SceneManager.LoadScene("_Scene_0");
    }

}
