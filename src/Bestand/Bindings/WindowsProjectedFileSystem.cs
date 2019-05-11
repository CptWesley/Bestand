using System;

namespace Bestand.Bindings
{
    /// <summary>
    /// Bindings for the Windows Projected File System.
    /// </summary>
    /// <seealso cref="IVirtualFileSystemBindings" />
    public class WindowsProjectedFileSystem : IVirtualFileSystemBindings
    {
        /// <inheritdoc/>
        public IntPtr Mount(string path, VirtualFileSystem fileSystem)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void Unmount(IntPtr handle)
        {
            throw new NotImplementedException();
        }
    }
}
