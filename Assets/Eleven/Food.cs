using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Food : MonoBehaviour
{
    public TMP_Text foodText;
    public TMP_Text levelText;
    public TMP_Text upgradeCostText;
    public TMP_Text totalFoodText;
    private int level = 1;
    private int foodPerClick = 1;
    private int foodToNextLevel = 10; 
    private int food = 0;
    private int totalFood = 0;  

    private void Start()
    {
        UpdateUI();
    }

    private void AddFood(){
        food += foodPerClick; 
        totalFood += foodPerClick;
        if (food >= foodToNextLevel)
        {
            LevelUp();
        }
        UpdateUI();
    }

    private void LevelUp(){
        foodToNextLevel += 10;
        food = 0;
        level++;
        UpdateUI();
    }    

    public void MultiplyFoodPerClick(int multiplier)
    {
        foodPerClick *= multiplier;
    }

    private void UpdateUI()
    {
        foodText.text = "Food: " + food;
        levelText.text = "Level: " + level;
        upgradeCostText.text = "Multiplie: 2x";
        totalFoodText.text = "Total Food: " + totalFood; 
    }

}