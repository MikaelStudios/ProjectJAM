using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScalePowerUI : MonoBehaviour
{
    [SerializeField] Image barFrontGrow;
    [SerializeField] Image barFrontShrink;

    public void SubscribeToPlayerEvents()
    {
        PlayerThresholds.Instance.PlayerScalePower.OnUpdateScalePoints += PlayerScalePower_OnUpdateScalePoints;
    }

    private void PlayerScalePower_OnUpdateScalePoints(float newValuePercent)
    {
        barFrontGrow.fillAmount = newValuePercent;
        barFrontShrink.fillAmount = newValuePercent;

        barFrontGrow.color = new Color(1f, 1f, 1f, newValuePercent);
        barFrontShrink.color = new Color(1f, 1f, 1f, 1f);
    }
}
