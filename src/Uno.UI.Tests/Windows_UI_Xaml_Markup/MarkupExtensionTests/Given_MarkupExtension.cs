using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uno.UI.Tests.Windows_UI_Xaml_Markup.MarkupExtensionTests.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Uno.UI.Tests.Windows_UI_Xaml_Markup.MarkupExtensionTests;

[TestClass]
public class Given_MarkupExtension
{
	[TestMethod]
	public void When_DP_Markup()
	{
		var setup = new When_DP_Markup_Setup(); // Tag="{local:DebugMarkupExtension}"
		var provider = setup.Tag as IXamlServiceProvider;
		var pvt = provider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
		var target = pvt.TargetObject;
		var pvtp = pvt.TargetProperty as ProvideValueTargetProperty;

		Assert.AreEqual(setup, target);
		Assert.AreEqual(pvtp.DeclaringType, FrameworkElement.TagProperty.OwnerType);
		Assert.AreEqual(pvtp.Name, FrameworkElement.TagProperty.Name);
		Assert.AreEqual(pvtp.Type, FrameworkElement.TagProperty.Type);
	}

	[TestMethod]
	public void When_AttachedDP_Markup()
	{
		var setup = new When_AttachedDP_Markup_Setup(); // local:Attached.Value="{local:DebugMarkupExtension}"
		var provider = Attachable.GetValue(setup) as IXamlServiceProvider;
		var pvt = provider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
		var target = pvt.TargetObject;
		var pvtp = pvt.TargetProperty as ProvideValueTargetProperty;

		Assert.AreEqual(setup, target);
		Assert.AreEqual(pvtp.DeclaringType, Attachable.ValueProperty.OwnerType);
		Assert.AreEqual(pvtp.Name, Attachable.ValueProperty.Name);
		Assert.AreEqual(pvtp.Type, Attachable.ValueProperty.Type);
	}
	
	[TestMethod]
	public void When_DP_Markup_PropertyType()
	{
		var setup = new When_DP_Markup_Setup(); // local:Attached.Value2="{local:DebugMarkupExtension Behavior=AssignToAttachableValue}"
		var provider =  Attachable.GetValue(setup) as IXamlServiceProvider;
		var pvt = provider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
		var target = pvt.TargetObject;
		var pvtp = pvt.TargetProperty as ProvideValueTargetProperty;

		Assert.AreEqual(setup, target);
		Assert.AreEqual(pvtp.DeclaringType, Attachable.Value2Property.OwnerType);
		Assert.AreEqual(pvtp.Name, Attachable.Value2Property.Name);
		Assert.AreEqual(pvtp.Type, Attachable.Value2Property.Type);
	}

	[TestMethod]
	public void When_AttachedDP_Markup_PropertyType()
	{
		var setup = new When_AttachedDP_Markup_Setup(); // local:Attached.Value2="{local:DebugMarkupExtension Behavior=AssignToTag}"
		var provider = setup.Tag as IXamlServiceProvider;
		var pvt = provider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
		var target = pvt.TargetObject;
		var pvtp = pvt.TargetProperty as ProvideValueTargetProperty;

		Assert.AreEqual(setup, target);
		Assert.AreEqual(pvtp.DeclaringType, typeof(Attachable));
		Assert.AreEqual(pvtp.Name, Attachable.ValueProperty.Name);
		Assert.AreEqual(pvtp.Type, typeof(object));
	}
}
