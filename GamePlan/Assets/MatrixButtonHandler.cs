using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatrixButtonHandler : MonoBehaviour
{
    public PassthroughStylerEnhanced passthroughStyler;
    // RectTransform colorWheel = passthroughLayer.colorWheel;
    // public Texture2D colorTexture;
    Color color = new Color(0.1f, 0.5f, 0.13f, 0.33f);

    public void SetPreset(){
        passthroughStyler.SetSavedColor(color);
        passthroughStyler.OnAlphaChanged(color.a);
        passthroughStyler.OnBrightnessChanged(-1.0f);
        passthroughStyler.OnContrastChanged(-1.0f);
        passthroughStyler.OnPosterizeChanged(0.0f);
    }
}
