using System;

namespace Bestand.Bindings
{
    /// <summary>
    /// Provides an interface for different virtual file system bindings.
    /// </summary>
    public interface IVirtualFileSystemBindings
    {
        /// <summary>
        /// Mounts the virtual file system at the given path.
        /// </summary>
        /// <param name="path">The path to mount at.</param>
        /// <param name="fileSystem">The file system to mount.</param>
        /// <returns>Handle of the virtual file system.</returns>
        IntPtr Mount(string path, VirtualFileSystem fileSystem);

        /// <summary>
        /// Unmounts the specified virtual file system.
        /// </summary>
        /// <param name="handle">The handle of the virtual file system.</param>
        void Unmount(IntPtr handle);
    }
}
