﻿using ModKit;
using UnityEngine;

namespace UniverseBounty
{
    // ReSharper disable InconsistentNaming
    public static class UIStyles
    {
        public static GUIStyle AlignCenter= new GUIStyle(GUI.skin.label)
        {
            alignment = TextAnchor.MiddleCenter
        };

        public static readonly GUIStyle StandardButtonStyle = new GUIStyle(GUI.skin.button)
        {
            fontSize = 12.point(),
            alignment = TextAnchor.MiddleCenter
        };

        public static readonly GUIStyle SimpleButtonStyle = new GUIStyle(UI.textBoxStyle)
        {
            fontSize = 12.point()
        };

        public static GUIStyle Hint = new GUIStyle(GUI.skin.label)
        {
            fontSize = 12.point(),
            fontStyle = FontStyle.Italic,
            alignment = TextAnchor.MiddleLeft
        };
    }
}