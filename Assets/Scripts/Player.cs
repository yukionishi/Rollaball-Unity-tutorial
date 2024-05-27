using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float _speed = 3.0f;
    public TextMeshProUGUI _scoreText;
    public int _score = 0;

    private void Start()
    {
        //_scoreText = _text.GetComponent<TMPro.TextMeshProUGUI>();
        Debug.Log("hoge");
        print("huga");
    }

    void Update()
    {
        //Up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += _speed * new Vector3(0, 0, 1) * Time.deltaTime; //transform.forward
        }
        //Down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= _speed * new Vector3(0, 0, 1) * Time.deltaTime; //transform.forward
        }
        //Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += _speed * new Vector3(1, 0, 0) * Time.deltaTime; //transform.right
        }
        //Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= _speed * new Vector3(1, 0, 0) * Time.deltaTime; //transform.right
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Enter collider:" + collision.gameObject.name);

        if (collision.gameObject.name == "Sphere")
        {
            Destroy(collision.gameObject);
            _score += 10;

            _scoreText.text = "Score: " + _score.ToString();
        }
        else if (collision.gameObject.name == "Enemy")
        {
            Destroy(collision.gameObject);
            _score -= 20;

            _scoreText.text = "Score: " + _score.ToString();
        }
    }
}
