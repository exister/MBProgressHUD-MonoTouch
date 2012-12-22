using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.CoreFoundation;
using MonoTouch.UIKit;

namespace MBProgressHUD
{
	delegate void MBProgressHUDCompletionBlock();

	delegate void dispatch_block_t();

	[BaseType (typeof(UIView), Name="MBProgressHUD", Delegates=new string [] { "WeakDelegate" },	Events=new Type [] {typeof(MBProgressHUDDelegate)})]
	interface MTMBProgressHUD
	{
		[Export ("completionBlock", ArgumentSemantic.Copy)]
		MBProgressHUDCompletionBlock CompletionBlock { get; set; }

		[Export ("mode", ArgumentSemantic.Assign)]
		MBProgressHUDMode Mode { get; set; }
		
		[Export ("animationType", ArgumentSemantic.Assign)]
		MBProgressHUDAnimation AnimationType { get; set; }
		
		[Export ("customView", ArgumentSemantic.Retain)]
		UIView CustomView { get; set; }
		
		[Wrap ("WeakDelegate")]
		MBProgressHUDDelegate Delegate { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export ("labelText", ArgumentSemantic.Copy)]
		string LabelText { get; set; }
		
		[Export ("detailsLabelText", ArgumentSemantic.Copy)]
		string DetailsLabelText { get; set; }
		
		[Export ("opacity", ArgumentSemantic.Assign)]
		float Opacity { get; set; }
		
		[Export ("color", ArgumentSemantic.Retain)]
		UIColor Color { get; set; }
		
		[Export ("xOffset", ArgumentSemantic.Assign)]
		float XOffset { get; set; }
		
		[Export ("yOffset", ArgumentSemantic.Assign)]
		float YOffset { get; set; }
		
		[Export ("margin", ArgumentSemantic.Assign)]
		float Margin { get; set; }
		
		[Export ("dimBackground", ArgumentSemantic.Assign)]
		bool DimBackground { get; set; }
		
		[Export ("graceTime", ArgumentSemantic.Assign)]
		float GraceTime { get; set; }
		
		[Export ("minShowTime", ArgumentSemantic.Assign)]
		float MinShowTime { get; set; }
		
		[Export ("taskInProgress", ArgumentSemantic.Assign)]
		bool TaskInProgress { get; set; }
		
		[Export ("removeFromSuperViewOnHide", ArgumentSemantic.Assign)]
		bool RemoveFromSuperViewOnHide { get; set; }
		
		[Export ("labelFont", ArgumentSemantic.Retain)]
		UIFont LabelFont { get; set; }
		
		[Export ("detailsLabelFont", ArgumentSemantic.Retain)]
		UIFont DetailsLabelFont { get; set; }
		
		[Export ("progress", ArgumentSemantic.Assign)]
		float Progress { get; set; }
		
		[Export ("minSize", ArgumentSemantic.Assign)]
		SizeF MinSize { get; set; }

		[Export ("square", ArgumentSemantic.Assign)]
		bool Square { get; set; }
		
		[Static, Export ("showHUDAddedTo:animated:")]
		MTMBProgressHUD ShowHUDAddedTo(UIView view, bool animated);

		[Static, Export ("hideHUDForView:animated:")]
		bool HideHUDForView(UIView view, bool animated);

		[Static, Export ("hideAllHUDsForView:animated:")]
		uint HideAllHUDsForView(UIView view, bool animated);

		[Static, Export ("HUDForView:")]
		MTMBProgressHUD HUDForView(UIView view);

		[Static, Export ("allHUDsForView:")]
		NSArray AllHUDsForView(UIView view);
		
		[Export ("initWithWindow:")]
		NSObject InitWithWindow(UIWindow window);
		
		[Export ("initWithView:")]
		NSObject InitWithView(UIView view);
		
		[Export ("show:")]
		void Show(bool animated);
		
		[Export ("hide:")]
		void Hide(bool animated);
		
		[Export ("hide:afterDelay:")]
		void HideafterDelay(bool animated, double delay);
		
		[Export ("showWhileExecuting:onTarget:withObject:animated:")]
		void ShowWhileExecutingonTargetwithObject(Selector method, NSObject target, NSObject nsobject, bool animated);
		
		[Export ("showAnimated:whileExecutingBlock:")]
		void ShowAnimatedwhileExecutingBlock(bool animated, dispatch_block_t block);
		
		[Export ("showAnimated:whileExecutingBlock:completionBlock:")]
		void ShowAnimatedwhileExecutingBlockcompletionBlock(bool animated, dispatch_block_t block, MBProgressHUDCompletionBlock completion);
		
		[Export ("showAnimated:whileExecutingBlock:onQueue:")]
		void ShowAnimatedwhileExecutingBlockOnQueue(bool animated, dispatch_block_t block, DispatchQueue queue);
		
		[Export ("showAnimated:whileExecutingBlock:onQueue:completionBlock:")]
		void ShowAnimatedwhileExecutingBlockonQueue(bool animated, dispatch_block_t block, DispatchQueue queue, MBProgressHUDCompletionBlock completion);
	}

	[BaseType (typeof(NSObject))]
	[Model]
	interface MBProgressHUDDelegate
	{
		[Export ("hudWasHidden:")]
		void HudWasHidden(MTMBProgressHUD hud);
	}
	
	[BaseType (typeof(UIView))]
	interface MBRoundProgressView
	{
		[Export ("progress", ArgumentSemantic.Assign)]
		float Progress { get; set; }
		
		[Export ("progressTintColor", ArgumentSemantic.Retain)]
		UIColor ProgressTintColor { get; set; }
		
		[Export ("backgroundTintColor", ArgumentSemantic.Retain)]
		UIColor BackgroundTintColor { get; set; }

		[Export ("annular", ArgumentSemantic.Assign)]
		bool Annular { get; set; }		
	}
}

