/*
*----------------------------------------------------------------------------------
*          Filename:	MainWindowViewModel.cs
*          Date:        2023.07.26
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

namespace WPFChangeButtonImageOnClick.UI.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    #region Fields
    #endregion

    #region Properties

    public string DemoText { get; }
    public string DemoText2 { get; }
    #endregion

    #region Constructor

    public MainWindowViewModel()
    {
        DemoText = "Test1234";
        DemoText2 = "Hallo";
    }
    #endregion

    #region Methods

    #endregion

    #region Commands

    #endregion
}