using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ApBox.Annotations;

namespace ApBox
{
    public class ViewModel : INotifyPropertyChanged
    {
        private NestedEnum _selectedValue;
        public event PropertyChangedEventHandler PropertyChanged;

        public NestedEnum SelectedValue
        {
            get { return _selectedValue; }
            set
            {
                if (value == _selectedValue) return;
                _selectedValue = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ValueAndDescription> Members
        {
            get
            {
                return Enum.GetValues(typeof(ViewModel.NestedEnum))
                    .Cast<ViewModel.NestedEnum>()
                    .Select(x => new ValueAndDescription(x));
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        public enum NestedEnum
        {
            [Description("Ett")]
            One,
            [Description("Två")]
            Two
        }
    }
}
