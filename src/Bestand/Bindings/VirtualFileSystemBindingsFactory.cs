using System;
using System.Runtime.InteropServices;

namespace Bestand.Bindings
{
    /// <summary>
    /// Builder for virtual file system bindings.
    /// </summary>
    public class VirtualFileSystemBindingsFactory : IVirtualFileSystemBindingsFactory
    {
        /// <inheritdoc/>
        public IVirtualFileSystemBindings Create()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return new WindowsProjectedFileSystem();
            }

            throw new NotSupportedException();
        }
    }
}
