#region header

// Arkane.Exceptions - SubclassResponsibilityException.cs
// 
// Alistair J. R. Young
// Arkane Systems
// 
// Copyright Arkane Systems 2012-2018.  All rights reserved.
// 
// Created: 2018-05-23 11:26 AM

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
    ///     Exception thrown to indicate that implementing a particular method or property is the responsibility
    ///     of a subclass of the class which has thrown the exception.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         This is essentially a special case of <see cref="NotImplementedException" />, relating to
    ///         functionality that is not implemented in a superclass because subclasses are intended to
    ///         implement it on its behalf.
    ///     </para>
    ///     <para>
    ///         Before throwing this, bethink you whether the class you're implementing really ought to be an
    ///         abstract class instead.  That is to be preferred; this is the second choice.
    ///     </para>
    /// </remarks>
    [Serializable]
    [PublicAPI]
    public sealed class SubclassResponsibilityException : NotImplementedException
    {
        /// <inheritdoc />
        public SubclassResponsibilityException ()
            : base (Resources.SubclassResponsibilityException_Default)
        { }

        /// <inheritdoc />
        public SubclassResponsibilityException ([CanBeNull] string message)
            : base (message)
        { }

        /// <inheritdoc />
        public SubclassResponsibilityException ([CanBeNull] string message, [CanBeNull] Exception innerException)
            : base (message, innerException)
        { }

        /// <inheritdoc />
        [SecurityPermission (SecurityAction.Demand, SerializationFormatter = true)]
        private SubclassResponsibilityException ([NotNull] SerializationInfo info, StreamingContext context)
            : base (info, context)
        { }
    }
}
