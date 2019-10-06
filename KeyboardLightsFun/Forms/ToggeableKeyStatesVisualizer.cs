using System.Drawing;
using System.Windows.Forms;

namespace YonatanMankovich.KeyboardLightsFun
{
    public partial class ToggeableKeyStatesVisualizer : UserControl
    {
        public ToggeableKeyStatesVisualizer()
        {
            InitializeComponent();
            MakeInactive();
        }

        public void Set(ToggleableKeyStates toggleableKeyStates)
        {
            SetColors(toggleableKeyStates.NumLockState ? Color.Green : Color.Red,
                toggleableKeyStates.CapsLockState ? Color.Green : Color.Red,
                toggleableKeyStates.ScrollLockState ? Color.Green : Color.Red);
        }

        public void MakeInactive()
        {
            SetColors(Color.Gray, Color.Gray, Color.Gray);
        }

        public void SetColors(Color color0, Color color1, Color color2)
        {
            visualizerPanel.GetControlFromPosition(0, 0).BackColor = color0;
            visualizerPanel.GetControlFromPosition(1, 0).BackColor = color1;
            visualizerPanel.GetControlFromPosition(2, 0).BackColor = color2;
        }
    }
}