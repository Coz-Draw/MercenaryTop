using UnityEngine;
using UnityEngine.UI;

public class PlayerCoins : MonoBehaviour
{
    public int gold = 0;
    public int copper = 0;

    public Text goldText;
    public Text copperText;

    void Start()
    {
        UpdateUI();
    }

    public void AddGold()
    {
        gold++;
        UpdateUI();
    }

    public void AddCopper()
    {
        copper++;
        UpdateUI();
    }

    void UpdateUI()
    {
        goldText.text = "Gold: " + gold;
        copperText.text = "Copper: " + copper;
    }
}