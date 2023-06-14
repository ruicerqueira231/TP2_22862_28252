using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float forwardSpeed = 8f;
    public float leftRightSpeed = 7f;
    private bool speedIncreased = false;
    public bool isJumping = false;
    private bool comingDown = false;
    public GameObject playerObject;
    private float initialYPosition;

    private void Start()
    {
        initialYPosition = transform.position.y;
    }

    void Update()
    {
        // Move forward
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Move left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > limiteNivel.leftSide)
            {
                transform.Translate(Vector3.left * leftRightSpeed * Time.deltaTime);
            }
        }

        // Move right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < limiteNivel.rightSide)
            {
                transform.Translate(Vector3.right * leftRightSpeed * Time.deltaTime);
            }
        }

        if (LevelDistance.disRun % 10 == 0 && !speedIncreased)
        {
            forwardSpeed += 0.5f;
            speedIncreased = true;
        }
        else if (LevelDistance.disRun % 10 != 0)
        {
            speedIncreased = false;
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            if (!isJumping)
            {
                isJumping = true;
                playerObject.GetComponent<Animator>().Play("Jump");
                StartCoroutine(JumpSequence());
            }
        }

        if (isJumping)
        {
            if (!comingDown)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 4, Space.World);
            }
            else
            {
                transform.Translate(Vector3.down * Time.deltaTime * 4, Space.World);
            }

        }else{
            transform.position = new Vector3(transform.position.x, initialYPosition, transform.position.z);
        }
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Standard Run");
    }
}



