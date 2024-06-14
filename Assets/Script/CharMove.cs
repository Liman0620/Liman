//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor;
//using UnityEngine;

//public class CharMove : MonoBehaviour
//{
//    public float speed=3;
//    // Start is called before the first frame update

//    Animator anim;

//    Vector3 move;
//    void Start()
//    {
//        anim = GetComponent<Animator>();

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        float x = Input.GetAxis("Horizontal");
//        float z = Input.GetAxis("Vertical");

//        //move=new Vector3(x,0,z);

//        //transform.LookAt(transform.position+new Vector3(x,0,z));
//        //transform.position += new Vector3(x, 0, z) *speed * Time.deltaTime;

//        //UpdateAnim();

//    } 
//    void UpdateAnim()
//    {
//        anim.SetFloat("Speed", move.magnitude);
//    }
//}
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    Animator anim;
    Animation ani;
    // 移动速度
    private float moveSpeed = 7.0f;
    // 旋转速度
    private float rotationSpeed = 100.0f;
    // 角色控制器组件
    private CharacterController cc;
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        // 获取角色控制器组件
        cc = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();   

    }
    // Update is called once per frame
    void Update()
    {

        // 前后左右方向
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(h, 0, v);
        // 前后左右移动
        cc.SimpleMove(transform.TransformDirection(direction) * moveSpeed);
        // 向前移动
        if (Input.GetKeyDown(KeyCode.W))
        {
            //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
        }
        //跳跃动画
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
        // 向后移动
        if (Input.GetKeyDown(KeyCode.S))
        {
            //transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.Self);
        }

        // 向左移动
        if (Input.GetKeyDown(KeyCode.A))
        {
            //transform.Translate(Vector3.left * moveSpeed * Time.deltaTime, Space.Self);
        }

        // 向右移动
        if (Input.GetKeyDown(KeyCode.D))
        {
            //transform.Translate(Vector3.right * moveSpeed * Time.deltaTime, Space.Self);
        }

        // 向左旋转，替换GetKey方法
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime, Space.Self);
        }

        // 向右旋转，替换GetKey方法
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
        }
        //跳跃动画
        
        UpdateAnim();
    }
    void UpdateAnim()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        move = new Vector3(x, 0, z);
        anim.SetFloat("Speed", move.magnitude);
    }
}