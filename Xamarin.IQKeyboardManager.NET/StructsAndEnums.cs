using System;
using ObjCRuntime;

namespace Xamarin.IQKeyboardManager.NET
{
    [Native]
    public enum IQAutoToolbarManageBehaviour : long
    {
    	Subviews,
    	Tag,
    	Position
    }

    [Native]
    public enum IQPreviousNextDisplayMode : ulong
    {
    	Default,
    	AlwaysHide,
    	AlwaysShow
    }

    [Native]
    public enum IQLayoutGuidePosition : long
    {
    	None,
    	Top,
    	Bottom
    }

    [Native]
    public enum IQEnableMode : ulong
    {
        Default,
        Enabled,
        Disabled
    }
}