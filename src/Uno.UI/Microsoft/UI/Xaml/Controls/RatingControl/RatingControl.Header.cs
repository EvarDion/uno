﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// MUX Reference RatingControl.h, tag winui3/release/1.4.2

#nullable enable

using Uno.UI.Helpers.WinUI;
using Windows.UI.Composition;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls;

public partial class RatingControl
{
	private bool IsItemInfoPresentAndFontInfo()
	{
		return m_infoType == RatingInfoType.Font;
	}
	private bool IsItemInfoPresentAndImageInfo()
	{
		return m_infoType == RatingInfoType.Image;
	}

	// Private members
	private TextBlock? m_captionTextBlock;

	private CompositionPropertySet? m_sharedPointerPropertySet;

	private StackPanel? m_backgroundStackPanel;
	private StackPanel? m_foregroundStackPanel;

	private bool m_isPointerOver;
	private bool m_isPointerDown;
	private bool m_hasPointerCapture;
	private double m_mousePercentage;

	private RatingInfoType m_infoType = RatingInfoType.Font;

	// Holds the value of the Rating control at the moment of engagement,
	// used to handle cancel-disengagements where we reset the value.
	private double m_preEngagementValue;
	private bool m_disengagedWithA;
	private bool m_shouldDiscardValue = true;

	private long m_fontFamilyChangedToken;

	private DispatcherHelper? m_dispatcherHelper;
}
