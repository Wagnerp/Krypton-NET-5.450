﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2019, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2019. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.450)
//  Version 4.5.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.Drawing;
using System.ComponentModel;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Storage for status strip entries of the professional color table.
	/// </summary>
    public class KryptonPaletteTMSStatusStrip : KryptonPaletteTMSBase
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonPaletteKCTStatusStrip class.
		/// </summary>
        /// <param name="internalKCT">Reference to inherited values.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        internal KryptonPaletteTMSStatusStrip(KryptonInternalKCT internalKCT,
                                              NeedPaintHandler needPaint)
            : base(internalKCT, needPaint)
		{
		}
        #endregion

		#region IsDefault
		/// <summary>
		/// Gets a value indicating if all values are default.
		/// </summary>
		[Browsable(false)]
		public override bool IsDefault => (InternalKCT.InternalStatusStripText == Color.Empty) &&
		                                  (InternalKCT.InternalStatusStripFont == null) &&
		                                  (InternalKCT.InternalStatusStripGradientBegin == Color.Empty) &&
		                                  (InternalKCT.InternalStatusStripGradientEnd == Color.Empty);

        #endregion

        #region PopulateFromBase
        /// <summary>
        /// Populate values from the base palette.
        /// </summary>
        public void PopulateFromBase()
        {
            StatusStripText = InternalKCT.StatusStripText;
            StatusStripFont = InternalKCT.StatusStripFont;
            StatusStripGradientBegin = InternalKCT.StatusStripGradientBegin;
            StatusStripGradientEnd = InternalKCT.StatusStripGradientEnd;
        }
        #endregion

        #region StatusStripText
        /// <summary>
        /// Gets and sets the color to draw text on the status strip.
        /// </summary>
        [KryptonPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Color to draw text on the StatusStrip.")]
        [KryptonDefaultColorAttribute()]
        public Color StatusStripText
        {
            get => InternalKCT.InternalStatusStripText;

            set
            {
                InternalKCT.InternalStatusStripText = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// Resets the StatusStripText property to its default value.
        /// </summary>
        public void ResetStatusStripText()
        {
            StatusStripText = Color.Empty;
        }
        #endregion

        #region StatusStripFont
        /// <summary>
        /// Gets and sets the font to draw text on the status strip.
        /// </summary>
        [KryptonPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Font to draw text on the StatusStrip.")]
        [DefaultValue(null)]
        public Font StatusStripFont
        {
            get => InternalKCT.InternalStatusStripFont;

            set
            {
                InternalKCT.InternalStatusStripFont = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// Resets the StatusStripFont property to its default value.
        /// </summary>
        public void ResetStatusStripFont()
        {
            StatusStripText = Color.Empty;
        }
        #endregion

        #region StatusStripGradientBegin
        /// <summary>
        /// Gets and sets the starting color of the gradient used on the StatusStrip.
        /// </summary>
        [KryptonPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Starting color of the gradient used on the StatusStrip.")]
        [KryptonDefaultColorAttribute()]
        public Color StatusStripGradientBegin
        {
            get => InternalKCT.InternalStatusStripGradientBegin;

            set 
            { 
                InternalKCT.InternalStatusStripGradientBegin = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// Resets the StatusStripGradientBegin property to its default value.
        /// </summary>
        public void ResetStatusStripGradientBegin()
        {
            StatusStripGradientBegin = Color.Empty;
        }
        #endregion

        #region StatusStripGradientEnd
        /// <summary>
        /// Gets and sets the ending color of the gradient used on the StatusStrip.
        /// </summary>
        [KryptonPersist(false)]
        [Category("ToolMenuStatus")]
        [Description("Ending color of the gradient used on the StatusStrip.")]
        [KryptonDefaultColorAttribute()]
        public Color StatusStripGradientEnd
        {
            get => InternalKCT.InternalStatusStripGradientEnd;

            set 
            { 
                InternalKCT.InternalStatusStripGradientEnd = value;
                PerformNeedPaint(false);
            }
        }

        /// <summary>
        /// Resets the StatusStripGradientEnd property to its default value.
        /// </summary>
        public void ResetStatusStripGradientEnd()
        {
            StatusStripGradientEnd = Color.Empty;
        }
        #endregion
    }
}
