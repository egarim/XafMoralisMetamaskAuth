﻿using DevExpress.ExpressApp.Blazor.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XafMoralisMetamaskAuth.Module.Blazor
{
    public class InputModel : ComponentModelBase
    {
        public string Value
        {
            get => GetPropertyValue<string>();
            set => SetPropertyValue(value);
        }
        public bool ReadOnly
        {
            get => GetPropertyValue<bool>();
            set => SetPropertyValue(value);
        }
        // ...
        public void SetValueFromUI(string value)
        {
            SetPropertyValue(value, notify: false, nameof(Value));
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler ValueChanged;
    }
}
