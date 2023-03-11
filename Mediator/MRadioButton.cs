namespace Mediator
{
    internal class MRadioButton : Component
    {
        public RadioButton MyRadioButton { get; } = new RadioButton();
        public MRadioButton(RadioButton button)
        {
            MyRadioButton = button;
            MyRadioButton.CheckedChanged += new EventHandler(rbutton_CheckedChanged);
        }

        private void rbutton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if(rb.Checked)
            {
                _mediator.Notify(this, Args.RADIO_BUTTON_CHECKED);
            }
        }
    }
}
