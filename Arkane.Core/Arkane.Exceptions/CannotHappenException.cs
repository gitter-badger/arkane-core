#region header

// Arkane.Exceptions - CannotHappenException.cs
// 
// Alistair J. R. Young
// Arkane Systems
// 
// Copyright Arkane Systems 2012-2017.  All rights reserved.
// 
// Created: 2018-05-23 11:08 AM

#endregion

#region using

using System ;
using System.Runtime.Serialization ;
using System.Security.Permissions ;

using ArkaneSystems.Arkane.Exceptions.Properties ;

using JetBrains.Annotations ;

#endregion

namespace ArkaneSystems.Arkane.Exceptions
{
    /// <summary>
    ///     Exception thrown to indicate that something has happened that cannot happen.  This exception should be
    ///     used to indicate code branches which it is logically impossible, within the structure of the program, for
    ///     execution to reach; e.g., the default branch of switch statements which provide a case for every member
    ///     of an enum, and the like.
    /// </summary>
    /// <remarks>
    ///     This is treated as a special case of <see cref="InvalidOperationException" />.
    /// </remarks>
    [Serializable]
    [PublicAPI]
    public sealed class CannotHappenException : InvalidOperationException
    {
        /// <inheritdoc />
        public CannotHappenException ()
            : base (Resources.CannotHappenException_Default)
        { }

        /// <inheritdoc />
        public CannotHappenException ([CanBeNull] string message)
            : base (message)
        { }

        /// <inheritdoc />
        public CannotHappenException ([CanBeNull] string message, [CanBeNull] Exception innerException)
            : base (message, innerException)
        { }

        /// <inheritdoc />
        [SecurityPermission (SecurityAction.Demand, SerializationFormatter = true)]
        private CannotHappenException ([NotNull] SerializationInfo info, StreamingContext context)
            : base (info, context)
        { }
    }
}
