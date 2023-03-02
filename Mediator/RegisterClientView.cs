namespace Mediator
{
    internal class RegisterClientView : IMediator
    {
        private MRadioButton _radioButtonF;
        private MRadioButton _radioButtonP;
        private Label _labelFirstName;
        private Label _labelName;
        private Label _labelNR;
        private TextBox _textBoxFirstName;

        public RegisterClientView(MRadioButton radioButtonF, MRadioButton radioButtonP,
            Label firstName, Label name, Label nr, TextBox firstNameTB)
        {
            _radioButtonF = radioButtonF;
            _radioButtonP = radioButtonP;
            _labelFirstName = firstName;
            _labelName = name;
            _labelNR = nr;
            _textBoxFirstName = firstNameTB;

            _radioButtonF.SetMediator(this);
            _radioButtonP.SetMediator(this);
        }

        public void Notify(Component sender, Args arg)
        {
            if (sender == _radioButtonF) 
            {
                switch (arg)
                {
                    case Args.RADIO_BUTTON_CHECKED:
                        _labelFirstName.Visible = false;
                        _textBoxFirstName.Visible = false;
                        _labelName.Text = "Nazwa firmy:";
                        _labelNR.Text = "REGON:";
                        _labelNR.Location = new Point(70, 139);
                        _labelName.Location = new Point(26, 102);
                        break;
                    case Args.RADIO_BUTTON_UNCHECKED:
                        _labelFirstName.Visible = true;
                        _textBoxFirstName.Visible = true;
                        _labelName.Text = "Nazwisko:";
                        _labelNR.Text = "NIP:";
                        _labelNR.Location = new Point(102, 139);
                        _labelName.Location = new Point(52, 102);
                        break;
                }
            }
            
        }
    }
}
