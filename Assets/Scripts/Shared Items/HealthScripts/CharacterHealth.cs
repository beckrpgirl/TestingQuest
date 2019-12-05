using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : Health
{
    public Vector2 startPoint;
    public Texture2D[] images;

    private void OnGUI()
    {
        float normalisedHealth = NormalizeHealth();
        Rect rect = new Rect(startPoint.x, startPoint.y, Screen.width - startPoint.x, Screen.height - startPoint.y);

        GUILayout.BeginArea(rect);
        GUILayout.Label(HealthBarImage(normalisedHealth));
        GUILayout.EndArea();
    }

    Texture2D HealthBarImage(float health)
    {

        for (int i = 0; i < images.Length; i++)
        {
            if (health >= 1f - ((1f / (images.Length)) * i))
            {
                return images[i];
            }
        }

        return null;
    }
}
