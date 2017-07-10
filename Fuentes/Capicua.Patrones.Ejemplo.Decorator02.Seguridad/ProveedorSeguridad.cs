using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Capicua.Patrones.Ejemplo.Decorator02.Seguridad
{
    [ProvideProperty("Action", typeof(Control))]
    [ProvideProperty("HideControl", typeof(Control))]
    [ProvideProperty("DisableControl", typeof(Control))]
    public partial class ProveedorSeguridad : System.ComponentModel.Component, IExtenderProvider, ISupportInitialize
    {
        #region Propiedades

        private Dictionary<Control, string> ActionProperties;

        private string usuario;

        /// <summary>
        /// Usuario al cual aplicar la seguridad
        /// </summary>
        public string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                if (usuario != value)
                {
                    usuario = value;
                    RefreshPermisions();
                }
            }
        }

        #endregion Propiedades

        #region Constructor

        public ProveedorSeguridad()
        {
            InitializeComponent();
            ActionProperties = new Dictionary<Control, string>();
        }

        public ProveedorSeguridad(System.ComponentModel.IContainer container)
                : this()
        {
            container.Add(this);
        }

        #endregion Constructor

        #region propiedades extensoras

        /// <summary>
        /// Decoro la propiedad accion
        /// </summary>
        /// <param name="control"></param>
        /// <param name="value"></param>
        public void SetAction(Control control, string value)
        {
            ActionProperties[control] = value;

            try
            {
                control.EnabledChanged -= Control_EnabledChanged;
            }
            catch { }

            if (!string.IsNullOrEmpty(value))

            {
                control.EnabledChanged += Control_EnabledChanged;
                Control_EnabledChanged(control, new System.EventArgs());
            }
        }

        /// <summary>
        /// Decoro la propiedad accion
        /// </summary>
        /// <param name="control"></param>
        /// <param name="value"></param>
        public string GetAction(Control control)
        {
            string value = string.Empty;
            ActionProperties.TryGetValue(control, out value);
            return value;
        }

        #endregion propiedades extensoras

        #region IExtenderProvider.CanExtend

        bool IExtenderProvider.CanExtend(object o)
        {
            if (o is Control)
                return true;
            else
                return false;
        }

        #endregion IExtenderProvider.CanExtend

        #region ISupportInitialize

        void ISupportInitialize.BeginInit()
        {
        }

        void ISupportInitialize.EndInit()
        {
        }

        #endregion ISupportInitialize

        #region seguridad

        private Dictionary<string, string[]> permisos = new Dictionary<string, string[]>
        {
           { "Juan", new string[]{ "Accion1", "Accion3" } },
           { "Pedro", new string[]{ "Accion2"} },
        };

        private void Control_EnabledChanged(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;
            if (Usuario == null) return;

            if (!control.Enabled || this.DesignMode) return;

            string[] values;
            if (permisos.TryGetValue(Usuario, out values))
            {
                control.Enabled = values.Contains(this.GetAction(control));
            }
            else
            {
                control.Enabled = false;
            }
        }

        public void RefreshPermisions()
        {
            foreach (Control control in ActionProperties.Keys)
            {
                Control_EnabledChanged(control, new System.EventArgs());
            }
        }

        #endregion seguridad
    }
}