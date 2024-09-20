using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public ScoreCounter scoreCounter;
    public RoundCounter roundCounter;
    private float goal = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGo = GameObject.Find( "ScoreCounter" );

        scoreCounter = scoreGo.GetComponent<ScoreCounter>();

        GameObject roundGo = GameObject.Find( "RoundCounter" );

        roundCounter = roundGo.GetComponent<RoundCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current screen position of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;

        //
        // pg 657
        //
        mousePos2D.z = -Camera.main.transform.position.z;

        //
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint( mousePos2D );

        //
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter( Collision coll ) {
        // Find out what hit this basket
        GameObject collidedWidth = coll.gameObject;
        if ( collidedWidth.CompareTag( "Apple" ) ) {
            Destroy( collidedWidth );

            scoreCounter.score +=100;
            HighScore.TRY_SET_HIGH_SCORE( scoreCounter.score );
            if (scoreCounter.score >= goal) {
                goal += 1000;
                roundCounter._round += 1;
            }
        }
        else if (collidedWidth.CompareTag( "Bomb" )) {
            Destroy( collidedWidth );

            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();

            apScript.BombHit();
        }
    }
}
