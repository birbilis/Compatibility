﻿//Project: Compatibility (https://github.com/Zoomicon/Compatibility)
//Filename: Accordion.cs
//Version: 20150205

//Note: to fix Error CS0433 "The type 'TemplateVisualStateAttribute' exists in both ... PresentationFramework ... and WPFToolkit ...", right click the WPFToolkit reference and select Properties, then set "Aliases" to "WPFToolit" instead of "global"

using System.Windows;
using System.Windows.Controls.Primitives;

namespace Compatibility
{
  //WPF and Silverlight Toolkit seem to share the same visual states and parts for Accordion

  [StyleTypedProperty(Property = "AccordionButtonStyle", StyleTargetType = typeof(AccordionButton))]
  [StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(AccordionItem))]
  [TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
  [TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
  [TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
  [TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
  [TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
  [TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
  public class Accordion : System.Windows.Controls.Accordion
  {

    #region --- Initialization ---

    #if !SILVERLIGHT
    static Accordion()
    {
      DefaultStyleKeyProperty.OverrideMetadata(typeof(Accordion), new FrameworkPropertyMetadata(typeof(System.Windows.Controls.Accordion)));
    }
    #endif

    public Accordion()
    {
      ApplyStyle();
    }

    public virtual void ApplyStyle()
    {
      //note: don't call base.ApplyStyle() at descendent
      DefaultStyleKey = typeof(System.Windows.Controls.Accordion);
    }

    #endregion

  }

}
