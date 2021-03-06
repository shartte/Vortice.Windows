﻿// Copyright (c) Amer Koleci and contributors.
// Distributed under the MIT license. See the LICENSE file in the project root for more information.

using SharpGen.Runtime;

namespace Vortice.Direct2D1
{
    public partial class ID2D1Bitmap1
    {
        /// <inheritdoc/>
        protected override unsafe void Dispose(bool disposing)
        {
            if (disposing)
            {
                ReleaseColorContext();
            }

            base.Dispose(disposing);
        }

        private void ReleaseColorContext()
        {
            if (ColorContext__ != null)
            {
                // Don't use Dispose() in order to avoid circular references
                ((IUnknown)ColorContext__).Release();
                ColorContext__ = null;
            }
        }
    }
}
