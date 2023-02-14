// <copyright file="TextBlock.cs" company="MaaAssistantArknights">
// MaaWpfGui - A part of the MaaCoreArknights project
// Copyright (C) 2021 MistEO and Contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY
// </copyright>

using System.Windows;
using System.Windows.Media;

namespace MaaWpfGui.Helper.CustomStyle
{
    public class TextBlock : System.Windows.Controls.TextBlock
    {
        static TextBlock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextBlock), new FrameworkPropertyMetadata(typeof(TextBlock)));
        }

        public static readonly DependencyProperty CustomForegroundProperty = DependencyProperty.Register("CustomForeground", typeof(Brush), typeof(TextBlock), new PropertyMetadata(Brushes.Black));

        public Brush CustomForeground
        {
            get { return (Brush)GetValue(CustomForegroundProperty); }
            set { SetValue(CustomForegroundProperty, value); }
        }
    }
}
