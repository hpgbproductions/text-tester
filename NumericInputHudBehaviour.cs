namespace Assets.Scripts
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Linq;
    using UnityEngine;
    using UnityEngine.UI;
    using Jundroo.SimplePlanes.ModTools;
    using Jundroo.SimplePlanes.ModTools.Parts;
    using Jundroo.SimplePlanes.ModTools.Parts.Attributes;

    public class NumericInputHudBehaviour : Jundroo.SimplePlanes.ModTools.Parts.PartModifierBehaviour
    {
        public NumericInputHud partModifier;

        public Text TextComponent;
        public RectTransform TextRect;
        public RectTransform CanvasRect;
        
        public Font FontVCR;
        public Font FontOrbitron;
        public Font FontANum;
        public Font FontLiber;


        private void Start()
        {
            if (TextComponent == null)
            {
                Debug.LogError("The Text Component was not found");
                return;
            }

            if (TextComponent == null)
            {
                Debug.LogError("The Rect Transform was not found");
                return;
            }

            partModifier = (NumericInputHud)PartModifier;
        }

        private void Update()
        {
            if (ServiceProvider.Instance.GameState.IsInDesigner)
            {
                TextRect.sizeDelta = new Vector2(partModifier.Width, partModifier.Height);
                CanvasRect.sizeDelta = new Vector2(partModifier.Width, partModifier.Height);
                TextComponent.color = new Color(partModifier.ColorRed, partModifier.ColorGreen, partModifier.ColorBlue, partModifier.ColorAlpha);
                TextComponent.fontStyle = partModifier.FontStyle;
                TextComponent.fontSize = partModifier.FontSize;
                TextComponent.lineSpacing = partModifier.LineSpacing;
                TextComponent.alignment = partModifier.TextAlignment;
                TextComponent.horizontalOverflow = partModifier.HorizontalWrapMode;

                if (partModifier.Font == "Orbitron")
                {
                    TextComponent.font = FontOrbitron;
                }
                else if (partModifier.Font == "VCR")
                {
                    TextComponent.font = FontVCR;
                }
                else if (partModifier.Font == "ANum")
                {
                    TextComponent.font = FontANum;
                }
                else if (partModifier.Font == "Liber")
                {
                    TextComponent.font = FontLiber;
                }
                else
                {
                    TextComponent.font = Font.CreateDynamicFontFromOSFont(partModifier.Font, 32);
                }
            }
        }
    }
}