// <copyright file="NotifiableObject.cs" company="RapidAutomaticTechnology">
// Copyright (c) RapidAutomaticTechnology. All rights reserved.
// </copyright>

namespace RAT.ComponentModel
{
    using RAT.Events;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.Contracts;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public abstract class NotifiableObject : SynchronizedObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged<T>(Expression<Func<T>> prperty_expression)
        {
            Contract.Requires(prperty_expression != null);
            var memberExpression = prperty_expression.Body as MemberExpression;
            Contract.Assume(memberExpression != null);

            RaisePropertyChanged(memberExpression.Member.Name);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string property_name = "")
        {
            var handler = Interlocked.CompareExchange(ref this.PropertyChanged, null, null);
            if (handler != null)
            {
                var args = EventArgsFactory.GetPropertyChangedEventArgs(property_name);
                handler(this, args);
            }
        }

        protected void SetPropertyForce<T>(ref T item, T value, [CallerMemberName] string property_name = "")
        {
            item = value;
            RaisePropertyChanged(property_name);
        }

        protected void SetProperty<T>(ref T item, T value, [CallerMemberName] string property_name = "")
        {
            if (!EqualityComparer<T>.Default.Equals(item, value))
            {
                this.SetPropertyForce(ref item, value, property_name);
            }
        }

        protected void SetPropertyForce<T>(ref T item, T value, Action callback, [CallerMemberName] string property_name = "")
        {
            Contract.Requires(callback != null);

            item = value;
            RaisePropertyChanged(property_name);
            callback();
        }

        protected void SetProperty<T>(ref T item, T value, Action callback, [CallerMemberName] string property_name = "")
        {
            Contract.Requires(callback != null);

            if (!EqualityComparer<T>.Default.Equals(item, value))
            {
                this.SetPropertyForce(ref item, value, property_name);
                callback();
            }
        }
    }
}
