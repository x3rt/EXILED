// -----------------------------------------------------------------------
// <copyright file="ExiledSerializableAttribute.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Features.Attributes
{
    using System;

    /// <summary>
    /// An attribute to easily manage Exiled features' behavior.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class ExiledSerializableAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExiledSerializableAttribute"/> class.
        /// </summary>
        public ExiledSerializableAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExiledSerializableAttribute"/> class.
        /// </summary>
        /// <param name="type"><inheritdoc cref="ItemType"/></param>
        public ExiledSerializableAttribute(ItemType type) => ItemType = type;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExiledSerializableAttribute"/> class.
        /// </summary>
        /// <param name="role"><inheritdoc cref="RoleType"/></param>
        public ExiledSerializableAttribute(RoleType role) => RoleType = role;

        /// <summary>
        /// Gets the attribute's <see cref="ItemType"/>.
        /// </summary>
        public ItemType ItemType { get; }

        /// <summary>
        /// Gets the attribute's <see cref="RoleType"/>.
        /// </summary>
        public RoleType RoleType { get; }
    }
}