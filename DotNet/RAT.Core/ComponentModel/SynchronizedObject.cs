// <copyright file="SynchronizedObject.cs" company="RapidAutomaticTechnology">
// Copyright (c) RapidAutomaticTechnology. All rights reserved.
// </copyright>

namespace RAT.ComponentModel
{
    public abstract class SynchronizedObject
    {
        private readonly object syncObj = new object();

        protected object SyncObj
        {
            get
            {
                return this.syncObj;
            }
        }
    }
}
