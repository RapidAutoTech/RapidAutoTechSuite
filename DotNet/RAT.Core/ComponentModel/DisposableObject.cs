// <copyright file="DisposableObject.cs" company="RapidAutomaticTechnology">
// Copyright (c) RapidAutomaticTechnology. All rights reserved.
// </copyright>

namespace RAT.ComponentModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class DisposableObject : SynchronizedObject, IDisposable
    {
        private bool disposed = false;

        public void Dispose()
        {
            DisposeInner(true);
            GC.SuppressFinalize(this);
        }

        protected void DisposeInner(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.DisposeInternal();
            }

            this.disposed = true;
        }

        protected abstract void DisposeInternal();
    }
}
