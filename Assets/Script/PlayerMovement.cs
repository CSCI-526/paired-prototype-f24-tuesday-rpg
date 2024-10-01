using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f; 
    public GameObject gameOverCanvas;
    
    void Start()
    {
        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime;
        transform.position += (Vector3)movement;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 如果碰撞到的物体是需要结束游戏的物体，可以直接触发游戏结束
        // 这里可以不使用标签，如果不需要任何条件限制碰撞
        if (collision.gameObject.CompareTag("Bullet"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        // 显示游戏结束画布
        gameOverCanvas.SetActive(true);

        // 停止玩家的移动
        moveSpeed = 0f;
    }
}
