using UnityEngine;
using UnityEngine.UI;

public class RoamingManager : MonoBehaviour
{
    public Image avatarImage;
    public Text playerNameText;

    public Sprite[] avatarSprites; // 存储头像库中的头像图片

    void Start()
    {
        // 从PlayerPrefs中获取玩家姓名和学号
        string playerName = PlayerPrefs.GetString("PlayerName");
        string playerID = PlayerPrefs.GetString("PlayerID");

        // 设置名字
        playerNameText.text = playerName;

        // 设置头像，从头像库中随机选择
        int randomIndex = Random.Range(0, avatarSprites.Length);
        avatarImage.sprite = avatarSprites[randomIndex];
    }
}

