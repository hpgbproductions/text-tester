namespace Assets.Scripts
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Linq;
    using UnityEngine;
    using UnityEngine.UI;
    using Jundroo.SimplePlanes.ModTools.Parts;
    using Jundroo.SimplePlanes.ModTools.Parts.Attributes;

    /// <summary>
    /// A part modifier for SimplePlanes.
    /// A part modifier is responsible for attaching a part modifier behaviour script to a game object within a part's hierarchy.
    /// </summary>
    [Serializable]
    public class NumericInputHud : Jundroo.SimplePlanes.ModTools.Parts.PartModifier
    {

        [DesignerPropertySlider(Label = "Max Width", MaxValue = 500, MinValue = 50, NumberOfSteps = 10, Order = 0)]
        public int Width = 100;

        [DesignerPropertySlider(Label = "Max Height", MaxValue = 100, MinValue = 30, NumberOfSteps = 8, Order = 1)]
        public int Height = 100;

        [DesignerPropertySlider(Label = "Red", MaxValue = 1, MinValue = 0, NumberOfSteps = 21, Order = 2)]
        public int ColorRed = 1;

        [DesignerPropertySlider(Label = "Green", MaxValue = 1, MinValue = 0, NumberOfSteps = 21, Order = 3)]
        public int ColorGreen = 1;

        [DesignerPropertySlider(Label = "Blue", MaxValue = 1, MinValue = 0, NumberOfSteps = 21, Order = 4)]
        public int ColorBlue = 1;

        [DesignerPropertySlider(Label = "Alpha", MaxValue = 1, MinValue = 0, NumberOfSteps = 21, Order = 5)]
        public int ColorAlpha = 1;

        [DesignerPropertyToggleButton("Liber", "Orbitron", "VCR", "ANum", Header = "Characters", Label = "Font", Order = 10)]
        public string Font = "Liber";

        [DesignerPropertyToggleButton(Label = "Font Style", Order = 11)]
        public FontStyle FontStyle = FontStyle.Normal;

        [DesignerPropertySlider(Label = "Font Size", MaxValue = 40, MinValue = 16, NumberOfSteps = 25, Order = 12)]
        public int FontSize = 16;

        [DesignerPropertySlider(Label = "Line Spacing", MaxValue = 0.5f, MinValue = 1.5f, NumberOfSteps = 11, Order = 13)]
        public float LineSpacing = 1f;

        [DesignerPropertyToggleButton(Header = "Paragraphing", Label = "Text Alignment", Order = 20)]
        public TextAnchor TextAlignment = TextAnchor.UpperRight;

        [DesignerPropertyToggleButton(Label = "Horizontal Wrap Mode", Order = 21)]
        public HorizontalWrapMode HorizontalWrapMode = HorizontalWrapMode.Wrap;

        /// <summary>
        /// Called when this part modifiers is being initialized as the part game object is being created.
        /// </summary>
        /// <param name="partRootObject">The root game object that has been created for the part.</param>
        /// <returns>The created part modifier behaviour, or <c>null</c> if it was not created.</returns>
        public override Jundroo.SimplePlanes.ModTools.Parts.PartModifierBehaviour Initialize(UnityEngine.GameObject partRootObject)
        {
            // Attach the behaviour to the part's root object.
            var behaviour = partRootObject.AddComponent<NumericInputHudBehaviour>();
            return behaviour;
        }
    }
}