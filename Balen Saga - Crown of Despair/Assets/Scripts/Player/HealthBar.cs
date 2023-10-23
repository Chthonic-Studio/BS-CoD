using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image _image;
    [SerializeField] private float _timeToDrain = 0.25f;

    private float _target;

    private Coroutine drainHealthBarCoroutine;
    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void UpdateHealthBar(float startingHealth, float currentHealth)
    {
      _target = currentHealth / startingHealth;  

      drainHealthBarCoroutine = StartCoroutine(DrainHealthBar());
    }

    private IEnumerator DrainHealthBar()
    {
        float fillAmount = _image.fillAmount;
        
        float elapsedTime = 0f;
        while(elapsedTime < _timeToDrain)
        {
            elapsedTime += Time.deltaTime;

            _image.fillAmount = Mathf.Lerp(fillAmount, _target, (elapsedTime / _timeToDrain));
            
            yield return null;
        }
    }
}
