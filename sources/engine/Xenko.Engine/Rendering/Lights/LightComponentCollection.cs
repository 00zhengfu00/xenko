// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Xenko.Core;
using Xenko.Core.Collections;
using Xenko.Engine;

namespace Xenko.Rendering.Lights
{
    /// <summary>
    /// A list of <see cref="LightComponent"/> for a specified <see cref="RenderGroupMask"/>.
    /// </summary>
    public class LightComponentCollection : FastList<LightComponent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightComponentCollection"/> class.
        /// </summary>
        public LightComponentCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LightComponentCollection"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        public LightComponentCollection(int capacity)
            : base(capacity)
        {
        }

        /// <summary>
        /// Gets or sets the culling mask.
        /// </summary>
        /// <value>The culling mask.</value>
        public RenderGroupMask CullingMask { get; internal set; }

        /// <summary>
        /// Tags attached.
        /// </summary>
        public PropertyContainer Tags;
    }
}
