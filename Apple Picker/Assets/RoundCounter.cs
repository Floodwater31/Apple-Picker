using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int          _round = 0;

    private Text        uiText_;

    // Start is called before the first frame update
    void Start()
    {
        uiText_ = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText_.text = "Round: " + _round;
    }
}
