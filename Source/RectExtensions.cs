﻿//Project: Compatibility (https://github.com/Zoomicon/Compatibility)
//Filename: RectExtensions.cs
//Version: 20120606

using System.Windows;

namespace Compatibility
{

    public static class RectExtensions
    {

#if SILVERLIGHT

        /// <summary>
        /// Indicates whether the current rectangle contains the specified rectangle,
        /// by checking for containment of the specified rectangle's top-left and
        /// bottom-right points.
        /// </summary>
        /// <param name="self">The current rectangle.</param>
        /// <param name="rect">The rectangle to check.</param>
        /// <returns><c>true</c> if the current rectangle contains the specified
        ///          rectangle; otherwise, <c>false</c>.</returns>
        public static bool Contains(this Rect self, Rect rect)
        {
            return self.Contains(new Point(rect.Left, rect.Top)) && self.Contains(new Point(rect.Right, rect.Bottom));
        }

#endif

    }

}
