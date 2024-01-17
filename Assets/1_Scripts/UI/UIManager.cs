using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public UIDialogManagement dialog;
    public UIDialogManagement fade;

    private UIFadeDialog m_fadeDialog;

    public UIFadeDialog fadeDialog
    {
        get
        {
            if (PUtil.UIUtil.IsOpen(m_fadeDialog) == false)
            {
                m_fadeDialog = fade.GetDlg<UIFadeDialog>("UI/UIFade/UIFadeDialog");
            }

            return m_fadeDialog;
        }
    }

    public void Clear()
    {
        dialog.Clear();
    }
}