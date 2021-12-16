using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace XafMoralisMetamaskAuth.Module
{
    [DomainComponent, Serializable]
    [System.ComponentModel.DisplayName("Log In")]
    public class CustomLogonParameters : INotifyPropertyChanged
    {
        protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(sender, e);
        }


        string login;

        public string Login
        {
            get => login;
            set
            {
                if (login == value)
                    return;
                login = value;
                OnPropertyChanged(this, new PropertyChangedEventArgs(nameof(Login)));
            }
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
