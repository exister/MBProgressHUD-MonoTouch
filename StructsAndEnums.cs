using System;

namespace MBProgressHUD
{
	public enum MBProgressHUDMode {
		/** Progress is shown using an UIActivityIndicatorView. This is the default. */
		MBProgressHUDModeIndeterminate,
		/** Progress is shown using a round, pie-chart like, progress view. */
		MBProgressHUDModeDeterminate,
		/** Progress is shown using a ring-shaped progress view. */
		MBProgressHUDModeAnnularDeterminate,
		/** Shows a custom view */
		MBProgressHUDModeCustomView,
		/** Shows only labels */
		MBProgressHUDModeText
	};

	public enum MBProgressHUDAnimation {
		/** Opacity animation */
		MBProgressHUDAnimationFade,
		/** Opacity + scale animation */
		MBProgressHUDAnimationZoom,
		MBProgressHUDAnimationZoomOut = MBProgressHUDAnimationZoom,
		MBProgressHUDAnimationZoomIn
	};
}

