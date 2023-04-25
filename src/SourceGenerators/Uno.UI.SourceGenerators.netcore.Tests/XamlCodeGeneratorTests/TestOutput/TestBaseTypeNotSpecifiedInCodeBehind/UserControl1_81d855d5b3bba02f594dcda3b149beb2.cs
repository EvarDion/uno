﻿// <autogenerated />
#pragma warning disable CS0114
#pragma warning disable CS0108
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers.Xaml;
using MyProject;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif UNO_REFERENCE_API || IS_UNIT_TESTS
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace TestRepro
{
	partial class UserControl1 : global::Windows.UI.Xaml.Controls.UserControl
	{
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_prefix_UserControl1_81d855d5b3bba02f594dcda3b149beb2 = "ms-appx:///TestProject/";
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_UserControl1_81d855d5b3bba02f594dcda3b149beb2 = "ms-appx:///TestProject/";
				global::Windows.UI.Xaml.NameScope __nameScope = new global::Windows.UI.Xaml.NameScope();
		private void InitializeComponent()
		{
			InitializeComponent_5333DF42();
		}
		private void InitializeComponent_5333DF42()
		{
			NameScope.SetNameScope(this, __nameScope);
			var __that = this;
			base.IsParsing = true;
			// Source 0\UserControl1.xaml (Line 1:2)
			base.Content = 
			new global::Windows.UI.Xaml.Controls.Grid
			{
				IsParsing = true,
				// Source 0\UserControl1.xaml (Line 12:3)
			}
			.UserControl1_81d855d5b3bba02f594dcda3b149beb2_XamlApply((UserControl1_81d855d5b3bba02f594dcda3b149beb2XamlApplyExtensions.XamlApplyHandler0)(c0 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c0, __baseUri_UserControl1_81d855d5b3bba02f594dcda3b149beb2);
				c0.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply(((c1) => 
			{
				// Source 0\UserControl1.xaml (Line 1:2)
				
				// WARNING Property c1.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}UserControl, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply(((c2) => 
			{
				// Class TestRepro.UserControl1
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c2, __baseUri_UserControl1_81d855d5b3bba02f594dcda3b149beb2);
				c2.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

		}
		partial void OnInitializeCompleted();

	}
}
namespace MyProject
{
	static class UserControl1_81d855d5b3bba02f594dcda3b149beb2XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid UserControl1_81d855d5b3bba02f594dcda3b149beb2_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
