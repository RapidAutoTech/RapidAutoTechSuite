// <copyright file="EventArgsFactory.cs" company="RapidAutomaticTechnology">
// Copyright (c) RapidAutomaticTechnology. All rights reserved.
// </copyright>

namespace RAT.Events
{
    using System.Collections.Concurrent;
    using System.ComponentModel;

    internal static class EventArgsFactory
    {
        private static readonly ConcurrentDictionary<string, PropertyChangedEventArgs> PropertyChangedEventArgsDictionary =
            new ConcurrentDictionary<string, PropertyChangedEventArgs>();

        public static PropertyChangedEventArgs GetPropertyChangedEventArgs(string proeprty_name)
        {
            return PropertyChangedEventArgsDictionary.GetOrAdd(proeprty_name, name => new PropertyChangedEventArgs(name));
        }
    }
}
