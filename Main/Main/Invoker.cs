using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    static class Invoker
    {

        public enum Mode
        {
            SetMaximum = 0,
            SetValue = 1

        }

        //All Controls
        private delegate void _ChangeVisible(Control ctrl, bool state);
        private delegate void _ChangeEnable(Control ctrl, bool state);

        //Forms
        private delegate void _ChangeVisibilityForm(Form frm, bool state);

        //NumericUpDown
        private delegate void _SetNumericValue(NumericUpDown ctrl, decimal val);

        //Control
        private delegate void _SetText(Control label, string msg, string clr);

        //Progressbar
        private delegate void _SetPrgbValue(ProgressBar prgb, int value, Mode mode);

        //ListView
        private delegate void _AddListItem(ListView list, string value, bool subItem = false, string subValue = "", string tag = "");
        private delegate void _AddListItemRaw(ListView list, ListViewItem itm);
        private delegate void _ClearListView(ListView list);
        private delegate void _UpdateListView(ListView list, bool start = true);

        //Progressspinner
        private delegate void _ProgressSpinner_SetMaximum(MetroFramework.Controls.MetroProgressSpinner spinner, int val);
        private delegate void _ProgressSpinner_SetMinimum(MetroFramework.Controls.MetroProgressSpinner spinner, int val);
        private delegate void _ProgressSpinner_SetValue(MetroFramework.Controls.MetroProgressSpinner spinner, int val);

        public static void ProgressSpinner_SetMaximum(MetroFramework.Controls.MetroProgressSpinner spinner, int val)
        {
            try
            {
                if (spinner.InvokeRequired)
                {
                    spinner.Invoke(new _ProgressSpinner_SetMaximum(ProgressSpinner_SetMaximum), spinner, val);
                }
                else
                {
                    spinner.Maximum = val;
                }
            }
            catch (System.Exception)
            {

            }
        }
        public static void ProgressSpinner_SetMinimum(MetroFramework.Controls.MetroProgressSpinner spinner, int val)
        {
            try
            {
                if (spinner.InvokeRequired)
                {
                    spinner.Invoke(new _ProgressSpinner_SetMinimum(ProgressSpinner_SetMinimum), spinner, val);
                }
                else
                {
                    spinner.Minimum = val;
                }
            }
            catch (System.Exception)
            {

            }
        }
        public static void ProgressSpinner_SetValue(MetroFramework.Controls.MetroProgressSpinner spinner, int val)
        {
            try
            {
                if (spinner.InvokeRequired)
                {
                    spinner.Invoke(new _ProgressSpinner_SetValue(ProgressSpinner_SetValue), spinner, val);
                }
                else
                {
                    spinner.Value = val;
                }
            }
            catch (System.Exception)
            {

            }
        }
        public static void ChangeVisibilityForm(Form frm, bool state)
        {
            try
            {
                if (frm.InvokeRequired)
                {
                    frm.Invoke(new _ChangeVisibilityForm(ChangeVisibilityForm), frm, state);
                }
                else
                {
                    if (state)
                    {
                        frm.Show();
                    }
                    else
                    {
                        frm.Hide();
                    }
                }
            }
            catch (System.Exception)
            {
                
            }
        }
        public static void SetNumericValue(NumericUpDown ctrl, decimal val)
        {
            try
            {
                if (ctrl.InvokeRequired)
                {
                    ctrl.Invoke(new _SetNumericValue(SetNumericValue), ctrl, val);
                }
                else
                {
                    ctrl.Value = val;
                }
            }
            catch (System.Exception)
            {
                
            }
        }
        public static void ChangeVisible(Control ctrl, bool state)
        {
            try
            {
                if (ctrl.InvokeRequired)
                {
                    ctrl.Invoke(new _ChangeVisible(ChangeVisible), ctrl, state);
                }
                else
                {
                    ctrl.Visible = state;
                }
            }
            catch (System.Exception)
            {
                
            }
        }
        public static void ChangeEnable(Control ctrl, bool state)
        {
            try
            {
                if (ctrl.InvokeRequired)
                {
                    ctrl.Invoke(new _ChangeEnable(ChangeEnable), ctrl, state);
                }
                else
                {
                    ctrl.Enabled = state;
                }
            }
            catch { }
        }
        public static void SetText(Control cntrl, string msg, string clr = null)
        {
            try
            {
                if (cntrl.InvokeRequired)
                {
                    cntrl.Invoke(new _SetText(SetText), cntrl, msg, clr);
                }
                else
                {
                    cntrl.Text = msg;

                    if (clr != null)
                    {
                        cntrl.ForeColor = ColorTranslator.FromHtml(clr);
                    }
                }
            }
            catch { }
        }

        public static void UpdateList(ListView list, bool start = true)
        {
            try
            {
                if (list.InvokeRequired)
                {
                    list.Invoke(new _UpdateListView(UpdateList), list, start);
                }
                else
                {
                    if (start)
                    {
                        list.BeginUpdate();
                    }
                    else
                    {
                        list.EndUpdate();
                    }
                }
            }
            catch { }
        }
        public static void ClearList(ListView list)
        {
            try
            {
                if (list.InvokeRequired)
                {
                    list.Invoke(new _ClearListView(ClearList), list);
                }
                else
                {
                    list.Items.Clear();
                }
            }
            catch { }
        }
        public static void AddListItem(ListView list, ListViewItem itm)
        {
            try
            {
                if (list.InvokeRequired)
                {
                    list.Invoke(new _AddListItemRaw(AddListItem), list, itm);
                }
                else
                {
                    list.Items.Add(itm);
                }
            }
            catch { }
        }
        public static void AddListItem(ListView list, string value, bool subItem = false, string subValue = "", string tag = "")
        {
            try
            {
                if (list.InvokeRequired)
                {
                    list.Invoke(new _AddListItem(AddListItem), list, value, subItem, subValue, tag);
                }
                else
                {
                    ListViewItem itm = new ListViewItem();
                    itm.Tag = tag;
                    itm.Text = value;
                    if (subItem)
                    {
                        itm.SubItems.Add(subValue);
                    }
                    list.Items.Add(itm);
                }
            }
            catch { }
        }

        public static void SetPrgbState(ProgressBar prgb, int value, Mode mode)
        {
            try
            {
                if (prgb.InvokeRequired)
                {
                    prgb.Invoke(new _SetPrgbValue(SetPrgbState), prgb, value, mode);
                }
                else
                {
                    if (mode == Mode.SetMaximum)
                    {
                        prgb.Maximum = value;
                    }
                    else if (mode == Mode.SetValue)
                    {
                        prgb.Value = value;
                    }

                }
            }
            catch { }
        }

    }
}
