/*
*----------------------------------------------------------------------------------
*          Filename:	ViewModelBase.cs
*          Date:        2023.07.26
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFChangeButtonImageOnClick.UI.ViewModels;

public class ViewModelBase : INotifyPropertyChanged
{
    #region Fields

    

    #endregion

    #region Properties

    #endregion

    #region Constructor

    #endregion

    #region Methods
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
    #endregion

    #region Commands

    #endregion

    #region Events
    public event PropertyChangedEventHandler? PropertyChanged;
    #endregion

    

   
}