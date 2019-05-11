using System;

namespace Bestand.Bindings
{
    /// <summary>
    /// Interface for VFS binding factories.
    /// </summary>
    public interface IVirtualFileSystemBindingsFactory
    {
        /// <summary>
        /// Creates a bindings instance.
        /// </summary>
        /// <returns>A OS specific bindings.</returns>
        /// <exception cref="NotSupportedException">Thrown when the operating system is not supported.</exception>
        IVirtualFileSystemBindings Create();
    }
}
