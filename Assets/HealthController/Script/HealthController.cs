/* HealthController.cs */
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private GameObject healthPanel;

    [SerializeField]
    private RectTransform healthBar;

    [SerializeField]
    private Text healthText;

    private float healthBarStartWidth;

    private float currentHealth;

    [SerializeField]
    private float maxHealth;

    [SerializeField]
    private float respawnTime;

    private SkinnedMeshRenderer skinnedMeshRenderer;

    private bool isDead;

    //public Score score;

    // Start is called before the first frame update
    void Start()
    {
        healthBarStartWidth = healthBar.sizeDelta.x;
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        ResetHealth();
        UpdateHealthUI();
    }

    public void ApplyDamage(float damage)
    {
        if (isDead) return;

        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            score.AddScore(100);
            currentHealth = 0;
            isDead = true;
            skinnedMeshRenderer.enabled = false;
            healthPanel.SetActive(false);
            StartCoroutine(RespawnAfterTime());
        }

        UpdateHealthUI();
    }

    IEnumerator RespawnAfterTime()
    {
        yield return new WaitForSeconds(respawnTime);
        ResetHealth();
    }

    private void ResetHealth()
    {
        isDead = false;
        currentHealth = maxHealth;
        skinnedMeshRenderer.enabled = true;
        healthPanel.SetActive(true);
        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        float percentOutOf = (currentHealth / maxHealth) * 100;
        float newWidth = (percentOutOf / 100f) * healthBarStartWidth;

        healthBar.sizeDelta = new Vector2(newWidth, healthBar.sizeDelta.y);
        healthText.text = currentHealth + "/" + maxHealth;
    }

    // void Update()
    // {
    //     score.AddScore(100);
    // }
}