
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 10f;

    GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>(); 
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(0f,speed); //GameManagerを探してRigibody2Dのvelocityに弾のスピードを与える
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);//当たったものを消す
        gameManager.AddScore();//スコア
        Destroy(gameObject);//弾が消される
    }
}
