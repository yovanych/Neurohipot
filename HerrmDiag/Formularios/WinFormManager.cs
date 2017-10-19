using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace HermDiag
{
    public class WinFormManager
    {
        private readonly Dictionary<Type, Form> instancesDictionary = new Dictionary<Type, Form>();

        public WinFormManager()
        {
            instancesDictionary = new Dictionary<Type, Form>();
        }

        public Form GetInstance( Type formType, bool activateIfExist )
        {
            Form f;
            if ( !ContainsForm( formType ) )
            {
                f = CreateForm( formType );
                if ( f != null )
                {
                    f.FormClosed += f_FormClosed;
                    instancesDictionary[formType] = f;
                }
                else
                    throw new InvalidOperationException( "Couldn't create form" );
            }
            else
            {
                f = instancesDictionary[formType];
                if ( activateIfExist )
                    ActivateForm( f );
            }

            return f;
        }

        void f_FormClosed( object sender, FormClosedEventArgs e )
        {
            Type t = sender.GetType();
            instancesDictionary.Remove( t );
        }

        public void Show( Type formType, Form mdiParent )
        {
            Form f = GetInstance( formType, true );
            f.MdiParent = mdiParent;
            //ActivateForm(f);
            f.Show();
        }
        public void Show( Type formType )
        {
            Form f = GetInstance( formType, true );
            //ActivateForm(f);
            f.Show();
        }

        public DialogResult ShowDialog( Type formType )
        {
            Form f;

            if ( ContainsForm( formType ) ) //Close if already opened to show in modal
            {
                f = GetInstance( formType, false );
                //if (f.Visible)
                f.Close();
            }

            f = GetInstance( formType, false );
            //ActivateForm(f);

            return f.ShowDialog();
        }

        private void ActivateForm( Form f )
        {
            if ( f.WindowState == FormWindowState.Minimized )
                f.WindowState = FormWindowState.Normal;
            f.Focus();
        }

        public bool ContainsForm( Type formType )
        {
            return (instancesDictionary.Keys.Contains( formType ) && instancesDictionary[formType] != null);
        }

        private Form CreateForm( Type formType )
        {
            ConstructorInfo ci = formType.GetConstructor( Type.EmptyTypes );

            if ( ci != null )
                return (Form)ci.Invoke( null );
            return null;
        }
    }
}
