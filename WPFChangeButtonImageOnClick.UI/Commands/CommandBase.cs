/*
*----------------------------------------------------------------------------------
*          Filename:	CommandBase.cs
*          Date:        2023.07.26
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;
using System.Windows.Input;

namespace WPFChangeButtonImageOnClick.UI.Commands;


public abstract class CommandBase : ICommand
{
    #region Implementation of ICommand

    public event EventHandler? CanExecuteChanged;
    
    public virtual bool CanExecute(object? parameter) => true;

    public abstract void Execute(object? parameter);

    protected void OnCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, new EventArgs());
    }
    
    #endregion
}