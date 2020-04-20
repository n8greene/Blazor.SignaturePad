// Copyright (c) 2020 Allan Mobley. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Components;

namespace Mobsites.Blazor
{
    /// <summary>
    /// Child component for clearing the <see cref="SignaturePad"/> component.
    /// </summary>
    public partial class SignaturePadClear
    {
        /// <summary>
        /// Content to render.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }
        
        /// <summary>
        /// URL or URL fragment for image source.
        /// </summary>
        [Parameter] public string Image { get; set; }

        private int imageWidth = 36;
        
        /// <summary>
        /// Image width in pixels. Defaults to 36px.
        /// </summary>
        [Parameter] public int ImageWidth 
        { 
            get => imageWidth; 
            set 
            { 
                if (value > 0)
                {
                    imageWidth = value;
                } 
            } 
        }

        private int imageHeight = 36;
        
        /// <summary>
        /// Image height in pixels. Defaults to 36px.
        /// </summary>
        [Parameter] public int ImageHeight 
        { 
            get => imageHeight; 
            set 
            { 
                if (value > 0)
                {
                    imageHeight = value;
                } 
            } 
        }
    }
}