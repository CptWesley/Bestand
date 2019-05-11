using System;
using Bestand.Bindings;

namespace Bestand
{
    /// <summary>
    /// Basis for virtual file systems.
    /// </summary>
    public abstract class VirtualFileSystem
    {
        private readonly IVirtualFileSystemBindings bindings;
        private IntPtr handle;

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualFileSystem"/> class.
        /// </summary>
        public VirtualFileSystem()
        {
            bindings = new VirtualFileSystemBindingsFactory().Create();
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="VirtualFileSystem"/> is mounted.
        /// </summary>
        public bool Mounted { get; }

        /// <summary>
        /// Mounts the virtual file system at the given mount path.
        /// </summary>
        /// <param name="path">The path to mount at.</param>
        public void Mount(string path)
        {
            handle = bindings.Mount(path, this);
        }

        /// <summary>
        /// Unmounts this virtual fize system.
        /// </summary>
        public void Unmount()
        {
            bindings.Unmount(handle);
        }
    }
}
