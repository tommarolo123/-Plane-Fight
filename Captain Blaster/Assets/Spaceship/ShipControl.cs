using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public GameManager gameManageer;
    public GameObject bulletPrefab;
    public float speed = 10f;
    public float xLimit = 7f;
    public float reloadTime = 0.5f;

    float elapsedTime = 0f;

    
    void Update()
    {
        elapsedTime += Time.deltaTime;
        float xInput = Input.GetAxis("Horizontal");//キーa d←　→ の検知
        transform.Translate(xInput * speed * Time.deltaTime, 0f, 0f);//移動
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
        transform.position = position;

        if (Input.GetButtonDown("Jump") && elapsedTime > reloadTime) //ペース検知&&弾発射間隔0.5s
        {
            Vector3 spawnPos = transform.position;　
            spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);//弾生成　- - - - - - - -
            elapsedTime = 0f;
        }


    }


    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        gameManageer.PlayerDied();
        
       //ほかのGameobjectが入ったら死亡
    }

}
